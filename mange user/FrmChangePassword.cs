using bescnesLayer.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.mange_user
{
    public partial class FrmChangePassword : Form
    {

        private  int _userid=0;

        clsUser _User;

        public FrmChangePassword(int userid)
        {
            InitializeComponent();
            _userid = userid;
            guna2ControlBox1.FillColor.ToArgb();

            guna2ControlBox1.HoverState.FillColor = Color.FromArgb(231, 76, 60);
            guna2ControlBox1.ShadowDecoration.Enabled = false;

        }


        private void _ResetDefualtValues()
        {
           TXTCRnPass.Text = "";
            txtPass.Text = "";
            txtREPass.Text = "";
            TXTCRnPass.Focus();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            _User = clsUser.FindUserByID(_userid);

            if (_User==null )
            {
                MessageBox.Show("Could not Find User with id = " + _userid,
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;

            }
            userCTRinfo1.LoadUserInfo(_userid);
            //this.CausesValidation = false;


            //MessageBox.Show(" this pass" + _User.Password);

        }

        void CheckPass()
        {
            if (_User == null)
            {
                MessageBox.Show("User not loaded");
                return;
            }

            string enteredPass = TXTCRnPass.Text.Trim();

            if (string.IsNullOrEmpty(enteredPass))
            {
                MessageBox.Show("Enter password");
                return;
            }

            if (enteredPass == _User.Password)
            {
                MessageBox.Show("Password is correct");
            }
            else
            {
                MessageBox.Show("Password is wrong");
            }
        }

        







        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtREPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void TXTCRnPass_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrEmpty(TXTCRnPass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TXTCRnPass, "Username cannot be blank");
                return;
            }
            else
            {
                errorProvider1.SetError(TXTCRnPass, null);
            }
            ;

            if (_User.Password != TXTCRnPass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(TXTCRnPass, "Current password is wrong!");
                return;
            }
            else
            {
                errorProvider1.SetError(TXTCRnPass, null);
            }
            ;
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPass, "New Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPass, null);
            }
            ;
        }

        private void txtREPass_Validating(object sender, CancelEventArgs e)
        {
            if (txtREPass.Text.Trim() != txtPass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtREPass, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtREPass, null);
            }
            ;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtPass.Text;

            if (_User.save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MessageBox.Show("Password Changed Successfully.");


            

        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            //this.CausesValidation = false;
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            guna2ControlBox1.FillColor.ToArgb();

            guna2ControlBox1.HoverState.FillColor = Color.FromArgb(231, 76, 60);
            guna2ControlBox1.ShadowDecoration.Enabled = false;

        }
    }
}
