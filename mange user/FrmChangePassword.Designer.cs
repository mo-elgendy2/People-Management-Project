namespace People_Management__full_pro__1set.mange_user
{
    partial class FrmChangePassword
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
            this.txtREPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.TXTCRnPass = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.Label();
            this.ConfimPAss = new System.Windows.Forms.Label();
            this.CrnPass = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BTNSave = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.userCTRinfo1 = new People_Management__full_pro__1set.mange_user.userCTRinfo();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtREPass
            // 
            this.txtREPass.Location = new System.Drawing.Point(404, 607);
            this.txtREPass.Name = "txtREPass";
            this.txtREPass.Size = new System.Drawing.Size(306, 22);
            this.txtREPass.TabIndex = 24;
            this.txtREPass.TextChanged += new System.EventHandler(this.txtREPass_TextChanged);
            this.txtREPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtREPass_Validating);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(404, 561);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(306, 22);
            this.txtPass.TabIndex = 23;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // TXTCRnPass
            // 
            this.TXTCRnPass.Location = new System.Drawing.Point(404, 515);
            this.TXTCRnPass.Name = "TXTCRnPass";
            this.TXTCRnPass.Size = new System.Drawing.Size(306, 22);
            this.TXTCRnPass.TabIndex = 22;
            this.TXTCRnPass.TextChanged += new System.EventHandler(this.TXTName_TextChanged);
            this.TXTCRnPass.Validating += new System.ComponentModel.CancelEventHandler(this.TXTCRnPass_Validating);
            // 
            // NewPass
            // 
            this.NewPass.AutoSize = true;
            this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.Location = new System.Drawing.Point(100, 561);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(209, 29);
            this.NewPass.TabIndex = 18;
            this.NewPass.Text = " New Password:";
            this.NewPass.Click += new System.EventHandler(this.label5_Click);
            // 
            // ConfimPAss
            // 
            this.ConfimPAss.AutoSize = true;
            this.ConfimPAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfimPAss.Location = new System.Drawing.Point(78, 607);
            this.ConfimPAss.Name = "ConfimPAss";
            this.ConfimPAss.Size = new System.Drawing.Size(235, 29);
            this.ConfimPAss.TabIndex = 17;
            this.ConfimPAss.Text = "Confim Password:";
            this.ConfimPAss.Click += new System.EventHandler(this.label4_Click);
            // 
            // CrnPass
            // 
            this.CrnPass.AutoSize = true;
            this.CrnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrnPass.Location = new System.Drawing.Point(71, 515);
            this.CrnPass.Name = "CrnPass";
            this.CrnPass.Size = new System.Drawing.Size(238, 29);
            this.CrnPass.TabIndex = 16;
            this.CrnPass.Text = "Current Password:";
            this.CrnPass.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BTnClose
            // 
            this.BTnClose.AutoRoundedCorners = true;
            this.BTnClose.BackColor = System.Drawing.Color.White;
            this.BTnClose.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTnClose.BorderRadius = 23;
            this.BTnClose.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.BTnClose.CausesValidation = false;
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
            this.BTnClose.Location = new System.Drawing.Point(816, 661);
            this.BTnClose.Name = "BTnClose";
            this.BTnClose.PressedColor = System.Drawing.Color.Cornsilk;
            this.BTnClose.Size = new System.Drawing.Size(133, 49);
            this.BTnClose.TabIndex = 27;
            this.BTnClose.Text = "Close";
            this.BTnClose.Click += new System.EventHandler(this.BTnClose_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.AutoRoundedCorners = true;
            this.BTNSave.BackColor = System.Drawing.Color.White;
            this.BTNSave.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTNSave.BorderRadius = 23;
            this.BTNSave.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.BTNSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNSave.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.BTNSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNSave.Image = global::People_Management__full_pro__1set.Properties.Resources.ApplicationTitle;
            this.BTNSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BTNSave.ImageSize = new System.Drawing.Size(40, 40);
            this.BTNSave.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BTNSave.Location = new System.Drawing.Point(969, 661);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.PressedColor = System.Drawing.Color.Cornsilk;
            this.BTNSave.Size = new System.Drawing.Size(133, 49);
            this.BTNSave.TabIndex = 26;
            this.BTNSave.Text = "Save";
            this.BTNSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::People_Management__full_pro__1set.Properties.Resources.Password_32;
            this.label9.Location = new System.Drawing.Point(334, 607);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 36);
            this.label9.TabIndex = 21;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = global::People_Management__full_pro__1set.Properties.Resources.Person_32;
            this.label8.Location = new System.Drawing.Point(334, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 36);
            this.label8.TabIndex = 20;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::People_Management__full_pro__1set.Properties.Resources.Password_32;
            this.label10.Location = new System.Drawing.Point(334, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 36);
            this.label10.TabIndex = 19;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // userCTRinfo1
            // 
            this.userCTRinfo1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.userCTRinfo1.Location = new System.Drawing.Point(-3, -6);
            this.userCTRinfo1.Name = "userCTRinfo1";
            this.userCTRinfo1.Size = new System.Drawing.Size(1138, 469);
            this.userCTRinfo1.TabIndex = 25;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.BorderColor = System.Drawing.Color.Blue;
            this.guna2ControlBox1.BorderRadius = 2;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.LightSteelBlue;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1104, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(31, 23);
            this.guna2ControlBox1.TabIndex = 28;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 722);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.BTnClose);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.userCTRinfo1);
            this.Controls.Add(this.txtREPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.TXTCRnPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.ConfimPAss);
            this.Controls.Add(this.CrnPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtREPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox TXTCRnPass;
        private System.Windows.Forms.Label NewPass;
        private System.Windows.Forms.Label ConfimPAss;
        private System.Windows.Forms.Label CrnPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private userCTRinfo userCTRinfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button BTNSave;
        private Guna.UI2.WinForms.Guna2Button BTnClose;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}