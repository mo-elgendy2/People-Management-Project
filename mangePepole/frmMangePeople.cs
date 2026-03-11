using BusinessLayer;
using People_Management__full_pro__1set.mangePepole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace People_Management__full_pro__1set
{
    public partial class MangePeople : Form
    {
        private int _conID;  // لحفظ الـ ID الممرر
        FrmDetales frmAdd;

        DataTable dtPeople=clsContact.GetallContacet();


        // Constructor للمصمم فقط (ليس للاستخدام العادي)
        //public MangePeople() : this(-1)
        //{
        //}

        private void ApplyStyle(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.AutoRoundedCorners = true;
            btn.BorderRadius = 12;

            btn.FillColor = Color.FromArgb(230, 240, 255);
            btn.ForeColor = Color.FromArgb(40, 40, 40);

            btn.BorderThickness = 1;
            btn.BorderColor = Color.FromArgb(180, 200, 255);

            btn.HoverState.FillColor = Color.FromArgb(210, 225, 255);
            btn.HoverState.ForeColor = Color.Black;

            btn.ShadowDecoration.Enabled = true;
            btn.ShadowDecoration.BorderRadius = 30;
            btn.ShadowDecoration.Depth = 10;
            btn.ShadowDecoration.Shadow = new Padding(0, 0 ,6, 6);
        }

        public MangePeople()
        {
            InitializeComponent();
        }
        public MangePeople( int conID)
        {
            InitializeComponent();

            _conID = conID;
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هفتح الفورم دلوقتي");

            frmAdd = new FrmDetales(-1);
            frmAdd.ShowDialog();
            _refresh();

        }

     






        //private int _ConID;

        //// ... الباقي كما هو ...

        ///// <summary>
        ///// دالة لتحميل بيانات الشخص داخل الكنترول
        ///// </summary>
        //public void LoadPerson(int conID)
        //{
        //    _ConID = conID;
        //    _refresh();  // هذه الدالة تملأ الـ DataGridView
        //}

       
        void _refresh()
        {
            dtPeople = clsContact.GetallContacet();
            dataGridViewPeople.DataSource = dtPeople;

            //DataTable dt = new DataTable();

            //// تعبئة dt بالبيانات (مثلاً من قاعدة بيانات أو يدويًا)
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Age");

            //dt.Rows.Add("Ahmed", 30);
            //dt.Rows.Add("Mona", 25);

            //// الآن ربط البيانات بالـ DataGridView
            //dataGridViewPeople.DataSource = dt;



        }



        //void fliter()
        //{
        //    if (comboFilter.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxFiltter.Text))
        //    {
        //        dataGridViewPeople.DataSource = clsContact.GetallContacet();
        //        return;
        //    }

        //    DataView DV = clsContact.GetallContacet().DefaultView;

        //    string selectedValue = comboFilter.SelectedItem.ToString();
        //    string searchText = textBoxFiltter.Text.Trim();

        //    switch (selectedValue)
        //    {
        //        case "PersonID":
        //        case "NationalityCountryID":
        //            if (int.TryParse(searchText, out int number))
        //            {
        //                DV.RowFilter = $"[{selectedValue}] = {number}";
        //            }
        //            else
        //            {
        //                DV.RowFilter = "1 = 0"; // خطأ في الرقم
        //            }
        //            break;

        //        case "DateOfBirth":
        //            if (DateTime.TryParse(searchText, out DateTime dateVal))
        //            {
        //                DV.RowFilter = $"[{selectedValue}] = #{dateVal:MM/dd/yyyy}#";
        //            }
        //            else
        //            {
        //                DV.RowFilter = "1 = 0"; // خطأ في التاريخ
        //            }
        //            break;

        //        default:
        //            // فلترة نصية
        //            DV.RowFilter = $"[{selectedValue}] LIKE '%{searchText.Replace("'", "''")}%'";
        //            break;
        //    }

        //    dataGridViewPeople.DataSource = DV;
        //}


        private void dataGridViewPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.BackColor = Color.WhiteSmoke;
            // اخفاء الأعمدة اللي مش عايزها
          

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.FindForm().Close();
        }

      

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selctedID = Convert.ToInt32(dataGridViewPeople.CurrentRow.Cells[0].Value);
            frmAddPeople3 frm = new frmAddPeople3(selctedID);
            frm.ShowDialog();
            _refresh();

        }
        //private void ApplyFilter()
        //{
        //    if (dataGridViewPeople.DataSource == null) return;

        //    string column = comboFilter.SelectedItem.ToString();
        //    string value = textBoxFiltter.Text.Trim().Replace("'", "''");

        //    if (string.IsNullOrEmpty(value))
        //    {
        //        (dataGridViewPeople.DataSource as DataTable).DefaultView.RowFilter = "";
        //    }
        //    else
        //    {
        //        (dataGridViewPeople.DataSource as DataTable).DefaultView.RowFilter =
        //            $"[{column}] LIKE '%{value}%'";
        //    }
        //}



        void btstaly()
        {
            ApplyStyle(guna2Button1);
            ApplyStyle(guna2Button2);
            ApplyStyle(guna2Button3);




        }
        private void MangePeople_Load(object sender, EventArgs e)
        {
            btstaly();
            filterItim.DropDownStyle = ComboBoxStyle.DropDownList;
            _refresh();
            //fliter();

            fil();
            //ApplyFilter();

            dataGridViewPeople.AllowUserToAddRows = false;
            dataGridViewPeople.Columns["Gendor"].Visible = false;
            dataGridViewPeople.Columns["NationalityCountryID"].Visible = false;

            // ترتيب الأعمدة صح
            dataGridViewPeople.Columns["GendorCaption"].DisplayIndex = 6; // después de DateOfBirth
            dataGridViewPeople.Columns["CountryName"].DisplayIndex = 10;  // después de Nationality
            dataGridViewPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            
        
            MessageBox.Show(" Open Form Now !");

            frmAddPeople3 f = new frmAddPeople3(-1);
            f.ShowDialog();
            _refresh();

        
    }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;
            MessageBox.Show("Selected ID = " + selectedID);
            frmAdd = new FrmDetales(selectedID);
            frmAdd.ShowDialog();

            

            _refresh();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هفتح الفورم دلوقتي");

            frmAdd = new FrmDetales(-1);
            frmAdd.ShowDialog();
            _refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int selectedID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;
            // frmAdd = new FrmDetales(selectedID);
            //frmAdd.ShowDialog();
            //_refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PersonID = (int)dataGridViewPeople.CurrentRow.Cells["PersonID"].Value;
            MessageBox.Show("Selected ID = " + PersonID);

            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                clsContact.Delete(PersonID);
            }
            _refresh();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show(" Open Form  up date Now !");
            int selectedID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;
            frmAdd = new FrmDetales(selectedID);
            frmAdd.ShowDialog();
            _refresh();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnAdd_Click_1(sender, e);
        }

        private void upDateToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            button1_Click(sender, e); 
                
         }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewPeople.SelectedRows.Count > 0)
            {
                int contactID = Convert.ToInt32(dataGridViewPeople.SelectedRows[0].Cells[0].Value);
                MessageBox.Show(" do you want delete this ?"," confirm",MessageBoxButtons.OKCancel) ;   
                clsContact.Delete(contactID);

                dataGridViewPeople.Rows.RemoveAt(dataGridViewPeople.SelectedRows[0].Index);

                MessageBox.Show("تم حذف الشخص بنجاح");
            }
            else
            {
                MessageBox.Show("يرجى تحديد صف للحذف.");
            }

            
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;

            FrmPerDetails frm6 = new FrmPerDetails(selectedID);

            //UserControl2 us = new UserControl2(selectedID);
            //frm6.Controls.Add(us);
            frm6.ShowDialog();
        
        }


        void fil()
        {
                 filterItim.Items.Add("PersonID");
                 filterItim.Items.Add("NationalNo");
                 filterItim.Items.Add("FirstName");
                 //filterItim.Items.Add("SecondName");
                 //filterItim.Items.Add("ThirdName");
                 filterItim.Items.Add("LastName");
                 //filterItim.Items.Add("DateOfBirth");
                 //filterItim.Items.Add("Gendor");
                 //filterItim.Items.Add("Addres");
                 //filterItim.Items.Add("Phone ");




        }
        private string GetColumnName(string columnName)
        {
            switch (columnName)
            {
                case "PersonID": return "PersonID";
                case "NationalNo": return "NationalNo";
                case "FirstName": return "FirstName";
                //case "SecondName": return "SecondName";
                case "ThirdName": return "ThirdName";
                case "LastName": return "LastName";
                //case "DateOfBirth": return "DateOfBirth";
                //case "Gendor": return "Gendor";
                //case "Address": return "Address";
                case "Phone": return "Phone";
                default: return "";
            }
        }

        //void afterfltering()
        //{
        //    string ff = " ";

        //    switch (GetColumnName(ff))
        //    {


        //    }
        //    if (GetColumnName(ff) == 

        //}

        //void ApplyFilter()
        //       {
        //           if (filterItim.SelectedItem == null) return;

        //           string columnName = GetColumnName(filterItim.SelectedItem.ToString());
        //           if (string.IsNullOrEmpty(columnName)) return;

        //           string filterText = textFilter.Text.Trim();

        //           if (string.IsNullOrEmpty(filterText))
        //           {
        //               dtPeople.DefaultView.RowFilter = "";
        //           }
        //           else
        //           {
        //               // للأعمدة الرقمية أو
        //               if (columnName == "phone" || columnName == "PersonID" || columnName == "NationalNo")
        //               {
        //                   if (columnName == "NationalNo")
        //                   {
        //                       dtPeople.DefaultView.RowFilter = $"[{columnName}] = {filterText}";
        //                   }
        //                   else if (columnName == "phone")
        //                   {
        //                       dtPeople.DefaultView.RowFilter = $"[{columnName}] = {filterText}";
        //                   }
        //               }
        //               else
        //               {
        //                   dtPeople.DefaultView.RowFilter = $"[{columnName}]= {filterText}";
        //               }
        //           }
        //       //}


        void ApplyFilter()
        {
            if (filterItim.SelectedItem == null)
                return;

            string columnName = GetColumnName(filterItim.SelectedItem.ToString());
            if (string.IsNullOrEmpty(columnName))
                return;

            string filterText = textFilter.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
            {
                dtPeople.DefaultView.RowFilter = "";
                return;
            }

            // نحدد نوع العمود
            Type columnType = dtPeople.Columns[columnName].DataType;

            if (columnType == typeof(string))
            {
                // النصوص
                dtPeople.DefaultView.RowFilter = $"[{columnName}] LIKE '%{filterText}%'";
            }
            else if (columnType == typeof(int) || columnType == typeof(double))
            {
                // الأرقام
                if (double.TryParse(filterText, out double number))
                    dtPeople.DefaultView.RowFilter = $"[{columnName}] = {number}";
                else
                    dtPeople.DefaultView.RowFilter = "1=0"; // لا يعرض شيء لو مش رقم
            }
            //else if (columnType == typeof(bool))
            //{
            //    // المنطقي (Yes / No)
            //    bool value = filterText.ToLower() == "yes" || filterText == "1";
            //    dtPeople.DefaultView.RowFilter = $"[{columnName}] = {value}";
            //}
            else
            {

                // أي نوع تاني نعامله كنص 
                filterText = filterText.Replace("'", "''");

                dtPeople.DefaultView.RowFilter = $"[{columnName}] LIKE '%{filterText}%'";

            }
        }

        private void filterItim_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();

        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ApplyStyle(guna2Button2);
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Open Form add Now !");

            frmAdd = new FrmDetales(-1);
            frmAdd.ShowDialog();
            _refresh();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Open Form  up date Now !");
            int selectedID = (int)dataGridViewPeople.CurrentRow.Cells[0].Value;
            frmAdd = new FrmDetales(selectedID);
            frmAdd.ShowDialog();
            _refresh();
        }
    }
}
