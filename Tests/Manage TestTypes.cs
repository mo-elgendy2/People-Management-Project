using bescnesLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.applictions
{
    public partial class Manage_TestTypes : Form
    {

        DataTable dt;
        public Manage_TestTypes()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Manage_TestTypes_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            this.WindowState = FormWindowState.Normal;

            dt = ClsManageTestApp.GEtAllData();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.TopMost = false;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; ;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].HeaderText = "Descrption";
            dataGridView1.Columns[2].Width = 520;
            dataGridView1.Columns[3].HeaderText = "Fees";
            dataGridView1.Columns[3].Width = 140;

           
            label3.Text=dataGridView1.RowCount.ToString();
            Refrshe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selctedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //MessageBox.Show("Selected ID = " + selctedID);
            string title = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show("tite = " + title);
            string Descrption = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //MessageBox.Show("Descrption = " + Descrption);
            double Fees = Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value);
            MessageBox.Show("tite = " + Fees);
            //FrmUpdataTestType frm= new FrmUpdataTestType(selctedID,title,Descrption,Fees);
            FrmUpdataTestType frm= new FrmUpdataTestType((ClsManageTestApp.enTestType)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            Refrshe();


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        void Refrshe()
        {


            dt = ClsManageTestApp.GEtAllData();
            dataGridView1.DataSource = dt.DefaultView;
            
            //CheckColumnType();

            dataGridView1.AutoResizeRows();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
