using System;
using System.Collections;
using System.Windows.Forms;

namespace WinFormsListView
{
    public class CompareListViewItems : IComparer
    {
        #region Fields

        private readonly int column;
        private readonly bool alphabetic;

        #endregion

        #region Constructors

        public CompareListViewItems(int columnIndex, bool alphabetic)
        {
            this.column = columnIndex;
            this.alphabetic = alphabetic;
        }

        #endregion

        #region Methods

        public int Compare(object x, object y)
        {
            string listX = ((ListViewItem)x)?.SubItems[this.column].Text;
            string listY = ((ListViewItem)y)?.SubItems[this.column].Text;

            // Sort using the specified column and specified sorting type.
            if (this.alphabetic)
            {
                return string.Compare(listX, listY, StringComparison.InvariantCulture);

            }

            if (listY != null && listX != null && int.Parse(listX) > int.Parse(listY))
            {
                return 1;
            }

            if (listY != null && listX != null && int.Parse(listX) == int.Parse(listY))
            {
                return 0;
            }

            return -1;
        }

        #endregion
    }
}
