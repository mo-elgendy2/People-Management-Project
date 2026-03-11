using bescnesLayer;
using DVLD.Controls.ApplicationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.Applictions.Local_Driving_License
{
    public partial class Ctrl_DrivingLicenseApplicationInfo : UserControl
    {

        private clsLocalDrivingLicenseApplicaton _LocalDrivingLicenseApplicaton;
        private int _LocalDrivingLicenseApplicatonID = -1;
        private int _LicenseID;
        public int LocalDrivingLicenseApplicaton
        {
            get
            {

               return _LocalDrivingLicenseApplicatonID;
            }
        }
        public Ctrl_DrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }


        public void LoadApplicationinfoBYLocalDrivingAppID(int LocalDrivingLicenseApplicaton)
        {
            _LocalDrivingLicenseApplicaton = clsLocalDrivingLicenseApplicaton.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicaton);
            if (_LocalDrivingLicenseApplicaton==null)
            {

_ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Application with ApplicationID = " + LocalDrivingLicenseApplicaton.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillLocalDrivingLicenseApplicationInfo();
        }
        private void Ctrl_DrivingLicenseAPPlicationInfi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            _LicenseID = _LocalDrivingLicenseApplicaton.GetActiveLicenseID();

            //incase there is license enable the show link.
            llShowLicenceInfo.Enabled = (_LicenseID != -1);


            lblLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplicaton.LocalDrivingLicenseApplicationID.ToString();
            lblAppliedFor.Text = clsLicenseClass.Find(_LocalDrivingLicenseApplicaton.LicenseClassID).ClassName;
            lblPassedTests.Text = 3.ToString();
                //_LocalDrivingLicenseApplicaton.GetPassedTestCount().ToString() + "/3";
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalDrivingLicenseApplicaton.ApplicationID);

        }


        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            _LocalDrivingLicenseApplicatonID = -1;
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
            lblLocalDrivingLicenseApplicationID.Text = "[????]";
            lblAppliedFor.Text = "[????]";


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
