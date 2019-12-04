using System.Collections;
using System.Windows.Forms;

namespace MscrmTools.EmailAnonymizer.AppCode
{
    /// <summary>
    /// Compares two listview items for sorting
    /// </summary>
    internal class ListViewItemComparer : IComparer
    {
        #region Variables

        /// <summary>
        /// Index of sorting column
        /// </summary>
        private readonly int _col;

        /// <summary>
        /// Sort order
        /// </summary>
        private readonly SortOrder _innerOrder;

        #endregion Variables

        #region Constructors

        /// <summary>
        /// Initializes a new instance of class ListViewItemComparer
        /// </summary>
        public ListViewItemComparer()
        {
            _col = 0;
            _innerOrder = SortOrder.Ascending;
        }

        /// <summary>
        /// Initializes a new instance of class ListViewItemComparer
        /// </summary>
        /// <param name="column">Index of sorting column</param>
        /// <param name="order">Sort order</param>
        public ListViewItemComparer(int column, SortOrder order)
        {
            _col = column;
            _innerOrder = order;
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Compare tow objects
        /// </summary>
        /// <param name="x">object 1</param>
        /// <param name="y">object 2</param>
        /// <returns></returns>
        public int Compare(object x, object y)
        {
            return Compare((ListViewItem)x, (ListViewItem)y);
        }

        /// <summary>
        /// Compare tow listview items
        /// </summary>
        /// <param name="x">Listview item 1</param>
        /// <param name="y">Listview item 2</param>
        /// <returns></returns>
        public int Compare(ListViewItem x, ListViewItem y)
        {
            if (_innerOrder == SortOrder.Ascending)
            {
                return string.CompareOrdinal(x.SubItems[_col].Text, y.SubItems[_col].Text);
            }
            return string.CompareOrdinal(y.SubItems[_col].Text, x.SubItems[_col].Text);
        }

        #endregion Methods
    }
}