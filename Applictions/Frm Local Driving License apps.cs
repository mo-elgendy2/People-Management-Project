using bescnesLayer;
using bescnesLayer.BusinessLayer;
using People_Management__full_pro__1set.Applictions;
using People_Management__full_pro__1set.Applictions.Local_Driving_License;
using People_Management__full_pro__1set.Licenses;
using People_Management__full_pro__1set.mange_user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace People_Management__full_pro__1set.applictions
{
    public partial class Frm_Local_Driving_License_apps : Form
    {
        // استخدام DataTable خاص بالفورم للتحكم في الفلترة
        private DataTable _dtAllLocalDrivingLicenseApplications;

        public Frm_Local_Driving_License_apps()
        {
            InitializeComponent();
        }

        private void Frm_Local_Driving_License_apps_Load(object sender, EventArgs e)
        {
            // جلب البيانات الأصلية
            _dtAllLocalDrivingLicenseApplications = clsLocalDrivingLicenseApplicaton.GetAllLocalDrivingLicenseApplications();
            dataGridView1.DataSource = _dtAllLocalDrivingLicenseApplications;

            // تحديث عدد السجلات
            label3.Text = dataGridView1.RowCount.ToString();

            // إعداد القائمة المنسدلة للفلترة
            add();

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "L.D.L.AppID";
                dataGridView1.Columns[0].Width = 120;

                dataGridView1.Columns[1].HeaderText = "Driving Class";
                dataGridView1.Columns[1].Width = 300;

                dataGridView1.Columns[2].HeaderText = "National No.";
                dataGridView1.Columns[2].Width = 150;

                dataGridView1.Columns[3].HeaderText = "Full Name";
                dataGridView1.Columns[3].Width = 350;

                dataGridView1.Columns[4].HeaderText = "Application Date";
                dataGridView1.Columns[4].Width = 170;

                dataGridView1.Columns[5].HeaderText = "Passed Tests";
                dataGridView1.Columns[5].Width = 150;
            }
        }

        private void add()
        {
            filterItim.Items.Clear();
            filterItim.Items.Add("None");
            filterItim.Items.Add("L.D.L.AppID");
            filterItim.Items.Add("National No");
            filterItim.Items.Add("Full Name");

            filterItim.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // إظهار أو إخفاء صندوق النص بناءً على الاختيار
            textFilter.Visible = (filterItim.Text != "None");

            if (textFilter.Visible)
            {
                textFilter.Text = "";
                textFilter.Focus();
            }

            // إعادة ضبط الفلتر عند تغيير العمود المختار
            _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
            label3.Text = dataGridView1.Rows.Count.ToString();
        }

        private void textFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            // ربط الاختيار باسم العمود الحقيقي في قاعدة البيانات
            switch (filterItim.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            // إذا لم يتم اختيار شيء أو النص فارغ، الغِ الفلترة
            if (textFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = "";
                label3.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            // تطبيق الفلترة: إذا كان ID نستخدم مساواة رقمية، وإلا نستخدم LIKE للنصوص
            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, textFilter.Text.Trim());
            else
                _dtAllLocalDrivingLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, textFilter.Text.Trim());

            label3.Text = dataGridView1.Rows.Count.ToString();
        }

        private void textFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            // السماح بالأرقام فقط إذا كان البحث برقم الطلب (ID)
            if (filterItim.Text == "L.D.L.AppID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // الحفاظ على الأحداث التي قد تكون مرتبطة بالـ UI لديك
        private void activepox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // يمكنك هنا إضافة فلترة الحالة (Status) إذا كان الـ ComboBox موجوداً
        }

        private void textFilter_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // توجيه الحدث لنفس الدالة لتوحيد المنطق
            textFilter_KeyPress(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm= new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm =
                      new frmLocalDrivingLicenseApplicationInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            //refresh
            Frm_Local_Driving_License_apps_Load (null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            frmAddUpdateLocalDrivingLicesnseApplication frm =
                         new frmAddUpdateLocalDrivingLicesnseApplication(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            Frm_Local_Driving_License_apps_Load(null, null);

        }

        private void CancelApplicaitonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplicaton LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplicaton.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    Frm_Local_Driving_License_apps_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ScheduleTestsMenue_Click(object sender, EventArgs e)
        {

        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplicaton.FindByLocalDrivingAppLicenseID(
               LocalDrivingLicenseApplicationID).GetActiveLicenseID();

            if (LicenseID != -1)
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalDrivingLicenseApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplicaton localDrivingLicenseApplication = clsLocalDrivingLicenseApplicaton.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(localDrivingLicenseApplication.ApplicantPersonID);
            frm.ShowDialog();
        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int LocalDrivingLicenseApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplicaton LocalDrivingLicenseApplication =
                clsLocalDrivingLicenseApplicaton.FindByLocalDrivingAppLicenseID(LocalDrivingLicenseApplicationID);

            if (LocalDrivingLicenseApplication != null)
            {
                if (LocalDrivingLicenseApplication.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //refresh the form again.
                    Frm_Local_Driving_License_apps_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_ScheduleTest(clsTestType.enTestType.VisionTest);

        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_ScheduleTest(clsTestType.enTestType.WrittenTest);
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //_ScheduleTest(clsTestType.enTestType.StreetTest);

        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LocalDrivingLicenseApplicationID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime(LocalDrivingLicenseApplicationID);
            frm.ShowDialog();
            //refresh
            //frmListLocalDrivingLicesnseApplications_Load(null, null);
        }
    }
}