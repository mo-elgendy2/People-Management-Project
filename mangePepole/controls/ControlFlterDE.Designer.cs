namespace People_Management__full_pro__1set.mangePepole.controls
{
    partial class ControlFlterDE
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbColumns = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gunabtnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userControl21 = new People_Management__full_pro__1set.UserControl2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filter By:";
            // 
            // cbColumns
            // 
            this.cbColumns.FormattingEnabled = true;
            this.cbColumns.Location = new System.Drawing.Point(107, 41);
            this.cbColumns.Name = "cbColumns";
            this.cbColumns.Size = new System.Drawing.Size(145, 24);
            this.cbColumns.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(272, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(229, 22);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Validating += new System.ComponentModel.CancelEventHandler(this.txtSearch_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gunabtnAdd);
            this.groupBox1.Controls.Add(this.guna2btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbColumns);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 84);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gunabtnAdd
            // 
            this.gunabtnAdd.AutoRoundedCorners = true;
            this.gunabtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.gunabtnAdd.BorderColor = System.Drawing.Color.Indigo;
            this.gunabtnAdd.BorderRadius = 24;
            this.gunabtnAdd.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.gunabtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gunabtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gunabtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gunabtnAdd.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gunabtnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunabtnAdd.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gunabtnAdd.Image = global::People_Management__full_pro__1set.Properties.Resources.Add_Person_40;
            this.gunabtnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.gunabtnAdd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gunabtnAdd.Location = new System.Drawing.Point(813, 21);
            this.gunabtnAdd.Name = "gunabtnAdd";
            this.gunabtnAdd.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.gunabtnAdd.Size = new System.Drawing.Size(91, 51);
            this.gunabtnAdd.TabIndex = 49;
            this.gunabtnAdd.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2btnSearch
            // 
            this.guna2btnSearch.AutoRoundedCorners = true;
            this.guna2btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.guna2btnSearch.BorderColor = System.Drawing.Color.Indigo;
            this.guna2btnSearch.BorderRadius = 24;
            this.guna2btnSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2btnSearch.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2btnSearch.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.guna2btnSearch.Image = global::People_Management__full_pro__1set.Properties.Resources.SearchPerson1;
            this.guna2btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2btnSearch.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.guna2btnSearch.Location = new System.Drawing.Point(660, 21);
            this.guna2btnSearch.Name = "guna2btnSearch";
            this.guna2btnSearch.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.guna2btnSearch.Size = new System.Drawing.Size(91, 51);
            this.guna2btnSearch.TabIndex = 48;
            this.guna2btnSearch.Click += new System.EventHandler(this.guna2Button2_Click);
            this.guna2btnSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2btnSearch_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userControl21
            // 
            this.userControl21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl21.Location = new System.Drawing.Point(5, 87);
            this.userControl21.naional_NO = "";
            this.userControl21.Name = "userControl21";
            this.userControl21.PersonId = -1;
            this.userControl21.Size = new System.Drawing.Size(1171, 345);
            this.userControl21.TabIndex = 2;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // ControlFlterDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userControl21);
            this.Name = "ControlFlterDE";
            this.Size = new System.Drawing.Size(1179, 436);
            this.Load += new System.EventHandler(this.ControlFlterDE_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlFlterDE_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserControl2 userControl21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbColumns;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button guna2btnSearch;
        private Guna.UI2.WinForms.Guna2Button gunabtnAdd;
    }
}
