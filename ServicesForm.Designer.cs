namespace course
{
    partial class ServicesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelServices;
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
            this.flowLayoutPanelServices = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelServices
            // 
            this.flowLayoutPanelServices.AutoScroll = true;
            this.flowLayoutPanelServices.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanelServices.Name = "flowLayoutPanelServices";
            this.flowLayoutPanelServices.Size = new System.Drawing.Size(776, 351);
            this.flowLayoutPanelServices.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonBack.Location = new System.Drawing.Point(243, 382);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(312, 56);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Повернутись на головну";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ServicesForm
            // 
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.flowLayoutPanelServices);
            this.Name = "ServicesForm";
            this.Text = "Перегляд послуг";
            this.ResumeLayout(false);

        }
    }
}
