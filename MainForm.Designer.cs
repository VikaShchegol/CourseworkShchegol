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
            this.buttonVouchers = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вхідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реєстраціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 271);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVouchers
            // 
            this.buttonVouchers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.buttonVouchers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonVouchers.Location = new System.Drawing.Point(12, 3);
            this.buttonVouchers.Name = "buttonVouchers";
            this.buttonVouchers.Size = new System.Drawing.Size(117, 50);
            this.buttonVouchers.TabIndex = 4;
            this.buttonVouchers.Text = "Путівки";
            this.buttonVouchers.UseVisualStyleBackColor = false;
            this.buttonVouchers.Click += new System.EventHandler(this.buttonVouchers_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.BackColor = System.Drawing.Color.LightYellow;
            this.buttonServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonServices.Location = new System.Drawing.Point(355, 3);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(117, 50);
            this.buttonServices.TabIndex = 5;
            this.buttonServices.Text = "Послуги";
            this.buttonServices.UseVisualStyleBackColor = false;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(250)))), ((int)(((byte)(192)))));
            this.buttonSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonSchedule.Location = new System.Drawing.Point(156, 3);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(173, 50);
            this.buttonSchedule.TabIndex = 6;
            this.buttonSchedule.Text = "Розклад записів";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Azure;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(484, 46);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вхідToolStripMenuItem,
            this.реєстраціяToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(9, 10, 45, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(397, 32);
            this.toolStripMenuItem1.Text = "Для входу або реєстрації натисніть сюди";
            // 
            // вхідToolStripMenuItem
            // 
            this.вхідToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.вхідToolStripMenuItem.Name = "вхідToolStripMenuItem";
            this.вхідToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.вхідToolStripMenuItem.Text = "Вхід";
            this.вхідToolStripMenuItem.Click += new System.EventHandler(this.вхідToolStripMenuItem_Click);
            // 
            // реєстраціяToolStripMenuItem
            // 
            this.реєстраціяToolStripMenuItem.BackColor = System.Drawing.Color.Honeydew;
            this.реєстраціяToolStripMenuItem.Name = "реєстраціяToolStripMenuItem";
            this.реєстраціяToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.реєстраціяToolStripMenuItem.Text = "Реєстрація";
            this.реєстраціяToolStripMenuItem.Click += new System.EventHandler(this.реєстраціяToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 42);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonVouchers);
            this.panel1.Controls.Add(this.buttonSchedule);
            this.panel1.Controls.Add(this.buttonServices);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 56);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FloralWhite;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F);
            this.label1.Location = new System.Drawing.Point(34, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Гірськолижний курорт \"Карпати\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(484, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "Курорт \"Карпати\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonVouchers;
        private System.Windows.Forms.Button buttonServices;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вхідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реєстраціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
