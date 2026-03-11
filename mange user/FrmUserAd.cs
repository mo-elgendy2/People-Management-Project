using bescnesLayer.BusinessLayer;
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

namespace People_Management__full_pro__1set.mange_user
{
    public partial class FrmUserAd : Form


    {

        public enum enMode { AddNew=0, UpdateNew=1};
        private enMode _Mode;
        private int _UserID=-1;// قيمه 
        clsUser _User;
        DataTable dtPeople = clsContact.GetallContacet();





        private int _receivedID;
        public FrmUserAd()
        {
            InitializeComponent();
            _Mode=enMode.AddNew;
        }
        public FrmUserAd(int senderID)
        {
            InitializeComponent();
            _Mode =enMode.UpdateNew;
            _receivedID = senderID;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           

        }


        private void UserAd_Load(object sender, EventArgs e)
        {

            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            tabPage1.Text = " Personal Info";
            tabPage2.Text = " Login Info";

            if (_Mode == enMode.UpdateNew && _receivedID > 0)
            {
                userControl21.PersonId = _receivedID; // تحميل بيانات الشخص مباشرة
            }
            userControl21.PersonId = _receivedID;
            uC_Filter1.onPersonSelected += (personID) =>
            {
                userControl21.PersonId = personID;
            };


        }

        private void userControl2_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void uC_Filter1_Load(object sender, EventArgs e)
        {
            uC_Filter1.SourceTable = dtPeople;
            uC_Filter1.FilterColumns = new List<string> { "PersonID", "NationalNo", "FirstName" };

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }
    }
}

   /* public partial class FrmUserAd : Form


    {

        public enum enMode { AddNew = 0, UpdateNew = 1 };
        private enMode _Mode;
        private int _UserID = -1;// قيمه 
        clsUser _User;
        //DataTable dtPeople = clsContact.Find(_receivedID);



        public enum SearchType
        {
            PersonID,
            NationalNumber
        }



        private void SearchPerson(SearchType type, string value)
        {
            DataTable dt;

            if (type == SearchType.PersonID)
            {
                int num = Convert.ToInt32(value);
                dt = clsContact.Find(num);
            }
            else
                dt = clsContact.FindByNationalNo(value);

            if (dt.Rows.Count > 0)
            {
                int personID = Convert.ToInt32(dt.Rows[0]["PersonID"]);
                userControl21.PersonId = personID;
            }
        }




        private int _receivedID;
        public FrmUserAd()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FrmUserAd(int senderID)
        {
            InitializeComponent();
            _Mode = enMode.UpdateNew;
            _receivedID = senderID;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }


        private void UserAd_Load(object sender, EventArgs e)
        {

            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            tabPage1.Text = " Personal Info";
            tabPage2.Text = " Login Info";

            if (_Mode == enMode.UpdateNew && _receivedID > 0)
            {
                userControl21.PersonId = _receivedID; // تحميل بيانات الشخص مباشرة
            }
            ////userControl21.PersonId = _receivedID;
            //uC_Filter1.OnSearchRequested += (personID) =>
            //{
            //    userControl21.PersonId = personID;
            //};



        }

        private void userControl2_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void uC_Filter1_Load(object sender, EventArgs e)
        {
            uC_Filter1.SourceTable = dtPeople;
            uC_Filter1.FilterColumns = new List<string> { "PersonID", "NationalNo", "FirstName" };

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }
    }
}*/
   
