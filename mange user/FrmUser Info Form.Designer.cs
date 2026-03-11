namespace People_Management__full_pro__1set.mange_user
{
    partial class FrmUser_Info_Form
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
            this.userCTRinfo1 = new People_Management__full_pro__1set.mange_user.userCTRinfo();
            this.BTnClose = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // userCTRinfo1
            // 
            this.userCTRinfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userCTRinfo1.Location = new System.Drawing.Point(0, 0);
            this.userCTRinfo1.Name = "userCTRinfo1";
            this.userCTRinfo1.Size = new System.Drawing.Size(1114, 461);
            this.userCTRinfo1.TabIndex = 0;
            // 
            // BTnClose
            // 
            this.BTnClose.AutoRoundedCorners = true;
            this.BTnClose.BackColor = System.Drawing.Color.White;
            this.BTnClose.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTnClose.BorderRadius = 23;
            this.BTnClose.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.BTnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTnClose.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.BTnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTnClose.Image = global::People_Management__full_pro__1set.Properties.Resources.close__1_;
            this.BTnClose.ImageSize = new System.Drawing.Size(40, 40);
            this.BTnClose.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BTnClose.Location = new System.Drawing.Point(1007, 481);
            this.BTnClose.Name = "BTnClose";
            this.BTnClose.PressedColor = System.Drawing.Color.Cornsilk;
            this.BTnClose.Size = new System.Drawing.Size(133, 49);
            this.BTnClose.TabIndex = 20;
            this.BTnClose.Text = "Close";
            this.BTnClose.Click += new System.EventHandler(this.BTnClose_Click);
            // 
            // FrmUser_Info_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1152, 527);
            this.Controls.Add(this.BTnClose);
            this.Controls.Add(this.userCTRinfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUser_Info_Form";
            this.Text = "FrmUser_Info_Form";
            this.Load += new System.EventHandler(this.FrmUser_Info_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private userCTRinfo userCTRinfo1;
        private Guna.UI2.WinForms.Guna2Button BTnClose;
    }
}