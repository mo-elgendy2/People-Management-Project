using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set
{
    public partial class frmAddPeople3 : Form
    {
        private int _conID;

       

        public frmAddPeople3(int conID)
        {

            InitializeComponent();
            _conID = conID;
        }

        private void frmAddPeople_Load(object sender, EventArgs e)
        {
            userControl11.ContactID = _conID;

            this.Controls.Add(userControl11);
            //userControl11.LoadPerson(_conID);
            userControl11.Dock = DockStyle.Fill; // الكنترول يشغل كل مساحة الحاوية

            //
        }

        public frmAddPeople3()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {

                InitializeComponent();
              

            }
            else
            {
                // متعملش حاجه هنا، التشغيل الحقيقي بيستخدم الكونستركتور التاني
            }
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_2(object sender, EventArgs e)
        {

        }

        private void userControl11_Load_3(object sender, EventArgs e)
        {

        }
    }
}
