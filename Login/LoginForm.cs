using bescnesLayer.BusinessLayer;
using DVLD.Classes;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace People_Management__full_pro__1set
{
    public partial class LoginForm : Form
    {

        //string usersFile = "MYfile.txt";
        //string rememberFile = "remember.txt";
        //int attempts = 0;
        //const int maxAttempts = 3;

        //void rememper()
        //{
        //    string x1, x2;
        //    x1 = textUser.Text.ToString();
        //    x2 = textPAss.Text.ToString();
        //    string save = rememberFile;
        //    string content = x1 + Environment.NewLine + x2;

        //    System.IO.File.WriteAllText(save, content);



        //}
        //void RememberUser()
        //{
        //    if (radioButton1.Checked)
        //    {
        //        string user = textUser.Text.Trim();
        //        string pass = textPAss.Text.Trim();
        //        string content = user + Environment.NewLine + pass;
        //        System.IO.File.WriteAllText(rememberFile, content);
        //    }
        //    else
        //    {
        //        // لو مش عايز يتذكره نحذف الملف
        //        if (System.IO.File.Exists(rememberFile))
        //            System.IO.File.Delete(rememberFile);
        //    }
        //}

        //void LoadRememberedUser()
        //{
        //    if (System.IO.File.Exists(rememberFile))
        //    {
        //        string[] lines = System.IO.File.ReadAllLines(rememberFile);
        //        if (lines.Length >= 2)
        //        {
        //            textUser.Text = lines[0];
        //            textPAss.Text = lines[1];
        //            radioButton1.Checked = true;
        //        }
        //    }
        //}



        //void CreateUserFileIfNotExists()//// تجربه  
        //{
        //    string path = "MYfile.txt";

        //    if (!System.IO.File.Exists(path))
        //    {
        //        // إضافة مستخدم افتراضي
        //        string defaultUser = "Username: admin, Password: 1234";
        //        System.IO.File.WriteAllText(path, defaultUser);
        //    }
        //}


        public LoginForm()
        {
            InitializeComponent();
        }

        //bool findUser(string username, string Password)
        //{
        //    string filePath = usersFile;
        //    if (!System.IO.File.Exists(filePath))
        //        return false;

        //    string[] lines = System.IO.File.ReadAllLines(filePath);

        //    foreach (var l in lines)
        //    {
        //        if (l.Trim() == $"Username: {username}, Password: {Password}")

        //        //if (l.StartsWith($"UserName:{username},Password{Password}"))
        //        {
        //            return true;

        //        }
        //    }

        //    return false;

        //}
        //void WriteUserInfo(string username, string password)
        //{
        //    FileStream Myfile = new FileStream(usersFile, FileMode.Append, FileAccess.Write);
        //    //            StreamReader reader = new StreamReader(Myfile);

        //    string data = $"Username: {username}, Password: {password}\n";
        //    byte[] byteData = Encoding.UTF8.GetBytes(data); // هذا هو التعريف مهم

        //    Myfile.Seek(0, SeekOrigin.End);
        //    Myfile.Write(byteData, 0, byteData.Length);




        //}
        //void loadUserInfo(string username, string password)
        //{
        //    string[] users = System.IO.File.ReadAllLines("MYfile.txt");




        //}
        //bool Checklogin(string username, string password)
        //{

        //    return findUser(username, password);

        //}

        //void login()
        //{
        //    bool loginSuccess = true;

        //    string userName = textUser.Text.Trim();
        //    string Password = textPAss.Text.Trim();
        //    loginSuccess = Checklogin(userName, Password);

        //    if (!loginSuccess)
        //    {
        //        attempts++;

        //        int remaining = maxAttempts - attempts;

        //        lblAttempts.Text = $"Attempts Left: {remaining}";

        //        MessageBox.Show("❌ The username or password is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        if (attempts >= maxAttempts)
        //        {
        //            MessageBox.Show("Too many failed attempts. The app will now close.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            Application.Exit();
        //        }

        //        textUser.Clear();
        //        textPAss.Clear();
        //        textUser.Focus();

        //        return;
        //    }

        //    // نجاح الدخول
        //    MessageBox.Show("✅ Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    Form1 form1 = new Form1();
        //    form1.ShowDialog();
        //    this.Hide();
        //    this.Close();
        //}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RememberUser();
            //login();


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            string Username = "", pasworrd = "";
            if (clsGlobal.GetStoredCredential(ref Username, ref pasworrd))
            {
                textUser.Text = Username;
                textPAss.Text = pasworrd;
                checkBox2.Checked = true;
            }

            else { 
            checkBox2.Checked=false;
            }
            textPAss.UseSystemPasswordChar = true;

            //LoadRememberedUser();
            //CreateUserFileIfNotExists();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(190, 0, 0, 0);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //textPAss.UseSystemPasswordChar = !checkBox1.Checked;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit()
;
            this.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(60, 0, 0, 0);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindByUserName(textUser.Text.Trim(), textPAss.Text.Trim());

            if (user != null)
            {
                if (checkBox2.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(textUser.Text.Trim(), textPAss.Text.Trim());
                }

                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!user.IsActive)
                {
                    textUser.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                clsGlobal.CurrentUser = user;
                this.Hide();
                Form1 frm = new Form1(this);
                frm.ShowDialog();
            }
            else
            {
                textUser.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


                //    RememberUser();
                //login();

            }
        
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
         

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
