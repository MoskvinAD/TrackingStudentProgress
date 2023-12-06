namespace TrackingStudentProgress.Forms
{
    partial class StudentEdit
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
            this.label14 = new System.Windows.Forms.Label();
            this.Telegram = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.DateBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OStudent = new System.Windows.Forms.TextBox();
            this.NStudent = new System.Windows.Forms.TextBox();
            this.FStudent = new System.Windows.Forms.TextBox();
            this.Mazerbox = new System.Windows.Forms.ComboBox();
            this.studentbox = new System.Windows.Forms.ComboBox();
            this.FazerBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addbt = new System.Windows.Forms.Button();
            this.editbt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.classbox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 78;
            this.label14.Text = "Телеграмм";
            // 
            // Telegram
            // 
            this.Telegram.Location = new System.Drawing.Point(153, 115);
            this.Telegram.Name = "Telegram";
            this.Telegram.Size = new System.Drawing.Size(139, 20);
            this.Telegram.TabIndex = 77;
            this.Telegram.TextChanged += new System.EventHandler(this.Telegram_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(150, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 76;
            this.label16.Text = "Почта";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(153, 76);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(139, 20);
            this.Email.TabIndex = 75;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // DateBirth
            // 
            this.DateBirth.Location = new System.Drawing.Point(153, 34);
            this.DateBirth.Name = "DateBirth";
            this.DateBirth.Size = new System.Drawing.Size(139, 20);
            this.DateBirth.TabIndex = 74;
            this.DateBirth.ValueChanged += new System.EventHandler(this.DateBirth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Фамилия";
            // 
            // OStudent
            // 
            this.OStudent.Location = new System.Drawing.Point(6, 115);
            this.OStudent.Name = "OStudent";
            this.OStudent.Size = new System.Drawing.Size(131, 20);
            this.OStudent.TabIndex = 57;
            this.OStudent.TextChanged += new System.EventHandler(this.OStudent_TextChanged);
            // 
            // NStudent
            // 
            this.NStudent.Location = new System.Drawing.Point(6, 76);
            this.NStudent.Name = "NStudent";
            this.NStudent.Size = new System.Drawing.Size(131, 20);
            this.NStudent.TabIndex = 56;
            this.NStudent.TextChanged += new System.EventHandler(this.NStudent_TextChanged);
            // 
            // FStudent
            // 
            this.FStudent.Location = new System.Drawing.Point(6, 37);
            this.FStudent.Name = "FStudent";
            this.FStudent.Size = new System.Drawing.Size(131, 20);
            this.FStudent.TabIndex = 55;
            this.FStudent.TextChanged += new System.EventHandler(this.FStudent_TextChanged);
            // 
            // Mazerbox
            // 
            this.Mazerbox.FormattingEnabled = true;
            this.Mazerbox.Location = new System.Drawing.Point(153, 158);
            this.Mazerbox.Name = "Mazerbox";
            this.Mazerbox.Size = new System.Drawing.Size(139, 21);
            this.Mazerbox.TabIndex = 79;
            this.Mazerbox.SelectedIndexChanged += new System.EventHandler(this.Mazerbox_SelectedIndexChanged);
            // 
            // studentbox
            // 
            this.studentbox.FormattingEnabled = true;
            this.studentbox.Location = new System.Drawing.Point(12, 25);
            this.studentbox.Name = "studentbox";
            this.studentbox.Size = new System.Drawing.Size(232, 21);
            this.studentbox.TabIndex = 80;
            this.studentbox.SelectedIndexChanged += new System.EventHandler(this.studentbox_SelectedIndexChanged);
            // 
            // FazerBox
            // 
            this.FazerBox.FormattingEnabled = true;
            this.FazerBox.Location = new System.Drawing.Point(8, 158);
            this.FazerBox.Name = "FazerBox";
            this.FazerBox.Size = new System.Drawing.Size(139, 21);
            this.FazerBox.TabIndex = 81;
            this.FazerBox.SelectedValueChanged += new System.EventHandler(this.FazerBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Ученик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Отец";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Мать";
            // 
            // addbt
            // 
            this.addbt.Location = new System.Drawing.Point(328, 18);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(70, 29);
            this.addbt.TabIndex = 86;
            this.addbt.Text = "Добавить";
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // editbt
            // 
            this.editbt.Location = new System.Drawing.Point(250, 18);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(72, 29);
            this.editbt.TabIndex = 85;
            this.editbt.Text = "Изменить";
            this.editbt.UseVisualStyleBackColor = true;
            this.editbt.Click += new System.EventHandler(this.editbt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Класс";
            // 
            // classbox
            // 
            this.classbox.FormattingEnabled = true;
            this.classbox.Location = new System.Drawing.Point(306, 33);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(73, 21);
            this.classbox.TabIndex = 87;
            this.classbox.SelectedIndexChanged += new System.EventHandler(this.classbox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FStudent);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.classbox);
            this.groupBox1.Controls.Add(this.NStudent);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Telegram);
            this.groupBox1.Controls.Add(this.OStudent);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DateBirth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Mazerbox);
            this.groupBox1.Controls.Add(this.FazerBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 196);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // StudentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.editbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentbox);
            this.Name = "StudentEdit";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Telegram;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.DateTimePicker DateBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OStudent;
        private System.Windows.Forms.TextBox NStudent;
        private System.Windows.Forms.TextBox FStudent;
        private System.Windows.Forms.ComboBox Mazerbox;
        private System.Windows.Forms.ComboBox studentbox;
        private System.Windows.Forms.ComboBox FazerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox classbox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}