using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace People_Management__full_pro__1set
{
    public partial class UserControl2 : UserControl
    {
     private   clsContact _Person;

        private int _personId = -1;
        private string _NationalNo = "";




        public int PersonId
        {
            get { return _personId; }
            set
            {
                _personId = value;
                //if (_personId != -1)
                //{
                //    LoadPersonByID(_personId); // تحميل البيانات مباشرة عند التعيين
                //}
            }
        }
        public string  naional_NO
        {
            get { return _NationalNo; }
            set
            {
                _NationalNo = value;
                _personId=-1;
                if (!string.IsNullOrWhiteSpace(_NationalNo))
                {
                  
                    LoadPersonByNationalNo(_NationalNo);
                }

            }
        }
        public string nnname
        {
            get
            {
                return _Person.FirstName+_Person.SecondName;
            }
        }

        public clsContact SelectedPerson 
        {
            get { return _Person; }
        
        }
       
        public UserControl2()
        {
            InitializeComponent();
            _Person = new clsContact();

        }
        //public UserControl2(int person)
        //{
        //    InitializeComponent();
        //    _PersonId = person;
        //}




        private void label13_Click(object sender, EventArgs e)
        {
        }





        // تحميل بيانات الشخص عن طريق الـ ID
        public void LoadPersonByID(int id)
        {
            _Person = clsContact.Find(id);

            if (_Person == null || _Person.ID <= 0)
            {
                MessageBox.Show("❌ No person found with ID: " + id);
                return;
            }

            _personId = _Person.ID;

            DisplayPerson();
        }

        // تحميل بيانات الشخص عن طريق الـ NationalNo
        public void LoadPersonByNationalNo(string nationalNo)
        {
            _Person = clsContact.Find(nationalNo);

            if (_Person == null)
            {
                MessageBox.Show("❌ No person found with NationalNo: " + nationalNo.ToString());
                return;
            }
            _personId = _Person.ID;

            DisplayPerson();
        }

        // دالة لعرض بيانات الشخص على الكنترول
        private void DisplayPerson()
        {
            if (_Person == null) return;

            label13.Text = _Person.ID.ToString();
            string fullname = $"{_Person.FirstName} {_Person.SecondName} {_Person.ThirdName} {_Person.LastName}";
            label1.Text = fullname;
            label2.Text = _Person.NationalNo.ToString();
            label3.Text = _Person.Gendor == 0 ? "male" : "female";
            label4.Text = _Person.Email ?? "";
            label16.Text = _Person.Address ?? "";
            label26.Text = _Person.DateOfBirth.ToString("d");
            label27.Text = _Person.Phone ?? "";
            label28.Text = clsContact.GetCountryNameByID(_Person.CountryID);

            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                pictureBox1.Image = Image.FromFile(_Person.ImagePath);
            else
                pictureBox1.Image = null;
        }





        public  void ReestValue() 
        {


            label13.Text = "?????";
            string fullname = "?????"; // لو عايز كمان تمسح القيمة من المتغير
            label1.Text = "?????";
            label2.Text = "?????";
            label3.Text = "?????";
            label4.Text = "?????";
            label16.Text = "?????";
            label26.Text = "?????";
            label27.Text = "?????";
            label28.Text = "?????";





        }











        //    public void  LoadPerson()
        //    {

        //        if (PersonId != -1)
        //        {
        //            _Person = clsContact.Find(PersonId);
        //        }
        //        else if (!string.IsNullOrEmpty(naional_NO))
        //        {
        //            _Person = clsContact.FindByNationalNo(naional_NO);
        //            if (_Person==null)
        //            {
        //MessageBox.Show("No person found with NationalNo: " + _NationalNo);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("❌ No Person ID or NationalNo provided", "Error", MessageBoxButtons.OK);
        //            return;
        //        }

        //        if (_Person == null || _Person.ID <= 0)
        //        {
        //            MessageBox.Show("❌ No person found", "Error", MessageBoxButtons.OK);
        //            return;
        //        }

        //        label13.Text = _Person.ID.ToString();
        //        string fullname = $"{_Person.FirstName} {_Person.SecondName} {_Person.ThirdName} {_Person.LastName}";
        //        label1.Text=fullname;
        //        label2.Text = _Person.NationalNo.ToString();
        //        if (_Person.Gendor==0)
        //        {
        //            label3.Text = _Person.Gendor.ToString("male");

        //        }
        //        else { label3.Text = _Person.Gendor.ToString("female"); }

        //            label4.Text = _Person.Email.ToString();
        //        label16.Text = _Person.Address.ToString();
        //        label26.Text=_Person.DateOfBirth.ToString("d");
        //        label27.Text=_Person.Phone.ToString();
        //        label28.Text = clsContact.GetCountryNameByID(_Person.CountryID);
        //        if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
        //        {
        //            pictureBox1.Image = Image.FromFile(_Person.ImagePath);
        //        }
        //        else
        //        { 

        //            pictureBox1.Image = null;
        //        }


        //    }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            //LoadPerson();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //var frm = Application.OpenForms["MangePeople"] as MangePeople;

            //if (frm != null)
            //{
            //    // الكائن موجود... شغلك هنا
            //    frm.button1Public.PerformClick();
            //}
            //else
            //{
            //    MessageBox.Show("الفورم مش مفتوح أو ا.");
            //}

            FrmDetales frm = new FrmDetales(this.PersonId); 
            frm.ShowDialog();
            LoadPersonByID(this.PersonId);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.FindForm().Close();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
