namespace People_Management__full_pro__1set.mange_user
{
    partial class ctrlUserCard
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
            this.userControl21 = new People_Management__full_pro__1set.UserControl2();
            this.SuspendLayout();
            // 
            // userControl21
            // 
            this.userControl21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl21.Location = new System.Drawing.Point(20, 17);
            this.userControl21.naional_NO = "";
            this.userControl21.Name = "userControl21";
            this.userControl21.PersonId = -1;
            this.userControl21.Size = new System.Drawing.Size(1227, 353);
            this.userControl21.TabIndex = 3;
            // 
            // ctrlUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 508);
            this.Controls.Add(this.userControl21);
            this.Name = "ctrlUserCard";
            this.Text = "ctrlUserCard";
            this.Load += new System.EventHandler(this.ctrlUserCard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControl2 userControl21;
    }
}