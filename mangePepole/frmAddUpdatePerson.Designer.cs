namespace People_Management__full_pro__1set
{
    partial class frmAddPeople3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new People_Management__full_pro__1set.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl11.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.userControl11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.ContactID = -1;
            this.userControl11.Location = new System.Drawing.Point(2, -2);
            this.userControl11.MaximumSize = new System.Drawing.Size(963, 486);
            this.userControl11.MinimumSize = new System.Drawing.Size(963, 486);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(963, 486);
            this.userControl11.TabIndex = 0;
            // 
            // frmAddPeople3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.userControl11);
            this.Name = "frmAddPeople3";
            this.Text = "frmAddPeople";
            this.Load += new System.EventHandler(this.frmAddPeople_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
    }
}