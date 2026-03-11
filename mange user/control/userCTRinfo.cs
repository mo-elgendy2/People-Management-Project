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
    public partial class userCTRinfo : UserControl
    {
        public userCTRinfo()
        {
            InitializeComponent();
        }

        
            private clsUser _User;
            private int _UserID = -1;

            public int UserID
            {
                get { return _UserID; }
            }

         

            public void LoadUserInfo(int UserID)
            {
                _User = clsUser.FindUserByID(UserID);
                if (_User == null)
                {
                    _ResetPersonInfo();
                    MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _FillUserInfo();
            }

            private void _FillUserInfo()
            {

                userControl21.LoadPersonByID(_User.PersonID);
                lblUserID.Text = _User.UserID.ToString();
                lblUserName.Text = _User.UserName.ToString();

                if (_User.IsActive)
                    lblIsActive.Text = "Yes";
                else
                    lblIsActive.Text = "No";

            }

            private void _ResetPersonInfo()
            {

                userControl21.ReestValue();
                lblUserID.Text = "[???]";
                lblUserName.Text = "[???]";
                lblIsActive.Text = "[???]";
            }

            private void ctrlPersonCard1_Load(object sender, EventArgs e)
            {

            }

            private void ctrlUserCard_Load(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

        private void userCTRinfo_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
    }

