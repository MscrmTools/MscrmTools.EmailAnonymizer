namespace MscrmTools.EmailAnonymizer
{
    partial class EmailAnonymizerControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbLoadEntities = new System.Windows.Forms.ToolStripButton();
            this.tssBeforeAnonymize = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAnonymize = new System.Windows.Forms.ToolStripButton();
            this.tssCancel = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tssLogs = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClearLogs = new System.Windows.Forms.ToolStripButton();
            this.gbEntities = new System.Windows.Forms.GroupBox();
            this.lvEntities = new System.Windows.Forms.ListView();
            this.chDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAttributes = new System.Windows.Forms.GroupBox();
            this.lvAttributes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSelectedAttributes = new System.Windows.Forms.GroupBox();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFormatTip = new System.Windows.Forms.Label();
            this.pnlFormat = new System.Windows.Forms.Panel();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.pnlBulkSettings = new System.Windows.Forms.Panel();
            this.nudItemsPerRequest = new System.Windows.Forms.NumericUpDown();
            this.lblBulkSettings = new System.Windows.Forms.Label();
            this.lvSummary = new System.Windows.Forms.ListView();
            this.chEntity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttributeDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAttributeLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvLogs = new System.Windows.Forms.ListView();
            this.chLogEntity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLogId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLogMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLogRecordName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripMenu.SuspendLayout();
            this.gbEntities.SuspendLayout();
            this.gbAttributes.SuspendLayout();
            this.gbSelectedAttributes.SuspendLayout();
            this.gbSettings.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.pnlFormat.SuspendLayout();
            this.pnlBulkSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemsPerRequest)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadEntities,
            this.tssBeforeAnonymize,
            this.tsbAnonymize,
            this.tssCancel,
            this.tsbCancel,
            this.tssLogs,
            this.tsbClearLogs});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1467, 42);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbLoadEntities
            // 
            this.tsbLoadEntities.Image = global::MscrmTools.EmailAnonymizer.Properties.Resources.ico_16_0;
            this.tsbLoadEntities.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadEntities.Name = "tsbLoadEntities";
            this.tsbLoadEntities.Size = new System.Drawing.Size(170, 36);
            this.tsbLoadEntities.Text = "Load Entities";
            this.tsbLoadEntities.Click += new System.EventHandler(this.tsbLoadEntities_Click);
            // 
            // tssBeforeAnonymize
            // 
            this.tssBeforeAnonymize.Name = "tssBeforeAnonymize";
            this.tssBeforeAnonymize.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbAnonymize
            // 
            this.tsbAnonymize.Enabled = false;
            this.tsbAnonymize.Image = global::MscrmTools.EmailAnonymizer.Properties.Resources.lightning;
            this.tsbAnonymize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnonymize.Name = "tsbAnonymize";
            this.tsbAnonymize.Size = new System.Drawing.Size(155, 36);
            this.tsbAnonymize.Text = "Anonymize";
            this.tsbAnonymize.Click += new System.EventHandler(this.tsbAnonymize_Click);
            // 
            // tssCancel
            // 
            this.tssCancel.Name = "tssCancel";
            this.tssCancel.Size = new System.Drawing.Size(6, 42);
            this.tssCancel.Visible = false;
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = global::MscrmTools.EmailAnonymizer.Properties.Resources.cancel;
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(106, 36);
            this.tsbCancel.Text = "Cancel";
            this.tsbCancel.Visible = false;
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tssLogs
            // 
            this.tssLogs.Name = "tssLogs";
            this.tssLogs.Size = new System.Drawing.Size(6, 42);
            // 
            // tsbClearLogs
            // 
            this.tsbClearLogs.Image = global::MscrmTools.EmailAnonymizer.Properties.Resources.Clear_16;
            this.tsbClearLogs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearLogs.Name = "tsbClearLogs";
            this.tsbClearLogs.Size = new System.Drawing.Size(145, 36);
            this.tsbClearLogs.Text = "Clear Logs";
            this.tsbClearLogs.Click += new System.EventHandler(this.tsbClearLogs_Click);
            // 
            // gbEntities
            // 
            this.gbEntities.Controls.Add(this.lvEntities);
            this.gbEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEntities.Location = new System.Drawing.Point(3, 3);
            this.gbEntities.Name = "gbEntities";
            this.gbEntities.Size = new System.Drawing.Size(471, 637);
            this.gbEntities.TabIndex = 0;
            this.gbEntities.TabStop = false;
            this.gbEntities.Text = "Entities (only email enabled)";
            // 
            // lvEntities
            // 
            this.lvEntities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDisplayName,
            this.chLogicalName});
            this.lvEntities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEntities.FullRowSelect = true;
            this.lvEntities.HideSelection = false;
            this.lvEntities.Location = new System.Drawing.Point(3, 27);
            this.lvEntities.MultiSelect = false;
            this.lvEntities.Name = "lvEntities";
            this.lvEntities.Size = new System.Drawing.Size(465, 607);
            this.lvEntities.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvEntities.TabIndex = 0;
            this.lvEntities.UseCompatibleStateImageBehavior = false;
            this.lvEntities.View = System.Windows.Forms.View.Details;
            this.lvEntities.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.lvEntities.SelectedIndexChanged += new System.EventHandler(this.lvEntities_SelectedIndexChanged);
            // 
            // chDisplayName
            // 
            this.chDisplayName.Text = "Display name";
            this.chDisplayName.Width = 150;
            // 
            // chLogicalName
            // 
            this.chLogicalName.Text = "Logical name";
            this.chLogicalName.Width = 150;
            // 
            // gbAttributes
            // 
            this.gbAttributes.Controls.Add(this.lvAttributes);
            this.gbAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAttributes.Location = new System.Drawing.Point(480, 3);
            this.gbAttributes.Name = "gbAttributes";
            this.gbAttributes.Size = new System.Drawing.Size(485, 637);
            this.gbAttributes.TabIndex = 0;
            this.gbAttributes.TabStop = false;
            this.gbAttributes.Text = "Email attributes (double click to add)";
            // 
            // lvAttributes
            // 
            this.lvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAttributes.FullRowSelect = true;
            this.lvAttributes.HideSelection = false;
            this.lvAttributes.Location = new System.Drawing.Point(3, 27);
            this.lvAttributes.Name = "lvAttributes";
            this.lvAttributes.Size = new System.Drawing.Size(479, 607);
            this.lvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAttributes.TabIndex = 1;
            this.lvAttributes.UseCompatibleStateImageBehavior = false;
            this.lvAttributes.View = System.Windows.Forms.View.Details;
            this.lvAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.lvAttributes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAttributes_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Display name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Logical name";
            this.columnHeader2.Width = 150;
            // 
            // gbSelectedAttributes
            // 
            this.gbSelectedAttributes.Controls.Add(this.gbSettings);
            this.gbSelectedAttributes.Controls.Add(this.lvSummary);
            this.gbSelectedAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelectedAttributes.Location = new System.Drawing.Point(971, 3);
            this.gbSelectedAttributes.Name = "gbSelectedAttributes";
            this.gbSelectedAttributes.Size = new System.Drawing.Size(473, 637);
            this.gbSelectedAttributes.TabIndex = 1;
            this.gbSelectedAttributes.TabStop = false;
            this.gbSelectedAttributes.Text = "Attributes to anonymize (double click to remove)";
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.pnlFilter);
            this.gbSettings.Controls.Add(this.pnlFormat);
            this.gbSettings.Controls.Add(this.pnlBulkSettings);
            this.gbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSettings.Location = new System.Drawing.Point(3, 370);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(467, 264);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.lblFormatTip);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilter.Location = new System.Drawing.Point(3, 121);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(461, 140);
            this.pnlFilter.TabIndex = 2;
            // 
            // lblFormatTip
            // 
            this.lblFormatTip.BackColor = System.Drawing.SystemColors.Info;
            this.lblFormatTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFormatTip.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormatTip.Location = new System.Drawing.Point(0, 0);
            this.lblFormatTip.Name = "lblFormatTip";
            this.lblFormatTip.Size = new System.Drawing.Size(461, 59);
            this.lblFormatTip.TabIndex = 0;
            this.lblFormatTip.Text = "Format : {0} is replace with a ten digits string.";
            // 
            // pnlFormat
            // 
            this.pnlFormat.Controls.Add(this.txtFormat);
            this.pnlFormat.Controls.Add(this.lblFormat);
            this.pnlFormat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormat.Location = new System.Drawing.Point(3, 75);
            this.pnlFormat.Name = "pnlFormat";
            this.pnlFormat.Size = new System.Drawing.Size(461, 46);
            this.pnlFormat.TabIndex = 1;
            // 
            // txtFormat
            // 
            this.txtFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFormat.Location = new System.Drawing.Point(160, 0);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(301, 31);
            this.txtFormat.TabIndex = 1;
            this.txtFormat.Text = "email_{0}@test.fr";
            // 
            // lblFormat
            // 
            this.lblFormat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFormat.Location = new System.Drawing.Point(0, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(160, 46);
            this.lblFormat.TabIndex = 0;
            this.lblFormat.Text = "Format";
            // 
            // pnlBulkSettings
            // 
            this.pnlBulkSettings.Controls.Add(this.nudItemsPerRequest);
            this.pnlBulkSettings.Controls.Add(this.lblBulkSettings);
            this.pnlBulkSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBulkSettings.Location = new System.Drawing.Point(3, 27);
            this.pnlBulkSettings.Name = "pnlBulkSettings";
            this.pnlBulkSettings.Size = new System.Drawing.Size(461, 48);
            this.pnlBulkSettings.TabIndex = 0;
            // 
            // nudItemsPerRequest
            // 
            this.nudItemsPerRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudItemsPerRequest.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudItemsPerRequest.Location = new System.Drawing.Point(310, 0);
            this.nudItemsPerRequest.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudItemsPerRequest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemsPerRequest.Name = "nudItemsPerRequest";
            this.nudItemsPerRequest.Size = new System.Drawing.Size(151, 31);
            this.nudItemsPerRequest.TabIndex = 1;
            this.nudItemsPerRequest.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblBulkSettings
            // 
            this.lblBulkSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBulkSettings.Location = new System.Drawing.Point(0, 0);
            this.lblBulkSettings.Name = "lblBulkSettings";
            this.lblBulkSettings.Size = new System.Drawing.Size(310, 48);
            this.lblBulkSettings.TabIndex = 0;
            this.lblBulkSettings.Text = "Items to process per request";
            // 
            // lvSummary
            // 
            this.lvSummary.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEntity,
            this.chAttributeDisplayName,
            this.chAttributeLogicalName});
            this.lvSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvSummary.HideSelection = false;
            this.lvSummary.HoverSelection = true;
            this.lvSummary.Location = new System.Drawing.Point(3, 27);
            this.lvSummary.Name = "lvSummary";
            this.lvSummary.Size = new System.Drawing.Size(467, 343);
            this.lvSummary.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSummary.TabIndex = 2;
            this.lvSummary.UseCompatibleStateImageBehavior = false;
            this.lvSummary.View = System.Windows.Forms.View.Details;
            this.lvSummary.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.lvSummary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSummary_MouseDoubleClick);
            // 
            // chEntity
            // 
            this.chEntity.Text = "Entity";
            this.chEntity.Width = 150;
            // 
            // chAttributeDisplayName
            // 
            this.chAttributeDisplayName.Text = "Display name";
            this.chAttributeDisplayName.Width = 150;
            // 
            // chAttributeLogicalName
            // 
            this.chAttributeLogicalName.Text = "Logical name";
            this.chAttributeLogicalName.Width = 150;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.gbSelectedAttributes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbAttributes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbEntities, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1447, 643);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 42);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.scMain.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.lvLogs);
            this.scMain.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.scMain.Size = new System.Drawing.Size(1467, 908);
            this.scMain.SplitterDistance = 663;
            this.scMain.TabIndex = 8;
            // 
            // lvLogs
            // 
            this.lvLogs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLogEntity,
            this.chLogRecordName,
            this.chLogId,
            this.chLogMessage});
            this.lvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLogs.HideSelection = false;
            this.lvLogs.Location = new System.Drawing.Point(10, 10);
            this.lvLogs.Name = "lvLogs";
            this.lvLogs.Size = new System.Drawing.Size(1447, 221);
            this.lvLogs.TabIndex = 0;
            this.lvLogs.UseCompatibleStateImageBehavior = false;
            this.lvLogs.View = System.Windows.Forms.View.Details;
            // 
            // chLogEntity
            // 
            this.chLogEntity.Text = "Entity";
            this.chLogEntity.Width = 100;
            // 
            // chLogId
            // 
            this.chLogId.Text = "Record Id";
            this.chLogId.Width = 250;
            // 
            // chLogMessage
            // 
            this.chLogMessage.Text = "Message";
            this.chLogMessage.Width = 400;
            // 
            // chLogRecordName
            // 
            this.chLogRecordName.Text = "Record Name";
            this.chLogRecordName.Width = 200;
            // 
            // EmailAnonymizerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EmailAnonymizerControl";
            this.Size = new System.Drawing.Size(1467, 950);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gbEntities.ResumeLayout(false);
            this.gbAttributes.ResumeLayout(false);
            this.gbSelectedAttributes.ResumeLayout(false);
            this.gbSettings.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFormat.ResumeLayout(false);
            this.pnlFormat.PerformLayout();
            this.pnlBulkSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudItemsPerRequest)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbLoadEntities;
        private System.Windows.Forms.ToolStripSeparator tssBeforeAnonymize;
        private System.Windows.Forms.ToolStripButton tsbAnonymize;
        private System.Windows.Forms.GroupBox gbEntities;
        private System.Windows.Forms.ListView lvEntities;
        private System.Windows.Forms.ColumnHeader chDisplayName;
        private System.Windows.Forms.ColumnHeader chLogicalName;
        private System.Windows.Forms.GroupBox gbAttributes;
        private System.Windows.Forms.ListView lvAttributes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbSelectedAttributes;
        private System.Windows.Forms.ListView lvSummary;
        private System.Windows.Forms.ColumnHeader chEntity;
        private System.Windows.Forms.ColumnHeader chAttributeDisplayName;
        private System.Windows.Forms.ColumnHeader chAttributeLogicalName;
        private System.Windows.Forms.Panel pnlBulkSettings;
        private System.Windows.Forms.NumericUpDown nudItemsPerRequest;
        private System.Windows.Forms.Label lblBulkSettings;
        private System.Windows.Forms.Panel pnlFormat;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ListView lvLogs;
        private System.Windows.Forms.ColumnHeader chLogEntity;
        private System.Windows.Forms.ColumnHeader chLogId;
        private System.Windows.Forms.ColumnHeader chLogMessage;
        private System.Windows.Forms.ToolStripSeparator tssCancel;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator tssLogs;
        private System.Windows.Forms.ToolStripButton tsbClearLogs;
        private System.Windows.Forms.Label lblFormatTip;
        private System.Windows.Forms.ColumnHeader chLogRecordName;
    }
}
