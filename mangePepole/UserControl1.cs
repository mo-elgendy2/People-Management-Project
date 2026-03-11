using bescnesLayer;
using BusinessLayer;
using People_Management__full_pro__1set.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace People_Management__full_pro__1set
{
    public partial class UserControl1 : UserControl

    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack; 
        private int _Contactid = -1;
        clsContact _Contact;
        public enum EnMode { Add = 0, UpDate = 1 };
        private EnMode _Mode;

        //// في ControlFlterDE
        //public UserControl1 PersonCardControl
        //{
        //    get { return UserControl1; } // userControl21 هو الكنترول الداخلي
        //}

      


        void RestDefualtValyous()
        {



            if (_Mode == EnMode.Add)
            {
                label11.Text = "Add Person";
                _Contact = new clsContact();
                _fillCountryCopoBox();

                //return;
            }





        }

        public UserControl1()
        {
            InitializeComponent();

            StyleGunaCloseButton(guna2Button1);
            StyleGunaCloseButton(guna2Button2);



            //_Mode = EnMode.Add;
            _Contactid = -1;
            //RestDefualtValyous();
            //return;

        }

        //public UserControl1(int Contactid)
        //{
        //    InitializeComponent();
        //    _Contactid = Contactid;

        //    if (Contactid == -1)
        //    {
        //        _Mode
        //            = EnMode.Add;

        //        return;
        //    }
        //    _Mode = EnMode.UpDate;


        //}
        public int ContactID
        {
            get { return _Contactid; }
            set
            {
                _Contactid = value;
                _Mode = (_Contactid == -1) ? EnMode.Add : EnMode.UpDate;

                if (_Mode == EnMode.UpDate)
                    LoadData();
                else
                    RestDefualtValyous();
            }
        }



        private void _fillCountryCopoBox()
        {

            DataTable dt = clsContact.GetAllCountries();
            //foreach ( DataRow c in dt.Rows ) 
            //{
            //    comboBox1.Items.Add(c["CountryName"]);


            //}
            //comboBox1.SelectedIndex = 50;
            //comboBox1.DisplayMember = "CountryName";        // اسم الدولة اللي يظهر
            //comboBox1.ValueMember = "CountryID";            // القيمة المرتبطة (هتستخدمها في الحفظ)
            //comboBox1.DataSource = dt;
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CountryName";
            comboBox1.ValueMember = "CountryID";
            comboBox1.SelectedIndex = 50;

        }
        private void LoadGender()
        {
            if (_Contact.Gendor == 1)
            {
                radioButtonFemale.Checked = true;
            }
            else if (_Contact.Gendor == 0)
            {
                radioButtonman.Checked = true;
            }

        }

        //private int GetSelectedGenderdor()
        //{


        //    //var gendor = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        //    ////var selectedRadio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
        //    ////if (gendor != null)
        //    ////    return gendor;
        //    ////else
        //    ////    return null; // أو قيمة افتراضية زي "غير محدد"
        //    //return gendor?.Tag?.ToString();
        private int GetSelectedGender()
        {
            var selectedRadio = groupBox1.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (selectedRadio != null && selectedRadio != null)
            {
                return Convert.ToInt32(selectedRadio);
            }

            return -1;
        }



        private byte GetSelectedGenderAsByte()
        {
            if (radioButtonman.Checked)
                return 0;
            else if (radioButtonFemale.Checked)
                return 1;
            else
                return 255; // كشف الخطأ 
        }



        public void LoadPerson(int Personid)//update
        {


            _Contact = clsContact.Find(Personid);
            //label11.Text = "add Person";

            _Mode = EnMode.UpDate;


            label13.Text = _Contactid.ToString();
            //_Contact = new clsContact();
            //return;

            if (_Contact == null)
            {
                MessageBox.Show("This form will be  add Person Mode because No Person with ID = " + _Contactid);

                //_Contact = new clsContact();
                this.FindForm()?.Close();
                return;
            }

            _Contactid = Personid; // to save me


            label11.Text = "Edit Person ID " + _Contactid;

            textBox1.Text = _Contact.FirstName;
            textBox2.Text = _Contact.SecondName;
            textBox3.Text = _Contact.ThirdName;
            textBox4.Text = _Contact.LastName;
            textBox5.Text = _Contact.NationalNo;
            textBox6.Text = _Contact.Email;
            textBox7.Text = _Contact.Address;
            textBox8.Text = _Contact.Phone;
            label13.Text = _Contact.ID.ToString();
            dateTimePicker1.Value = _Contact.DateOfBirth;
            comboBox1.SelectedValue = _Contact.CountryID;

            MessageBox.Show("Loading from: " + _Contact.ImagePath);
            if (_Contact.ImagePath != "")
            {
                pictureBox1.ImageLocation = _Contact.ImagePath;

            }
            // مرفوعه الصورة
            //if (!string.IsNullOrEmpty(_Contact.ImagePath) && File.Exists(_Contact.ImagePath))
            //{
            //    pictureBox1.Load(_Contact.ImagePath);
            //    linkLabel1.Visible = true;
            //}
            //else
            //{
            //    pictureBox1.Image = null;
            //    //linkLabel2.Visible = false;
            //}
            if (_Contact.Gendor == 0)
            {
                radioButtonman.Checked = true;

            }
            else radioButtonFemale.Checked = true;

            _Contact.ID = Personid;




            //    if (_Contact.Gendor == 0)
            //    {
            //        radioButtonman.Checked = true;

            //    }
            //    else if (_Contact.Gendor == 1)
            //        radioButtonFemale.Checked = true;

        }





        private DateTime BirhtofDate()
        {
            //DateTime SLD = dateTimePicker1.Value;
            //dateTimePicker1.MaxDate = new DateTime(2008, 1, 1);

            return dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);


        }

        //private PictureBox SaveImage(PictureBox pictureBox1)
        //{

        //    string OldImagePath = _Contact.ImagePath;
        //    // تأكد إن فيه صورة أصلًا محمّلة
        //    if (pictureBox1.Image == null || string.IsNullOrEmpty(pictureBox1.ImageLocation))
        //    {
        //        MessageBox.Show("There is no image to save.");


        //    }

        //    string folderSave = @"D:\People";

        //    // أنشئ المجلد إذا لم يكن موجودًا
        //    if (!Directory.Exists(folderSave))
        //    {
        //        Directory.CreateDirectory(folderSave);
        //    }

        //    string oldImagePath=_Contact.ImagePath;


        //    try
        //    {
        //        if (oldImagePath != null && File.Exists(oldImagePath))
        //        {

        //            if (pictureBox1.Image != null)
        //            {
        //                //pictureBox1.Image.Dispose(); هيرمي اكسبشن
        //                pictureBox1.Image = null;
        //                GC.Collect();
        //                GC.WaitForPendingFinalizers();

        //            }

        //            bool isNewImage = pictureBox1.ImageLocation != oldImagePath;

        //            if (isNewImage)
        //            {
        //                // احفظ الصورة الجديدة
        //                pictureBox1.Image.Save(folderSave);

        //                // لو قديمة موجودة.. احذفها
        //                if (!string.IsNullOrEmpty(oldImagePath) && File.Exists(oldImagePath))
        //                {
        //                    File.Delete(oldImagePath);
        //                }
        //            }


        //        }
        //        // اسم فريد للصورة باستخدام Guid (لتفادي تكرار الأسماء)
        //        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(pictureBox1.ImageLocation);

        //        // المسار الجديد لحفظ الصورة
        //        string newFilePath = Path.Combine(folderSave, fileName);

        //        // انسخ الصورة من مكانها الحالي إلى مجلد الحفظ
        //        File.Copy(pictureBox1.ImageLocation, newFilePath, true);

        //        // حدث مسار الصورة في PictureBox
        //        pictureBox1.ImageLocation = newFilePath;


        //        // اربط المسار بالكائن _Contact
        //        _Contact.ImagePath = newFilePath;
        //        //if (_Contact.ImagePath != null && File.Exists(_Contact.ImagePath))
        //        //{

        //        //    if (pictureBox1.Image != null)
        //        //    {
        //        //        pictureBox1.Image.Dispose();
        //        //        pictureBox1.Image = null;

        //        //    }
        //        //    File.Delete(_Contact.ImagePath);


        //        //}



        //        MessageBox.Show("✅ Image saved successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while saving the image: " + ex.Message);
        //    }

        //    return pictureBox1;
        //}
        private string SaveImagePro(PictureBox pic, string oldImagePath,string folder)
        {
            // لو مفيش صورة
            if (pic.Image == null || string.IsNullOrEmpty(pic.ImageLocation))
                return oldImagePath;

           
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            string newImageLocation = pic.ImageLocation;

            // 1- لو الصورة لم تتغير → ارجع القديمة زي ما هي
            if (oldImagePath == newImageLocation)
                return oldImagePath;

            // 2- لو الصورة تغيرت → احفظ الجديدة
            string newFileName = Guid.NewGuid().ToString() + Path.GetExtension(newImageLocation);
            string newPath = Path.Combine(folder, newFileName);

            File.Copy(newImageLocation, newPath, true);

            // 3- احذف القديمة لو موجودة
            if (!string.IsNullOrEmpty(oldImagePath) && File.Exists(oldImagePath))
            {
                try
                {
                    File.Delete(oldImagePath);
                }
                catch { }
            }

            return newPath;
        }



        public void LoadData()
        {
            _fillCountryCopoBox();

            LoadPerson(_Contactid);


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void ApplyStyle(Guna.UI2.WinForms.Guna2Button btn)
        {
            btn.AutoRoundedCorners = true;
            btn.BorderRadius = 12;

            btn.FillColor = Color.FromArgb(230, 240, 255);
            btn.ForeColor = Color.FromArgb(40, 40, 40);

            btn.BorderThickness = 1;
            btn.BorderColor = Color.FromArgb(180, 200, 255);

            btn.HoverState.FillColor = Color.FromArgb(210, 225, 255);
            btn.HoverState.ForeColor = Color.Black;

            btn.ShadowDecoration.Enabled = true;
            btn.ShadowDecoration.BorderRadius = 30;
            btn.ShadowDecoration.Depth = 10;
            btn.ShadowDecoration.Shadow = new Padding(0, 2, 6, 6);
        }



        void AC() //تجميع button
        {

            ApplyStyle(guna2Button2);
            ApplyStyle(guna2Button1);
        }

        void dateTime()
        {
            
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker1.MinDate = DateTime.Now.AddYears(-120);

            dateTimePicker1.Value = dateTimePicker1.MaxDate;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            //this.AutoValidate = AutoValidate.EnablePreventFocusChange;

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            dateTime();
            AC();
            if (_Mode == EnMode.Add)
            {
                RestDefualtValyous();
            }

            if (_Mode == EnMode.UpDate)
            {
                LoadData();

            }
            //guna2Button2.CausesValidation = true;

            //textBox1.CausesValidation = true;
            //textBox2.CausesValidation = true;
            //textBox3.CausesValidation = true;
            //textBox4.CausesValidation = true;
            //textBox5.CausesValidation = true;
            //textBox6.CausesValidation = true;
            //textBox7.CausesValidation = true;
            //textBox8.CausesValidation = true;
            //comboBox1.CausesValidation = true;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedValue != null)
            //{
            //    int countryID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Please select a country first.");
            //}
            //byte gender = GetSelectedGenderAsByte();
            //if (gender == 255)
            //{
            //    MessageBox.Show("❌ Please select the gender (Male or Female).");
            //    return;
            //}
            //_Contact.Gendor = gender;



            //_Contact.FirstName = textBox1.Text.Trim();
            //_Contact.SecondName = textBox2.Text.Trim();
            //_Contact.ThirdName = textBox3.Text.Trim();
            //_Contact.LastName = textBox4.Text.Trim();
            //_Contact.NationalNo = textBox5.Text.Trim();
            //_Contact.Email = textBox6.Text.Trim();
            //_Contact.Address = textBox7.Text.Trim();
            //_Contact.Phone = textBox8.Text.Trim();



            ////_Contact.Gendor = GetSelectedGenderAsByte();
            //_Contact.DateOfBirth = dateTimePicker1.Value;
            //_Contact.CountryID = Convert.ToInt32(comboBox1.SelectedValue);
            ////SaveImage(pictureBox1);


            ////if (_Contact.Save())
            ////    MessageBox.Show("Data Saved Successfully.");
            ////else
            ////    MessageBox.Show("Error: Data Is not Saved Successfully.");

            //// حفظ الصورة فقط لو تم اختيارها من الجهاز (مش من Resources)
            //if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
            //{
            //    string newImagePath = SaveImagePro(pictureBox1, _Contact.ImagePath);

            //    _Contact.ImagePath = newImagePath;

            //}
            //else
            //{
            //    // لو الصورة من الريسورس
            //    _Contact.ImagePath = null;
            //}

            //// محاولة حفظ البيانات
            //bool result = _Contact.Save();
            //try
            //{

            //    if (result)
            //    {
            //        MessageBox.Show("✅ Data has been saved successfully.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("❌ Data was not saved. Check the code.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("❌ حدث خطأ أثناء الحفظ:\n" + ex.Message);
            //}

            //if (result)  // بعد _Contact.Save()
            //{
            //    _Mode = EnMode.UpDate;
            //    label11.Text = "Edit Contact ID = " + _Contact.ID;
            //    label13.Text = _Contact.ID.ToString();

            //}
        }
        private void Save()
        {
            // 1️⃣ التأكد من اختيار الدولة
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a country first.");
                return;
            }

            // 2️⃣ التأكد من اختيار الجنس
            byte gender = GetSelectedGenderAsByte();
            if (gender == 255)
            {
                MessageBox.Show("❌ Please select the gender (Male or Female).");
                return;
            }
            _Contact.Gendor = gender;

            // 3️⃣ التأكد من تعبئة الحقول النصية
            System.Windows.Forms.TextBox[] boxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };
            foreach (var tb in boxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    MessageBox.Show($"❌ Please fill the field: {tb.Name}");
                    tb.Focus();
                    return;
                }
            }

            //  تحديث بيانات _Contact
            _Contact.FirstName = textBox1.Text.Trim();
            _Contact.SecondName = textBox2.Text.Trim();
            _Contact.ThirdName = textBox3.Text.Trim();
            _Contact.LastName = textBox4.Text.Trim();
            _Contact.NationalNo = textBox5.Text.Trim();
            _Contact.Email = textBox6.Text.Trim();
            _Contact.Address = textBox7.Text.Trim();
            _Contact.Phone = textBox8.Text.Trim();
            _Contact.DateOfBirth = dateTimePicker1.Value;
            _Contact.CountryID = Convert.ToInt32(comboBox1.SelectedValue);

            // 5️⃣ حفظ الصورة
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                _Contact.ImagePath = SaveImagePro(pictureBox1, _Contact.ImagePath, @"D:\People");
            else
                _Contact.ImagePath = null;

     
            bool result;
            try
            {
                result = _Contact.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ حدث خطأ أثناء الحفظ:\n" + ex.Message);
                return;
            }

    
            if (!result)
            {
                MessageBox.Show("❌ Data was not saved. Check the code.");
                return; 
            }

            //if (_Mode == EnMode.Add)
            //{
            //    _Mode = EnMode.UpDate;
                _Contactid = _Contact.ID; // تخزين الرقم الجديد
            //}

            label11.Text = "Edit Contact ID = " + _Contact.ID;
            label13.Text = _Contact.ID.ToString();
            MessageBox.Show("✅ Data has been saved successfully.");
        }






        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "select image";
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string select = openFileDialog1.FileName;
                MessageBox.Show("Selected Image is:" + select);

                pictureBox1.Load(select);

            }


        }

        public void delete()
        {
            try
            {
                string imagePath = _Contact.ImagePath;

                // تأكد إن الصورة موجودة
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    // فك ارتباط PictureBox بالصورة لو كانت معروضة
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;

                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                    }

                    // حذف الملف من القرص
                    File.Delete(imagePath);
                    _Contact.ImagePath = null;

                    MessageBox.Show("✅ تم حذف الصورة من القرص بنجاح.");
                }
                else
                {
                    MessageBox.Show("❌ الصورة غير موجودة على القرص.");
                }

                pictureBox1.ImageLocation = null;
                if (radioButtonman.Checked)
                {
                    pictureBox1.Image = Resources.Male_512;
                }
                else if (radioButtonFemale.Checked)
                {
                    pictureBox1.Image = Resources.admin_female;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ خطأ أثناء حذف الصورة:\n" + ex.Message);
            }
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            delete();

            linkLabel2.Visible = true;
        }

        private void radioButtonman_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.librarian1;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.admin_female;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "First Name is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNotEmpty(textBox2.Text))
            {
                e.Cancel = true;
                //textBox2.Focus();
                errorProvider1.SetError(textBox2, " Name is required\"");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNotEmpty(textBox3.Text))
            {
                e.Cancel = true;
                //textBox3.Focus();
                errorProvider1.SetError(textBox3, "  Name is required\"");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");

            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNotEmpty(textBox4.Text))
            {
                e.Cancel = true;
                //textBox4.Focus();
                errorProvider1.SetError(textBox4, "  Name is required\"");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox4, "");

            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNotEmpty(textBox5.Text))
            {
                e.Cancel = true;
          
                errorProvider1.SetError(textBox5, " shoud A ....");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox5, "");

            }
            if (textBox5.Text.Trim() != _Contact.NationalNo && clsContact.isPepoleEXsist(textBox5.Text.Trim()))
            {
                e.Cancel = true;
              
                errorProvider1.SetError(textBox5, "National Number IS Used for Another one");
            }
            else { errorProvider1.SetError(textBox5, null); }

        }
        //private void textBox5_Validating(object sender, CancelEventArgs e)
        //{
        //    bool hasError = false;
        //    string value = textBox5.Text.Trim();

        //    // 1) الخانة فاضية؟
        //    if (string.IsNullOrWhiteSpace(value))
        //    {
        //        hasError = true;
        //        errorProvider1.SetError(textBox5, "National Number is required");
        //    }

        //    // 2) الفارمات غلط (طول – حروف – مش 14 رقم)
        //    if (!hasError)
        //    {
        //        if (!clsValidation.IsNationalNoValid(value, _Contact.NationalNo))
        //        {
        //            hasError = true;
        //            errorProvider1.SetError(textBox5, "National Number is not valid");
        //        }
        //    }

        //    // 3) الرقم مستخدم لشخص آخر (لو مش هو الرقم القديم)
        //    if (!hasError)
        //    {
        //        if (value != _Contact.NationalNo && clsContact.isPepoleEXsist(value))
        //        {
        //            hasError = true;
        //            errorProvider1.SetError(textBox5, "National Number is used for another person");
        //        }
        //    }

        //    // 4) كله تمام
        //    if (!hasError)
        //    {
        //        errorProvider1.SetError(textBox5, "");
        //    }

        //    e.Cancel = hasError;
        //}

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsValidEmail(textBox6.Text))
            {


                e.Cancel = true;
                //textBox6.Focus();
                errorProvider1.SetError(textBox6, " shoud A  value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox6, "");

            }
        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidation.IsNotEmpty(textBox7.Text))
            {
                e.Cancel = true;
                //textBox7.Focus();
                errorProvider1.SetError(textBox7, " shoud A  value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox7, "");

            }
        }

        private void textBox8_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox8.Text))
            {
                e.Cancel = true;
                //textBox8.Focus();
                errorProvider1.SetError(textBox8, " shoud A  value");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox8, "");

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            //dateTimePicker1.Value = dateTimePicker1.MaxDate;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; // أو "yyyy-MM-dd" حسب اللي تحبه


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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


        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                errorProvider1.SetError(comboBox1, "Required");
                e.Cancel = true; // يمنع الخروج من الخانة
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ApplyStyle(guna2Button2);



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Save();
            if (!this.ValidateChildren())
                return;

            //int NationalnoID=clsContact.Find()

            //if (comboBox1.SelectedValue != null)
            //{
            //    int countryID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Please select a country first.");
            //}
            byte gender = GetSelectedGenderAsByte();
            if (gender == 255)
            {
                MessageBox.Show("❌ Please select the gender (Male or Female).");
                return;
            }
            _Contact.Gendor = gender;



            _Contact.FirstName = textBox1.Text.Trim();
            _Contact.SecondName = textBox2.Text.Trim();
            _Contact.ThirdName = textBox3.Text.Trim();
            _Contact.LastName = textBox4.Text.Trim();
            _Contact.NationalNo = textBox5.Text.Trim();
            _Contact.Email = textBox6.Text.Trim();
            _Contact.Address = textBox7.Text.Trim();
            _Contact.Phone = textBox8.Text.Trim();



            //_Contact.Gendor = GetSelectedGenderAsByte();
            _Contact.DateOfBirth = dateTimePicker1.Value;
            _Contact.CountryID = Convert.ToInt32(comboBox1.SelectedValue);
          

            // حفظ الصورة فقط لو تم اختيارها من الجهاز (مش من Resources)
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
            {
                string newImagePath = SaveImagePro(pictureBox1, _Contact.ImagePath, @"D:\People");

                _Contact.ImagePath = newImagePath;

            }
            else
            {
                // لو الصورة من الريسورس
                _Contact.ImagePath = null;
            }

            // محاولة حفظ البيانات
            bool result = _Contact.Save();
            try
            {

                if (result)
                {
                    MessageBox.Show("✅ Data has been saved successfully.");
                    DataBack?.Invoke(this, _Contact.ID);
                }
                else
                {
                    MessageBox.Show("❌ Data was not saved. Check the code.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ حدث خطأ أثناء الحفظ:\n" + ex.Message);
            }

            if (result)  // بعد _Contact.Save()
            {
                _Mode = EnMode.UpDate;
                label11.Text = "Edit Contact ID = " + _Contact.ID;
                label13.Text = _Contact.ID.ToString();

            }
        }

        private void guna2Button2_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_CausesValidationChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
