using bescnesLayer;
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


namespace People_Management__full_pro__1set.applictions
{
    public partial class UpDataApplication_Type : Form
    {
        ClsAppTypes app;

        private int _conID;
        private string _name;
        private double _Fees;
        //public UpDataApplication_Type()
        //{
        //    InitializeComponent();
        //}
        public UpDataApplication_Type(int conID, string name, double fees)
        {
            InitializeComponent();
            _conID = conID;
            _name = name;
            _Fees = fees;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UpDataApplication_Type_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;


            this.WindowState = FormWindowState.Normal;

            label3.Text= _conID.ToString();
            textBox2.Text= _name.ToString();
            textBox1.Text= _Fees.ToString();
            
        }
        public void save()
        {
            int id=_conID;
            string Title = textBox2.Text.Trim();
            double Fees = Convert.ToDouble( textBox1.Text.Trim());
          app=  ClsAppTypes.Find(id);
          
            app.ID = id;
            app.Fees = (float)Fees;
            app.Title=Title;
            try
            {
                bool success = app.Save();
                
                if (success)
                    MessageBox.Show("تم الحفظ بنجاح!");
                else
                    MessageBox.Show("لم يحدث أي تعديل. تأكد من ID");
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message);
            }
        }
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            save();
        }

        private void UpDataApplication_Type_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            save();

        }

        private void BTnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
