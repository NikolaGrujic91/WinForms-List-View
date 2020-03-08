using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsListView
{
    public partial class Form1 : Form
    {
        #region Contructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioButtonLargeIcon.Tag = View.LargeIcon;
            this.radioButtonSmallIcon.Tag = View.SmallIcon;
            this.radioButtonDetails.Tag = View.Details;
            this.radioButtonList.Tag = View.List;
            this.FillList();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.listAuthors.View = (View)(((Control)sender).Tag);
            this.Text = "WinFormsListView Using View: " + listAuthors.View;
        }

        private void listAuthors_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            this.listAuthors.ListViewItemSorter = new CompareListViewItems(e.Column, true);
            this.listAuthors.Sort();
        }

        #endregion

        #region Methods

        private void FillList()
        {
            DataTable dt = StoreDB.GetProducts();

            // Suspending automatic refreshes as items are added/removed.
            this.listAuthors.BeginUpdate();

            this.listAuthors.SmallImageList = this.imagesSmall;
            this.listAuthors.LargeImageList = this.imagesLarge;

            foreach (DataRow dr in dt.Rows)
            {
                var listItem = new ListViewItem(dr["ModelName"].ToString()) { ImageIndex = 0 };

                // Add sub-items for Details view.
                listItem.SubItems.Add(dr["ProductID"].ToString());
                listItem.SubItems.Add(dr["Description"].ToString());

                this.listAuthors.Items.Add(listItem);
            }

            // Add column headers for Details view.
            this.listAuthors.Columns.Add("Product", 100, HorizontalAlignment.Left);
            this.listAuthors.Columns.Add("ID", 100, HorizontalAlignment.Left);
            this.listAuthors.Columns.Add("Description", 100, HorizontalAlignment.Left);

            // Re-enable the display.
            this.listAuthors.EndUpdate();
        }

        #endregion
    }
}
