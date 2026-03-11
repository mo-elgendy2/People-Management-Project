using DVLD.Classes;
using Guna.UI2.WinForms;
using People_Management__full_pro__1set.applictions;
using People_Management__full_pro__1set.Applictions;
using People_Management__full_pro__1set.Applictions.Renew_Local_License;
using People_Management__full_pro__1set.mange_user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace People_Management__full_pro__1set
{
    public partial class Form1 : Form
    {
        LoginForm _frmLogin;
        public Form1(LoginForm frm)
        {
            InitializeComponent();
            _frmLogin = frm;
        }

         private Button currentButton;

        private Guna2Button nextButton(Guna2Button bt)
        {
            bt.UseTransparentBackground = true;

            bt.FillColor = Color.FromArgb(230, 240, 255);
            bt.ForeColor = Color.FromArgb(30, 30, 30);

            bt.HoverState.FillColor = Color.FromArgb(210, 220, 245);
            bt.HoverState.ForeColor = Color.FromArgb(50, 50, 50);

            bt.Cursor = Cursors.Hand;
           // bt.FillColor = Color.FromArgb(35, 105, 255);
           //bt.HoverState.FillColor = Color.FromArgb(25, 90, 230);
           //bt.ForeColor = Color.White;
           //bt.BorderRadius = 15;


            return bt;
        }


        

        private void ActivateButton(Button btnSender)
        {
            if (btnSender == null)
                return;
            // لو في button كان مفعّل قبل كده
            if (currentButton != null)
            {
                // ارجعه للون الأصلي (الرمادي الغامق)
                currentButton.BackColor = Color.FromArgb(52, 73, 94);
                currentButton.ForeColor = Color.White;
            }

            // خلي الـ button الجديد هو النشط
            currentButton = btnSender;
            // لونه أزرق فاتح عشان يبان إنه مختار
            btnSender.BackColor = Color.FromArgb(41, 128, 185);
            btnSender.ForeColor = Color.White;
        }


        void actionBtn() 
        {


            nextButton(guna2Button1);
            guna2GradientPanel1.ShadowDecoration.Enabled = true;
            nextButton(guna2Button2);
            nextButton(guna2Button3);
            nextButton(guna2Button4);
            nextButton(guna2Button5);
            //guna2Panel2.ShadowDecoration.Enabled= true;
            //guna2Panel1.FillColor = Color.FromArgb(245, 247, 250);
            //guna2Panel1.FillColor = Color.AntiqueWhite;
            //guna2Panel1.ShadowDecoration.Enabled = true;
            //guna2Panel1.FillColor = Color.FromArgb(240, 246, 255);



        }

        private void personControl11_Load(object sender, EventArgs e)
        {

        }

        private void pepoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////////
            ///        this.BackColor = Color.AntiqueWhite;
            //pictureBox2.BackColor = Color.White;
            //this.BackColor = Color.AntiqueWhite;
            ///          pictureBox2.BackColor = Color.White;

            //panel1.BackColor = Color.FromArgb(255, 230, 240, 255);
            //label3.ForeColor = Color.DimGray;
            //label1.ForeColor = Color.Black;
            //RegisterButtons();
            actionBtn();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.TopMost = false;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void button3_Click(object sender, EventArgs e)
        {
 
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    ActivateButton(button2);

        //    //Point p = button2.PointToScreen(Point.Empty);
        //    //p.X += button2.Width;
        //    //contextMenuStrip2.Show(p);
        //    Point p =button2.PointToScreen(Point.Empty);
        //    p.X += button2.Width;
        //    contextMenuStrip2.Show(p);
        //
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //LoginForm log= new LoginForm();
            //log.ShowDialog();

            clsGlobal.CurrentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        //    ActivateButton(button4);

        //    manage_User FRM = new manage_User();
        //    FRM.ShowDialog();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            //panel1.BackColor = Color.FromArgb(255, 230, 240, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ActivateButton(btnApp);

            //Point p = btnApp.PointToScreen(Point.Empty);
            //p.X += btnApp.Width;
            //contextMenuStrip1.Show(p);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.ShowCheckMargin = false;
            contextMenuStrip1.RenderMode = ToolStripRenderMode.Professional;


        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip2.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            contextMenuStrip2.BackColor = Color.White;
            contextMenuStrip2.ShowImageMargin = false;
            contextMenuStrip2.ShowCheckMargin = false;
            contextMenuStrip2.RenderMode = ToolStripRenderMode.Professional;

        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmMangeApplication_Types frm = new FrmMangeApplication_Types();
            frm.ShowDialog();
            frm.Activate();
            frm.Focus();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_TestTypes frm = new Manage_TestTypes();
            frm.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicanseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicesnseApplication frm = new frmAddUpdateLocalDrivingLicesnseApplication();
            frm.ShowDialog();
        }

        private void detainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Local_Driving_License_apps frm =new Frm_Local_Driving_License_apps();
            frm .ShowDialog();  

        }

        private void massageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel3.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void drivingLicennsesServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            //ActivateButton(guna2Button1_Click);

            Point p = guna2Button1.PointToScreen(Point.Empty);
            p.X += guna2Button1.Width;
            contextMenuStrip1.Show(p);
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

            //guna2GradientPanel1.FillColor = Color.FromArgb(250, 250 250);
            guna2GradientPanel1.FillColor = Color.FromArgb(245, 247, 250);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
            Form frm = new MangePeople();
            frm.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
            manage_User FRM = new manage_User();
            FRM.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Point p= guna2Button5.PointToScreen(Point.Empty);
            p.X+= guna2Button5.Width;
            contextMenuStrip2.Show(p);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmUser_Info_Form frm = new FrmUser_Info_Form(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm= new FrmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Local_Driving_License_apps frm = new Frm_Local_Driving_License_apps();
            frm.ShowDialog();
        }

        private void renewDrivingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication frm= new frmRenewLocalDrivingLicenseApplication();
            frm.ShowDialog();

        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
              frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmListDrivers frmListDrivers = new frmListDrivers();
            frmListDrivers.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm= new frmListDetainedLicenses();
                frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frm = new frmListInternationalLicesnseApplications();
            
            frm.ShowDialog();

        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frm = new frmListInternationalLicesnseApplications();

            frm.ShowDialog();

        }

        //private void btPeople_MouseEnter(object sender, EventArgs e)
        //{
        //    btPeople.BackColor = Color.FromArgb(41, 128, 185); // لون أزرق فاتح

        //}

        //private void btPeople_MouseLeave(object sender, EventArgs e)
        //{
        //    btPeople.BackColor = Color.White;
        //}





    }
}
