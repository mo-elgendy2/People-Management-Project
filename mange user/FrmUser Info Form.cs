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
    public partial class FrmUser_Info_Form : Form
    {

        private int _userId = 0;

        public FrmUser_Info_Form(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void FrmUser_Info_Form_Load(object sender, EventArgs e)
        {

            userCTRinfo1.LoadUserInfo(_userId);

        }

        private void BTnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
