using bescnesLayer.BusinessLayer;
using BusinessLayer;
using Guna.UI2.WinForms;
using People_Management__full_pro__1set.mange_user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace People_Management__full_pro__1set
{
    public partial class manage_User : Form
    {
        DataTable _dtUsers;

        DataTable dtUsers = clsUser.getUser();
       

        public manage_User()
        {
            InitializeComponent();
            guna2ControlBox1.FillColor.ToArgb();

            guna2ControlBox1.HoverState.FillColor = Color.FromArgb(231, 76, 60);
            guna2ControlBox1.ShadowDecoration.Enabled = false;

        }

        private string GetColumnName(string displayName)
        {
            switch (displayName)
            {
                case "User ID": return "UserID";
                case "UserName": return "UserName";
                case "Person ID": return "PersonID";
                case "Full Name": return "FullName";
                case "Is Active": return "IsActive";
                default: return "";
            }
        }
        void Refrech() 
        {
            dtUsers = clsUser.getUser();
            dataGridView1.DataSource = dtUsers.DefaultView;
            //CheckColumnType();

            dataGridView1.AutoResizeRows();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void manage_User_Load(object sender, EventArgs e)
        {

            //MessageBox.Show(dtUsers.Columns["IsActive"].DataType.ToString());

            //dataGridView1.DataSource = dtUsers.DefaultView;
            ////CheckColumnType();

            //dataGridView1.AutoResizeRows();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //CheckIsActiveType();
            add();
            Refrech();
            CheckIsActiveType();




        }

        private void add()
        {
            // إعداد ComboBox الفلترة
            filterItim.Items.Add("None");
            filterItim.Items.Add("User ID");
            filterItim.Items.Add("UserName");
            filterItim.Items.Add("Person ID");
            filterItim.Items.Add("Full Name");
            filterItim.Items.Add("Is Active");

            // إعداد ComboBox للحالة النشطة
            activepox.Items.Add("All");
            activepox.Items.Add("Yes");
            activepox.Items.Add("No");
            activepox.SelectedIndex = 0;

            // الإعدادات الابتدائية
            activepox.Visible = false;
            textFilter.Visible = true;
            filterItim.SelectedIndex = 0;
            filterItim.Focus();
            //activepox.SelectedIndex = 0;
            label3.Text = dtUsers.Rows.Count.ToString();
        } 
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // يمكن إضافة أي كود عند الضغط على خلية هنا
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (filterItim.SelectedItem == null) 
            //    return;

            string selected = filterItim.SelectedItem.ToString();

            if (selected == "Is Active")
            {
                textFilter.Visible = false;
                activepox.Visible = true;
                if (activepox.SelectedIndex < 0)
                    activepox.SelectedIndex = 0;

            }
            else if (selected == "None")
            {
                textFilter.Visible = false;
                activepox.Visible = false;
                dtUsers.DefaultView.RowFilter = "";
            }
            else
            {
                textFilter.Visible = true;
                activepox.Visible = false;
            }

            ApplyFilter();
        }
        private void ApplyFilter()
        {

            if (filterItim.SelectedItem == null)
                return;

            string selectedFilter = filterItim.SelectedItem.ToString();

            // لو None - امسح الفلتر
            if (selectedFilter == "None")
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }

            // Map display name to actual DataTable column name
            string columnName = GetColumnName(selectedFilter);

            if (string.IsNullOrEmpty(columnName))
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }
            MessageBox.Show($"Selected Filter: {selectedFilter}\nColumn Name: {columnName}");


            // ⭐ حالة IsActive - استخدم activepox
            if (columnName == "IsActive")
            {
                if (activepox.SelectedIndex < 0)
                    return;

                string activeValue = activepox.SelectedItem.ToString();

                if (activeValue == "All")
                {
                    dtUsers.DefaultView.RowFilter = "";
                }
                else if (activeValue == "Yes")
                {
                    dtUsers.DefaultView.RowFilter = "IsActive = True";
                }
                else if (activeValue == "No")
                {
                    dtUsers.DefaultView.RowFilter = "IsActive = False";
                }
                return; // ⚠️ مهم جداً - اخرج من الدالة هنا
            }

            // باقي الأعمدة - استخدم textFilter
            string filterText = textFilter.Text.Trim();

            if (string.IsNullOrEmpty(filterText))
            {
                dtUsers.DefaultView.RowFilter = "";
                return;
            }

            // فلترة الأعمدة الرقمية (UserID, PersonID)
            if (columnName == "UserID" || columnName == "PersonID")
            {
                if (int.TryParse(filterText, out int numValue))
                {
                    dtUsers.DefaultView.RowFilter = $"[{columnName}] = {numValue}";
                }
                else
                {
                    // لو مش رقم صحيح - امسح الفلتر
                    dtUsers.DefaultView.RowFilter = "";
                }
            }
            // فلترة الأعمدة النصية (UserName, FullName)
            else
            {
                // حماية من الأخطاء - استبدل ' بـ ''
                string safeText = filterText.Replace("'", "''");
                dtUsers.DefaultView.RowFilter = $"[{columnName}] LIKE '%{safeText}%'";
            }
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void activepox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Selected: {activepox.SelectedItem?.ToString() ?? "NULL"}");
            ApplyFilter();
        }

        private void textFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (filterItim.SelectedItem == null)
                
                return;

            string selectedColumn = filterItim.SelectedItem.ToString();

            // الأعمدة الرقمية
            if (selectedColumn == "User ID" || selectedColumn == "Person ID")
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            // الأعمدة النصية
            else if (selectedColumn == "Full Name" || selectedColumn == "UserName")
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
                {
                    e.Handled = true;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textFilter_KeyPress_1(object sender, KeyPressEventArgs e) { 
            if (filterItim.SelectedItem == null) return;

            string selectedColumn = filterItim.SelectedItem.ToString();

            // الأعمدة اللي فيها أرقام
            if (selectedColumn == "User ID" || selectedColumn == "Person ID")
            {
                // يسمح بس بالأرقام وBackspace
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // يمنع الكتابة
                }
            }
            else if (selectedColumn == "Full Name" || selectedColumn == "UserName")
            {
                // يسمح بالحروف فقط وBackspace والمسافة
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
                {
                    e.Handled = true; // يمنع الكتابة
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            FrmUserAd frm = new FrmUserAd();
            frm.ShowDialog();
            Refrech();
        }

        //private void CheckColumnType()
        //{
        //    string msg = "";
        //    foreach (DataColumn col in dtUsers.Columns)
        //    {
        //        msg += $"{col.ColumnName} - {col.DataType.Name}\n";
        //    }

        //    // عرض أول 5 قيم للـ IsActive
        //    for (int i = 0; i < Math.Min(5, dtUsers.Rows.Count); i++)
        //    {
        //        msg += $"Row {i} - IsActive: {dtUsers.Rows[i]["IsActive"]}\n";
        //    }

        //    MessageBox.Show(msg, "Column Types & Sample Data");
        //}
        private void CheckIsActiveType()
        {
            string msg = "";

            DataColumn col = dtUsers.Columns["IsActive"];
            msg += $"Column Type: {col.DataType.Name}\n\n";

            for (int i = 0; i < Math.Min(3, dtUsers.Rows.Count); i++)
            {
                var value = dtUsers.Rows[i]["IsActive"];
                msg += $"Row {i}: '{value}' (Type: {value.GetType().Name})\n";
            }

            MessageBox.Show(msg, "IsActive Column Info");
        }

        private void activepox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilter();

        }

        private void BTNnext_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            FRMAddNEWUsers frm = new FRMAddNEWUsers();
            frm.ShowDialog();
            Refrech();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            //FRMAddNEWUsers frn= new FRMAddNEWUsers();
            //frn.ShowDialog();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            

        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            FrmUser_Info_Form frm = new FrmUser_Info_Form(selectedID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRMAddNEWUsers frn = new FRMAddNEWUsers();
            frn.ShowDialog();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            DialogResult result = MessageBox.Show("Usser is delete ", "are yor delete ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (clsUser.DeleteUser(selectedID))
                {
                    MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //manage_User_Load(null, null);
                }

                else
                    MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            FrmChangePassword frm = new FrmChangePassword(selectedID);
            //manage_User_Load(null, null);

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            //int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["UserID"].Value);

            FRMAddNEWUsers frn = new FRMAddNEWUsers(selectedID);
            frn.ShowDialog();
        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
