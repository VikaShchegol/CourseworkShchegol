namespace course
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonRegist = new System.Windows.Forms.Button();
            this.buttonVouchers = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 329);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гірськолижний курорт \"Карпати\"";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.buttonLogin.Location = new System.Drawing.Point(61, 329);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(175, 45);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Увійти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonRegist
            // 
            this.buttonRegist.BackColor = System.Drawing.Color.OldLace;
            this.buttonRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.buttonRegist.Location = new System.Drawing.Point(256, 329);
            this.buttonRegist.Name = "buttonRegist";
            this.buttonRegist.Size = new System.Drawing.Size(175, 45);
            this.buttonRegist.TabIndex = 3;
            this.buttonRegist.Text = "Зареєструватись";
            this.buttonRegist.UseVisualStyleBackColor = false;
            this.buttonRegist.Click += new System.EventHandler(this.buttonRegist_Click);
            // 
            // buttonVouchers
            // 
            this.buttonVouchers.BackColor = System.Drawing.Color.LightCyan;
            this.buttonVouchers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonVouchers.Location = new System.Drawing.Point(36, 236);
            this.buttonVouchers.Name = "buttonVouchers";
            this.buttonVouchers.Size = new System.Drawing.Size(117, 50);
            this.buttonVouchers.TabIndex = 4;
            this.buttonVouchers.Text = "Путівки";
            this.buttonVouchers.UseVisualStyleBackColor = false;
            this.buttonVouchers.Click += new System.EventHandler(this.buttonVouchers_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.BackColor = System.Drawing.Color.LightCyan;
            this.buttonServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonServices.Location = new System.Drawing.Point(182, 236);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(117, 50);
            this.buttonServices.TabIndex = 5;
            this.buttonServices.Text = "Послуги";
            this.buttonServices.UseVisualStyleBackColor = false;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.LightCyan;
            this.buttonSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSchedule.Location = new System.Drawing.Point(326, 236);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(117, 50);
            this.buttonSchedule.TabIndex = 6;
            this.buttonSchedule.Text = "Розклад \r\nзаписів";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(486, 416);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonVouchers);
            this.Controls.Add(this.buttonRegist);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonRegist;
        private System.Windows.Forms.Button buttonVouchers;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonSchedule;
    }
}