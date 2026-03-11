using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.mangePepole
{
    public partial class FrmPerDetails : Form
    {
        private int _ConID;
        public FrmPerDetails( int receivedID)
        {
            InitializeComponent();
            _ConID = receivedID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void FrmPerDetails_Load(object sender, EventArgs e)
        {
            userControl21.PersonId= _ConID;

            guna2Button3.BackColor=Color.AliceBlue;

        }

        private void FrmPerDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            userControl21.PersonId = _ConID;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {


            this.Close();
        }
    }
}
