namespace course
{
    partial class EmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServiceDescription = new System.Windows.Forms.TextBox();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.textBoxTourName = new System.Windows.Forms.TextBox();
            this.textBoxTourDescription = new System.Windows.Forms.TextBox();
            this.textBoxTourPrice = new System.Windows.Forms.TextBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.buttonAddTour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть дані для послуги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(401, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть дані для путівки";
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxServiceName.Location = new System.Drawing.Point(153, 77);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(160, 26);
            this.textBoxServiceName.TabIndex = 2;
            // 
            // textBoxServiceDescription
            // 
            this.textBoxServiceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxServiceDescription.Location = new System.Drawing.Point(153, 130);
            this.textBoxServiceDescription.Name = "textBoxServiceDescription";
            this.textBoxServiceDescription.Size = new System.Drawing.Size(160, 26);
            this.textBoxServiceDescription.TabIndex = 3;
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxServicePrice.Location = new System.Drawing.Point(153, 179);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(160, 26);
            this.textBoxServicePrice.TabIndex = 4;
            // 
            // textBoxTourName
            // 
            this.textBoxTourName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxTourName.Location = new System.Drawing.Point(499, 77);
            this.textBoxTourName.Name = "textBoxTourName";
            this.textBoxTourName.Size = new System.Drawing.Size(160, 26);
            this.textBoxTourName.TabIndex = 5;
            // 
            // textBoxTourDescription
            // 
            this.textBoxTourDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxTourDescription.Location = new System.Drawing.Point(499, 130);
            this.textBoxTourDescription.Name = "textBoxTourDescription";
            this.textBoxTourDescription.Size = new System.Drawing.Size(160, 26);
            this.textBoxTourDescription.TabIndex = 6;
            // 
            // textBoxTourPrice
            // 
            this.textBoxTourPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxTourPrice.Location = new System.Drawing.Point(499, 179);
            this.textBoxTourPrice.Name = "textBoxTourPrice";
            this.textBoxTourPrice.Size = new System.Drawing.Size(160, 26);
            this.textBoxTourPrice.TabIndex = 7;
            // 
            // buttonAddService
            // 
            this.buttonAddService.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonAddService.Location = new System.Drawing.Point(60, 238);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(210, 40);
            this.buttonAddService.TabIndex = 8;
            this.buttonAddService.Text = "Додати послугу";
            this.buttonAddService.UseVisualStyleBackColor = false;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // buttonAddTour
            // 
            this.buttonAddTour.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonAddTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonAddTour.Location = new System.Drawing.Point(406, 238);
            this.buttonAddTour.Name = "buttonAddTour";
            this.buttonAddTour.Size = new System.Drawing.Size(210, 40);
            this.buttonAddTour.TabIndex = 9;
            this.buttonAddTour.Text = "Додати путівку";
            this.buttonAddTour.UseVisualStyleBackColor = false;
            this.buttonAddTour.Click += new System.EventHandler(this.buttonAddTour_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Назва послуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Опис послуги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(12, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ціна послуги";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(366, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Назва путівки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(366, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Опис послуги";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label8.Location = new System.Drawing.Point(366, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ціна путівки";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(680, 309);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddTour);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.textBoxTourPrice);
            this.Controls.Add(this.textBoxTourDescription);
            this.Controls.Add(this.textBoxTourName);
            this.Controls.Add(this.textBoxServicePrice);
            this.Controls.Add(this.textBoxServiceDescription);
            this.Controls.Add(this.textBoxServiceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxServiceDescription;
        private System.Windows.Forms.TextBox textBoxServicePrice;
        private System.Windows.Forms.TextBox textBoxTourName;
        private System.Windows.Forms.TextBox textBoxTourDescription;
        private System.Windows.Forms.TextBox textBoxTourPrice;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Button buttonAddTour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}