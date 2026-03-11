using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.mangePepole.controls
{
    public partial class ControlFlterDE : UserControl
    {
        public ControlFlterDE()
        {
            InitializeComponent();
        }

      
        public event Action<int> OnPersonSelected;
        protected virtual void PersonSelected(int personId) 
        {
        
            Action<int> fire = OnPersonSelected;

            if (fire!= null)
            {
                fire(personId);
                
            }
        }

        private  bool _showADDPerson=true;

        public bool ShowAddPerson
        {

            get
            {
                return _showADDPerson;
            }
            set
            {
                _showADDPerson = value;

                //bt= _showADDPerson
                gunabtnAdd.Visible=_showADDPerson;


            }
        }

        private bool _Filter=true;

        public bool FilterEabeld
        {
            get {
                return _Filter;
            }
            set
            {
                _Filter = value;

                groupBox1.Enabled = _Filter;
            }

            }
        private int _PersonID = -1;

        private string _Username = "";

            public string Username 
        {
            get
            {
                return userControl21.nnname;
            }
        
        }
           
        public int PersonId
        {
            get
            {
                return userControl21.PersonId;
            }
            //set
            //{
            //    if (_PersonID != value)
            //    {
            //        _PersonID = value;
            //        //userControl21.PersonId = value;
            //    }
            //}
        }

        public clsContact selectedPersonInfo
        {

            get { return userControl21.SelectedPerson; }
        }

        public void LoadPersonInfo(int personID) 
        {
          //uC_Filter1.txtSearch=PersonId.ToString();
          cbColumns.SelectedIndex = 1;

            txtSearch.Text= personID.ToString();
            FindNow();

        }

        private  void FindNow() 
        {
            switch (cbColumns.Text)
            {
                case "PersonID":

                    if (int.TryParse(txtSearch.Text, out int personID))
                    {       
                        //userControl21.PersonId = personID;
                    userControl21.LoadPersonByID(int.Parse(txtSearch.Text.Trim()));
                    MessageBox.Show("22222222222222222222222");
                        //PersonId = userControl21.PersonId;
                        // تعيين Property → LoadPerson() يشتغل
                    }
                    break;


                case "NationalNo":
                    //userControl21.PersonId = -1;

                  //string na=  userControl21.naional_NO=txtSearch.Text;
                     MessageBox.Show("HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH");
                    userControl21.LoadPersonByNationalNo(txtSearch.Text.Trim());
                    //PersonId = userControl21.PersonId;

                    break;
                default:
                    break;
            }

            if(OnPersonSelected!=null&& FilterEabeld) 
            {
            OnPersonSelected(userControl21.PersonId);
            }
        }
        private void ControlFlterDE_Load(object sender, EventArgs e)
        {

            cbColumns.SelectedIndex = 0;
            txtSearch.Focus();
        }

        private void uC_Filter1_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //txtSearch.Text = "";
            //txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        //    if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
        //    {
        //        MessageBox.Show("Please enter a value to search.");
        //        return;
        //    }

        //    if (!this.ValidateChildren())
        //    {
        //        MessageBox.Show("same Filed Are Not Vlide , Put the Mouse Over the red  icon");
        //        return;
        //    }
        //    FindNow();
        }

        private void txtSearch_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim())) 
            {
            
            e.Cancel = true;
                errorProvider1.SetError(txtSearch, "required!");
            }
            else
            {
                errorProvider1.SetError(txtSearch, null);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FrmDetales frm = new FrmDetales(PersonId);
            //frm.FrmMainDataBack += DaTaBack;
            //frm.ShowDialog();


        }


        private void DaTaBack(object sender, int PersonID) 
        {

            cbColumns.SelectedIndex = 1;
            txtSearch.Text=PersonId.ToString();
            //PersonId = PersonID;
            userControl21.LoadPersonByID(PersonID);
        }
       public void FitlrFocs()
        {
             txtSearch.Focus();
        }

        private void ControlFlterDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) 
            {
            
            gunabtnAdd.PerformClick();
            }
            if(cbColumns.Text=="PersonID")
                e.Handled = !char.IsDigit(e.KeyChar)&&!char.IsControl(e.KeyChar);

        }

        private void userControl21_Load(object sender, EventArgs e)
        {
            cbColumns.Items.Add("PersonID");
            cbColumns.Items.Add("NationalNo");
//MessageBox.Show( "userControl21 con filter==========="+PersonId);
            cbColumns.SelectedIndex = 0;
            txtSearch.Focus();
            if (PersonId > 0) 
            {
                LoadPersonInfo(PersonId);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("Please enter a value to search.");
                return;
            }

            if (!this.ValidateChildren())
            {
                MessageBox.Show("same Filed Are Not Vlide , Put the Mouse Over the red  icon");
                return;
            }
            FindNow();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            
                FrmDetales frm = new FrmDetales();
                frm.FrmMainDataBack += DaTaBack;
                frm.ShowDialog();


            }

        private void guna2btnSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
