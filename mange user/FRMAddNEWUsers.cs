using bescnesLayer.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace People_Management__full_pro__1set.mange_user
{
    public partial class FRMAddNEWUsers : Form
    {
         public enum enMode { AddNew=0, Update=1 }

        private enMode _Mode;
        private  int _UserID=-1;

        clsUser _user;
         bool ISvalid = true ;
  







        public FRMAddNEWUsers()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FRMAddNEWUsers( int ID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = ID;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.StartPosition= FormStartPosition.CenterScreen;
        }

        void _ResetDefaltValuses()
        {
            if (_Mode == enMode.AddNew)
            {
                label1.Text = " Add New Users";
                this.Text = " Add New Users";
                _user = new clsUser();
                tabPage2.Enabled=true;
                controlFlterDE1.FitlrFocs();
                TXTName.Text = controlFlterDE1.Username.ToString();





            }
            else
            {
                label1.Text = " UpDate Users";
                this.Text = " UpDate Users";
                BTnClose.Enabled = true;
                BTNSave.Enabled = true;
                tabPage2.Enabled = true;

            }
        }

        private void FRMAddNEWUsers_Load(object sender, EventArgs e)
        {
            tabPage1.Text = " Personal Info";
            tabPage2.Text = " Login Info";


            _ResetDefaltValuses();
            if (_Mode==enMode.Update)
            {
                _loadData();
            }

        }

        void _loadData() 
        {

            _user = clsUser.FindUserByID(_UserID);
            controlFlterDE1.FilterEabeld=false;

            if (_user == null) 
            {
                MessageBox.Show(" NO user With ID " + _UserID + "user not  found");
                return; 
            
            }
            LebID.Text=_user.UserID.ToString();
            TXTName.Text=_user.UserName.ToString();
            txtPass.Text = _user.Password.ToString();
            txtREPass.Text = _user.Password.ToString()
              ;
            checkBoxACtive.Checked=_user.IsActive;
            controlFlterDE1.LoadPersonInfo(_user.PersonID);
            MessageBox.Show(" user  ID " + _user.UserID );




        }

        private void BTNnext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)

            {

                BTNSave.Enabled = true;
                tabPage1.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                return;


            }
            MessageBox.Show("PersonID = " + controlFlterDE1.PersonId.ToString());


            if (controlFlterDE1.PersonId != -1)
            {


                if (clsUser.isUserExistForPersonID(controlFlterDE1.PersonId))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK);
                    controlFlterDE1.FitlrFocs();

                }
                else
                {
                    BTNSave.Enabled = true;
                    tabPage1.Enabled = true;
                    tabControl1.SelectedTab = tabControl1.TabPages[1];



                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controlFlterDE1.FitlrFocs();

            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "valdation error",
                 MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }

            if (txtPass.Text != txtREPass.Text)
            {
                MessageBox.Show("This is the Password incorrect",
    "Error",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
            }


            _user.UserID=_UserID;
            _user.PersonID=controlFlterDE1.PersonId;
            _user.UserName=TXTName.Text;
            _user.Password=txtPass.Text;
            _user.IsActive=checkBoxACtive.Checked;


            if (_user.save())
            {
                LebID.Text=_user.UserID.ToString();
                _Mode = enMode.Update;
                label1.Text = "Update User";
                this.Text= label1.Text;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void TXTName_Validating(object sender, CancelEventArgs e)
        {
            //ISvalid = clsValidateInput.ValidateInput(TXTName, clsValidateInput.enInputType.LettersOnly, errorProvider1);
            //e.Cancel = !ISvalid;

            if (string.IsNullOrEmpty(TXTName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TXTName, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(TXTName, null);
            }

            if (_Mode == enMode.AddNew)
            {
                if (clsUser.isUserExist(TXTName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TXTName, " username is used by another user");

                }
                else
                {
                    errorProvider1.SetError(TXTName, null);
                }
            }
            else
            {
                //_Mode= enMode.Update;
                if (_user.UserName!=TXTName.Text.Trim())
                {
                    if (clsUser.isUserExist(TXTName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(TXTName, " username is used by another user");

                    }
                    else
                    {
                        errorProvider1.SetError(TXTName, null);
                    }

                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            ISvalid = clsValidateInput.ValidatePassword(txtPass,txtPass, errorProvider1);
            e.Cancel = !ISvalid;

        }

        private void txtREPass_Validating(object sender, CancelEventArgs e)
        {


            ISvalid = clsValidateInput.ValidatePassword(txtPass, txtREPass, errorProvider1);
            e.Cancel = !ISvalid;


        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {

        }

        private void controlFlterDE1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(" id???? lode control=="  +person);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            this.AutoValidate=AutoValidate.Disable;
            this.Close();
        }
    }
}
