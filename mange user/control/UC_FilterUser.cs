using People_Management__full_pro__1set.mange_user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.mange_user
{
    public partial class UC_FilterUser : UserControl
    {

        public DataTable SourceTable { get; set; }
        public List<string> FilterColumns { get; set; }

        public event Action<int> onPersonSelected;
        public event Action< string> OnSearchRequested;

        public UC_FilterUser()
        {
            InitializeComponent();
        }


        private void UC_Filter_Load(object sender, EventArgs e)
        {
            cbColumns.Items.Add("PersonID");
            cbColumns.Items.Add("NationalNo");
            //cbColumns.Items.Add("FirstName");


            //cbColumns.Items.Add("LastName");
            if (FilterColumns != null)
            {
                cbColumns.DataSource = FilterColumns;
            }



        }
        private void ApplyFilter()
{
            if (SourceTable == null)
                return;
            if (cbColumns.SelectedItem == null)
                return;

    string columnName = cbColumns.SelectedItem.ToString();
    string filterText = txtSearch.Text.Trim();

            // إطلاق الحدث لكل بحث
            OnSearchRequested?.Invoke( filterText);

            if (string.IsNullOrEmpty(filterText))
            {
                SourceTable.DefaultView.RowFilter = "";
            }
            else
            {
                SourceTable.DefaultView.RowFilter = $"Convert([{columnName}], 'System.String') LIKE '%{filterText}%'";
            }

            if (SourceTable.DefaultView.Count > 0)

            {
                int PersonID = Convert.ToInt32(SourceTable.DefaultView[0]["PersonID"]);
                onPersonSelected?.Invoke(PersonID);


            }

        }

        public void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //ApplyFilter();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbColumns.SelectedIndex = 1;
        }
    }

}
