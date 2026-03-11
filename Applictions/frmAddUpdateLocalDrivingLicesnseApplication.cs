using bescnesLayer;
using bescnesLayer.BusinessLayer;
using BusinessLayer;
using People_Management__full_pro__1set.mangePepole.controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.Applictions
{
    public partial class frmAddUpdateLocalDrivingLicesnseApplication : Form
    {
        // استخدام Enum بنفس أسلوب الأستاذ
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        private int _RecevedID_LocalDrivingLicenseApplicationID = -1;
        private int _SelectedPersonID = -1;
        clsLocalDrivingLicenseApplicaton _LocalDrivingLicenseApplicaton;

        public frmAddUpdateLocalDrivingLicesnseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddUpdateLocalDrivingLicesnseApplication(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _RecevedID_LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID;
            _Mode = enMode.Update;
        }

        private void _FillLicenseClassesInComoboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.GetAllLicenseClasses();
            comboBox1.Items.Clear(); // تأكد من مسح العناصر القديمة
            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                comboBox1.Items.Add(row["ClassName"]);
            }
        }

        private void _RestDefualtvalues()
        {
            _FillLicenseClassesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                label14.Text = "New Local Driving License Application";
                this.Text = "New Local Driving License Application";
                _LocalDrivingLicenseApplicaton = new clsLocalDrivingLicenseApplicaton();

                // التحكم في الواجهة (أسلوب الأستاذ)
                controlFlterDE1.FitlrFocs();
                tabControl1.Enabled = true; // تعطيل التاب الثانية حتى يتم اختيار شخص

                comboBox1.SelectedIndex = 2; // اختيار رخصة عادية افتراضياً
                feesLP.Text = ClsAppTypes.Find((int)clsApplictions.enApplicationType.NewDrivingLicense).Fees.ToString();
                lpappdate.Text = DateTime.Now.ToShortDateString();
                labCreated.Text =
              clsGlobal.CurrentUser.UserName;
                BTNSave.Enabled = false; // لا يمكن الحفظ قبل اختيار شخص
            }
            else
            {
                label14.Text = "Update Local Driving License Application";
                this.Text = "Update Local Driving License Application";
                tabControl1.Enabled = true;
                BTNSave.Enabled = true;
            }
        }

        private void _LoadData()
        {
            controlFlterDE1.Enabled = false;
            _LocalDrivingLicenseApplicaton = clsLocalDrivingLicenseApplicaton.FindByLocalDrivingAppLicenseID(_RecevedID_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplicaton == null)
            {
                MessageBox.Show("No Application with ID = " + _RecevedID_LocalDrivingLicenseApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            // تحميل بيانات الشخص في الـ Control الخاص بك
            controlFlterDE1.LoadPersonInfo(_LocalDrivingLicenseApplicaton.ApplicantPersonID);
            _SelectedPersonID = _LocalDrivingLicenseApplicaton.ApplicantPersonID;

            lbId.Text = _LocalDrivingLicenseApplicaton.LocalDrivingLicenseApplicationID.ToString();
            lpappdate.Text = clsFormat.
                DateToShort(_LocalDrivingLicenseApplicaton.ApplicationDate);
            comboBox1.SelectedIndex = comboBox1.FindString(clsLicenseClass.Find(_LocalDrivingLicenseApplicaton.LicenseClassID).ClassName);
            feesLP.Text = _LocalDrivingLicenseApplicaton.PaidFees.ToString();
            labCreated.Text = clsUser.FindUserByID(_LocalDrivingLicenseApplicaton.CreatByUserId).UserName;
        }

        private void frmAddUpdateLocalDrivingLicesnseApplication_Load(object sender, EventArgs e)
        {
            _RestDefualtvalues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void BTNnext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                tabControl1.SelectedTab = tabControl1.TabPages["tpApplicationInfo"];
                return;
            }

            // التحقق من اختيار شخص قبل الانتقال (منطق الأستاذ)
            if (controlFlterDE1.PersonId != -1)
            {
                _SelectedPersonID = controlFlterDE1.PersonId;
                BTNSave.Enabled = true;
                tabControl1.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpApplicationInfo"];
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controlFlterDE1.FitlrFocs();
            }
        }

        private void BTNSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseClassID = clsLicenseClass.Find(comboBox1.Text).LicenseClassID;

            // 1. التحقق من وجود طلب نشط لنفس الشخص والفئة
            int ActiveApplicationID = clsApplictions.GetActiveApplicationIDForLicenseClass(_SelectedPersonID, clsApplictions.enApplicationType.NewDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1 && _Mode == enMode.AddNew)
            {
                MessageBox.Show("Selected Person already has an active application for this class with ID=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //// 2. التحقق من وجود رخصة سابقة (تم تفعيل الكود بناءً على أسلوب الأستاذ)
            //if (clsLicense.IsLicenseExistByPersonID(controlFlterDE1.PersonId, LicenseClassID))
            //{
            //    MessageBox.Show("Person already has a license for this class!", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // إسناد القيم للكائن
            _LocalDrivingLicenseApplicaton.ApplicantPersonID = _SelectedPersonID;
            _LocalDrivingLicenseApplicaton.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplicaton.ApplcationTypeId = (int)clsApplictions.enApplicationType.NewDrivingLicense;
            _LocalDrivingLicenseApplicaton.applcatonStatus = clsApplictions.enApplicationStatus.New;
            _LocalDrivingLicenseApplicaton.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplicaton.PaidFees = Convert.ToSingle(feesLP.Text);
            _LocalDrivingLicenseApplicaton.CreatByUserId = clsGlobal.CurrentUser.UserID;
            _LocalDrivingLicenseApplicaton.LicenseClassID = LicenseClassID;

            if (_LocalDrivingLicenseApplicaton.Save())
            {
                lbId.Text = _LocalDrivingLicenseApplicaton.LocalDrivingLicenseApplicationID.ToString();
                _Mode = enMode.Update;
                label14.Text = "Update Local Driving License Application";
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data was not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void controlFlterDE1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;
        }

        private void frmAddUpdateLocalDrivingLicesnseApplication_Activated(object sender, EventArgs e)
        {
            controlFlterDE1.FitlrFocs();
        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}