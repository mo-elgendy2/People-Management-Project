using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace People_Management__full_pro__1set.applictions
{
    public partial class FrmMangeApplication_Types : Form
    {
        DataTable dt = ClsAppTypes.GetAllApplicationTypes();
        private int _conID;
        public FrmMangeApplication_Types()
        {
            InitializeComponent();
        }
        //public FrmMangeApplication_Types( int con)
        //{
        //    InitializeComponent();
        //    _conID = con;
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void FrmMangeApplication_Types_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            this.WindowState = FormWindowState.Normal;

            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            label3.Text=dt.Rows.Count.ToString();
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
            double Fees = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value);
            //MessageBox.Show("tite = " + Fees);


            UpDataApplication_Type frm = new UpDataApplication_Type(selctedID, title, Fees);
            frm.Focus();
            frm.ShowDialog();
            Refrshe();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void Refrshe() 
        {


            dt = ClsAppTypes.GetAllApplicationTypes();
            dataGridView1.DataSource = dt.DefaultView;
            //CheckColumnType();

            dataGridView1.AutoResizeRows();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {

        }
    }
}
