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
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {

        int _Appid = -1;

        public frmLocalDrivingLicenseApplicationInfo(int id)
        {
            InitializeComponent();
            StyleGunaCloseButton(BTnClose);
            StyleCloseControlBox(guna2ControlBox1);
            _Appid = id;
        }
        private void StyleCloseControlBox(Guna.UI2.WinForms.Guna2ControlBox closeBox)
        {
            // اللون الأساسي أزرق
            closeBox.FillColor = Color.FromArgb(52, 152, 219); // أزرق عصري
            closeBox.HoverState.FillColor = Color.FromArgb(231, 76, 60); // أحمر عند Hover
            closeBox.IconColor = Color.White; // لون الإكس (×) أبيض
            closeBox.ShadowDecoration.Enabled = false; // لو مش عايز ظل
        }

        private void StyleGunaCloseButton(Guna.UI2.WinForms.Guna2Button btn)
        {
            // اللون الأساسي أزرق عصري
            btn.FillColor = Color.FromArgb(52, 152, 219); // أزرق
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Hover effect → يتحول أحمر عصري
            btn.HoverState.FillColor = Color.FromArgb(231, 76, 60); // أحمر عند Hover

            // Click effect → أحمر أغمق
            btn.PressedColor = Color.FromArgb(192, 57, 43); // الضغط
        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrl_DrivingLicenseApplicationInfo1.LoadApplicationinfoBYLocalDrivingAppID(_Appid);
        }

        private void ctrl_DrivingLicenseApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
