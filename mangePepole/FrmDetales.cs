using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static People_Management__full_pro__1set.UserControl1;

namespace People_Management__full_pro__1set
{
    public partial class FrmDetales : Form
    {
        public event EventHandler<int> FrmMainDataBack;
        public enum enMode { AddNew = 0, Update = 1 };

        int _conid;
        public FrmDetales( int con)
        {

            InitializeComponent();
            _conid = con;
            userControl11.DataBack += MyuserControl11_DataBack;
        }
        public FrmDetales( )
        {

            InitializeComponent();
            _conid = -1;
            
            userControl11.DataBack += MyuserControl11_DataBack;
        }



         void MyuserControl11_DataBack(object sender, int personID)
        {


            FrmMainDataBack?.Invoke(this, personID);
        }

        private void FrmDetales_Load(object sender, EventArgs e)
        {
         userControl11.ContactID = _conid;
            //UserControl1 user = new UserControl1();
            //user.Dock = DockStyle.Fill;
            //this.Controls.Add(user);
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = true;


        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

    }
}
