using bescnesLayer;
using DVLD.Classes;
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
    public partial class FrmUpdataTestType : Form
    {
         private ClsManageTestApp.enTestType _TestTypeID=ClsManageTestApp.enTestType.VisionTest;
        private ClsManageTestApp _testTypel;
        private int _conID;
        private string _name;
        private string _Descreption;
        private double _Fees;

     
        public FrmUpdataTestType(ClsManageTestApp.enTestType id)
        {
            InitializeComponent();
            _TestTypeID = id;
            this.StartPosition = FormStartPosition.CenterScreen;
           
            
            this.WindowState = FormWindowState.Normal;



        }
        //public FrmUpdataTestType(int conID,string Titile,string Descreption,double fees)
        //{
        //    InitializeComponent();
        //    _conID = conID;
        //    _name = Titile;
        //    _Descreption = Descreption;
        //    _Fees= fees;

        //}

        private void FrmUpdataTestType_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            this.WindowState = FormWindowState.Normal;

            _testTypel = ClsManageTestApp.Find(_TestTypeID);
            if (_testTypel != null)
            {




                label3.Text = ((int)_TestTypeID).ToString();
                textBox2.Text = _testTypel.Title.ToString();
                textBox3.Text = _testTypel.Descreption.ToString();
                textBox1.Text = _testTypel.Fees.ToString();
            }
            else
            {
                MessageBox.Show("Could not find Test Type with id = " + _TestTypeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();


            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

       public void Save() 
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            //ClsManageTestApp app=new ClsManageTestApp();
            //int ID =_conID;
            //string Title = textBox2.Text.Trim();
            //double Fees = Convert.ToDouble(textBox1.Text.Trim());
            //string DEs = textBox3.Text.Trim();
            ////app.AppID = ID;
            //app.Title = Title;
            //app.Fees = Fees;
            //app.Descreption=DEs;
            
            string Title = textBox2.Text.Trim();
            double Fees = Convert.ToDouble(textBox1.Text.Trim());
            string DEs = textBox3.Text.Trim();
            _testTypel.Title=Title;
            _testTypel.Fees=Fees;
            _testTypel.Descreption=DEs;
            try
            {
                bool success = _testTypel.save();
                if (success)
                    MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No changes were made. Please verify the ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" خطأ: " + ex.Message);
            }

        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            Save();


        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(textBox1, null);
            }
            ;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
            }
            ;
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox3, null);

            }
            ;


            if (!clsValidatoin.IsNumber(textBox3.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox3, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(textBox3, null);
            }
            ;
        }
    }
}
