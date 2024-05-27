namespace course
{
    partial class BookingForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.buttonBook = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dateTimePicker.Location = new System.Drawing.Point(110, 20);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 0;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.comboBoxTime.Location = new System.Drawing.Point(110, 60);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(200, 28);
            this.comboBoxTime.TabIndex = 1;
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.LightYellow;
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.buttonBook.Location = new System.Drawing.Point(89, 183);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(154, 39);
            this.buttonBook.TabIndex = 2;
            this.buttonBook.Text = "Записатися";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelDate.Location = new System.Drawing.Point(30, 20);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 20);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Дата";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.labelTime.Location = new System.Drawing.Point(30, 63);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(41, 20);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Час";
            // 
            // comboBoxService
            // 
            this.comboBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(110, 100);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(200, 28);
            this.comboBoxService.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(30, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Послуга";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxEmail.Location = new System.Drawing.Point(110, 141);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 26);
            this.textBoxEmail.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(30, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пошта";
            // 
            // BookingForm
            // 
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(334, 234);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxService);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "BookingForm";
            this.Text = "Запис на послугу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxService; // Додано ComboBox для вибору послуг
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
    }
}
