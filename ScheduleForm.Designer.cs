namespace course
{
    partial class ScheduleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonLoadSchedule;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSchedule;
        private System.Windows.Forms.Button buttonBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonLoadSchedule = new System.Windows.Forms.Button();
            this.flowLayoutPanelSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(12, 12);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(216, 26);
            this.textBoxEmail.TabIndex = 0;
            this.textBoxEmail.Text = "Введіть електронну пошту";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // buttonLoadSchedule
            // 
            this.buttonLoadSchedule.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonLoadSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonLoadSchedule.Location = new System.Drawing.Point(234, 12);
            this.buttonLoadSchedule.Name = "buttonLoadSchedule";
            this.buttonLoadSchedule.Size = new System.Drawing.Size(160, 28);
            this.buttonLoadSchedule.TabIndex = 1;
            this.buttonLoadSchedule.Text = "Завантажити";
            this.buttonLoadSchedule.UseVisualStyleBackColor = false;
            this.buttonLoadSchedule.Click += new System.EventHandler(this.buttonLoadSchedule_Click);
            // 
            // flowLayoutPanelSchedule
            // 
            this.flowLayoutPanelSchedule.AutoScroll = true;
            this.flowLayoutPanelSchedule.Location = new System.Drawing.Point(12, 55);
            this.flowLayoutPanelSchedule.Name = "flowLayoutPanelSchedule";
            this.flowLayoutPanelSchedule.Size = new System.Drawing.Size(776, 279);
            this.flowLayoutPanelSchedule.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonBack.Location = new System.Drawing.Point(251, 340);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(266, 45);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Повернутись на головну ";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanelSchedule);
            this.Controls.Add(this.buttonLoadSchedule);
            this.Controls.Add(this.textBoxEmail);
            this.Name = "ScheduleForm";
            this.Text = "Розклад записів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
