namespace People_Management__full_pro__1set
{
    partial class FrmDetales
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
            this.components = new System.ComponentModel.Container();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.userControl11 = new People_Management__full_pro__1set.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.ContactID = -1;
            this.userControl11.Location = new System.Drawing.Point(7, 13);
            this.userControl11.MaximumSize = new System.Drawing.Size(963, 486);
            this.userControl11.MinimumSize = new System.Drawing.Size(963, 486);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(963, 486);
            this.userControl11.TabIndex = 2;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load_1);
            // 
            // FrmDetales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 505);
            this.Controls.Add(this.userControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDetales";
            this.Padding = new System.Windows.Forms.Padding(100);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Details";
            this.Load += new System.EventHandler(this.FrmDetales_Load);
            this.ResumeLayout(false);

        }

        #endregion
        //private UserControl1 userControl11;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private UserControl1 userControl11;
    }
}