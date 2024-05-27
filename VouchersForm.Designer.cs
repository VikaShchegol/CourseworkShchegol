namespace course
{
    partial class VouchersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVouchers;
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
            this.flowLayoutPanelVouchers = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelVouchers
            // 
            this.flowLayoutPanelVouchers.AutoScroll = true;
            this.flowLayoutPanelVouchers.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelVouchers.Name = "flowLayoutPanelVouchers";
            this.flowLayoutPanelVouchers.Size = new System.Drawing.Size(776, 354);
            this.flowLayoutPanelVouchers.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Lavender;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonBack.Location = new System.Drawing.Point(276, 384);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(257, 54);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Повернутись на головну";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // VouchersForm
            // 
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanelVouchers);
            this.Name = "VouchersForm";
            this.Text = "Перегляд путівок";
            this.ResumeLayout(false);

        }
    }
}
