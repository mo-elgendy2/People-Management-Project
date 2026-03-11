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
    public partial class FrmFindPerson : Form
    {

        public delegate void DataBackEvent(object send, int ID);

        public event DataBackEvent dataBACK;
        public FrmFindPerson()
        {
            InitializeComponent();
        }

        private void FrmFindPerson_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dataBACK?.Invoke(this, controlFlterDE1.PersonId);
            this.Close();

            
        }

        private void controlFlterDE1_Load(object sender, EventArgs e)
        {

        }
    }
}
