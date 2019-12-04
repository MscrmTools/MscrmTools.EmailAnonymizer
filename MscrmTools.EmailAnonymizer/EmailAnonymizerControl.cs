using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using MscrmTools.EmailAnonymizer.AppCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;
using StringFormat = Microsoft.Xrm.Sdk.Metadata.StringFormat;

namespace MscrmTools.EmailAnonymizer
{
    public partial class EmailAnonymizerControl : PluginControlBase, IGitHubPlugin
    {
        private bool _cancel;
        private IEnumerable<EntityMetadata> _emd;
        private Dictionary<Guid, string> _names = new Dictionary<Guid, string>();

        public EmailAnonymizerControl()
        {
            InitializeComponent();

            var tt = new ToolTip();
            tt.SetToolTip(lvAttributes, @"Double click on items to add them in the list of attributes to anonymize");
            tt.SetToolTip(lvSummary, @"Double click on items to remove them from the list of attributes to anonymize");
            tt.SetToolTip(txtFormat, @"Provide a format for the anonymized email address.

Tag {0} will be replace by a counter
Format provided must be compliant with email address format. No control will be performed");
        }

        public string RepositoryName => "MscrmTools.EmailAnonymizer";

        public string UserName => "MscrmTools";

        public void LoadEntities()
        {
            SetWorkingState(true);

            WorkAsync(
            new WorkAsyncInfo
            {
                Message = "Loading entities...",
                Work = (bw, e) =>
                {
                    _emd = Service.GetEmailEnabledEntities();

                    var items = new List<ListViewItem>();
                    items.AddRange(_emd.Select(emd => new ListViewItem
                    {
                        Text = emd.DisplayName.UserLocalizedLabel.Label,
                        SubItems =
                        {
                            new ListViewItem.ListViewSubItem {Text = emd.LogicalName}
                        },
                        Tag = emd
                    }));

                    e.Result = items;
                },
                PostWorkCallBack = e =>
                {
                    lvEntities.Items.Clear();
                    SetWorkingState(false);

                    if (e.Error != null)
                    {
                        MessageBox.Show(this,
                            $@"An error occured while loading email enabled entities: {e.Error.Message}",
                            @"Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    lvEntities.Items.AddRange(((List<ListViewItem>)e.Result).ToArray());
                }
            });
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            lvEntities.Items.Clear();
            lvAttributes.Items.Clear();
            lvSummary.Items.Clear();

            LoadEntities();
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var lv = (ListView)sender;
            lv.Sorting = lv.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            lv.ListViewItemSorter = new ListViewItemComparer(e.Column, lv.Sorting);
        }

        private void lvAttributes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvAttributes.SelectedItems.Count == 0)
                return;

            var attribute = (StringAttributeMetadata)lvAttributes.SelectedItems[0].Tag;

            foreach (ListViewItem sItem in lvSummary.Items)
            {
                if (sItem.Tag.Equals(attribute))
                {
                    return;
                }
            }

            lvSummary.Items.Add(new ListViewItem
            {
                Text = attribute.EntityLogicalName,
                SubItems =
                {
                    new ListViewItem.ListViewSubItem {Text = attribute.DisplayName?.UserLocalizedLabel?.Label},
                    new ListViewItem.ListViewSubItem {Text = attribute.LogicalName}
                },
                Tag = attribute
            });

            tsbAnonymize.Enabled = lvSummary.Items.Count > 0;
        }

        private void lvEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvAttributes.Items.Clear();

            if (lvEntities.SelectedItems.Count == 0)
            {
                return;
            }

            var emd = (EntityMetadata)lvEntities.SelectedItems[0].Tag;
            var attributes =
                emd.Attributes.Where(a => a is StringAttributeMetadata amd && amd.Format == StringFormat.Email);

            lvAttributes.Items.AddRange(attributes.Select(a =>
                new ListViewItem
                {
                    Text = a.DisplayName?.UserLocalizedLabel?.Label,
                    SubItems =
                    {
                        new ListViewItem.ListViewSubItem{Text = a.LogicalName}
                    },
                    Tag = a
                }).ToArray());
        }

        private void lvSummary_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvSummary.SelectedItems.Count == 0)
                return;

            lvSummary.Items.Remove(lvSummary.SelectedItems[0]);

            tsbAnonymize.Enabled = lvSummary.Items.Count > 0;
        }

        private void SetWorkingState(bool isWorking)
        {
            tsbLoadEntities.Enabled = !isWorking;
            tsbAnonymize.Enabled = !isWorking && lvSummary.Items.Count > 0;
            tsbCancel.Visible = isWorking;
            tssCancel.Visible = isWorking;
        }

        private void tsbAnonymize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, @"Are you sure you want to run this process?

All selected email attributes will be overwritten with a generic email value built on the format provided", @"Question",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No) return;

            _cancel = false;
            SetWorkingState(true);

            WorkAsync(new WorkAsyncInfo
            {
                AsyncArgument = new Settings
                {
                    Format = txtFormat.Text,
                    ItemsPerRequest = Convert.ToInt32(nudItemsPerRequest.Value),
                    Attributes = lvSummary.Items.Cast<ListViewItem>().Select(i => (StringAttributeMetadata)i.Tag).ToList()
                },
                ProgressChanged = (evt) =>
                {
                    SetWorkingMessage(evt.UserState.ToString());
                },
                Work = (bw, evt) =>
                {
                    var settings = (Settings)evt.Argument;
                    var attrGroups = settings.Attributes.GroupBy(a => a.EntityLogicalName);

                    double counter = 1;

                    foreach (var attrGroup in attrGroups)
                    {
                        if (_cancel)
                        {
                            evt.Cancel = true;
                            break;
                        }

                        bw.ReportProgress(0, $"Processing entity {attrGroup.Key}");

                        var primaryNameAttr = _emd.First(emd => emd.LogicalName == attrGroup.Key).PrimaryNameAttribute;

                        var query = new QueryExpression(attrGroup.Key)
                        {
                            NoLock = true,
                            ColumnSet = new ColumnSet(attrGroup.Select(a => a.LogicalName).ToArray()),
                            PageInfo = new PagingInfo
                            {
                                PageNumber = 1,
                                Count = settings.ItemsPerRequest
                            },
                            Criteria = new FilterExpression(LogicalOperator.Or)
                        };

                        query.ColumnSet.AddColumn(primaryNameAttr);

                        foreach (var attribute in attrGroup)
                        {
                            query.Criteria.AddCondition(attribute.LogicalName, ConditionOperator.NotNull);
                        }

                        EntityCollection ec;

                        do
                        {
                            if (_cancel)
                            {
                                evt.Cancel = true;
                                break;
                            }
                            bw.ReportProgress(0, $"Processing {attrGroup.Key} records {(query.PageInfo.PageNumber - 1) * query.PageInfo.Count + 1}-{query.PageInfo.PageNumber * query.PageInfo.Count}");

                            // Get records and prepare next page
                            ec = Service.RetrieveMultiple(query);
                            query.PageInfo.PageNumber++;
                            query.PageInfo.PagingCookie = ec.PagingCookie;

                            // Prepare bulk request for update
                            var request = new ExecuteMultipleRequest
                            {
                                Settings = new ExecuteMultipleSettings
                                {
                                    ContinueOnError = true,
                                    ReturnResponses = true
                                },
                                Requests = new OrganizationRequestCollection()
                            };

                            _names = new Dictionary<Guid, string>();

                            // Anonymize records
                            foreach (var record in ec.Entities)
                            {
                                _names.Add(record.Id, record.GetAttributeValue<string>(primaryNameAttr));
                                record.Attributes.Remove(primaryNameAttr);
                                foreach (var attribute in attrGroup)
                                {
                                    if (record.Contains(attribute.LogicalName))
                                    {
                                        record[attribute.LogicalName] = string.Format(settings.Format,
                                            counter.ToString(CultureInfo.InvariantCulture).PadLeft(10, '0'));
                                        counter++;
                                    }
                                }

                                request.Requests.Add(new UpdateRequest { Target = record });
                            }

                            var response = (ExecuteMultipleResponse)Service.Execute(request);
                            foreach (var r in response.Responses)
                            {
                                Invoke(new Action(() =>
                                {
                                    var ur = (UpdateRequest)request.Requests[r.RequestIndex];

                                    lvLogs.Items.Add(new ListViewItem(ur.Target.LogicalName)
                                    {
                                        SubItems =
                                        {
                                            _names[ur.Target.Id],
                                            ur.Target.Id.ToString("B"),
                                            r.Fault?.Message ?? $"attributes updated: {string.Join(" / ",ur.Target.Attributes.Where(a => a.Value is string).Select(a => a.Key + ":" + a.Value))}"
                                        },
                                        ForeColor = r.Fault != null ? Color.Red : Color.Green
                                    });
                                }));
                            }

                            if (response.IsFaulted)
                            {
                                throw new Exception("An error ocurred on at least one record to update");
                            }
                        } while (ec.MoreRecords);
                    }
                },
                PostWorkCallBack = (evt) =>
                {
                    SetWorkingState(false);

                    if (evt.Error != null)
                    {
                        MessageBox.Show(this, evt.Error.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (evt.Cancelled)
                    {
                        lvLogs.Items.Add(new ListViewItem("") { SubItems = { "", "", "Process was canceled by the user" } });
                    }
                }
            });
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            _cancel = true;
        }

        private void tsbClearLogs_Click(object sender, EventArgs e)
        {
            lvLogs.Items.Clear();
        }

        private void tsbLoadEntities_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadEntities);
        }
    }
}