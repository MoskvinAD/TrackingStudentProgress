namespace TrackingStudentProgress.Forms
{
    partial class AccountEdit
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
            this.comboBoxAccount = new System.Windows.Forms.ComboBox();
            this.classcbox = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MidlName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.editbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addbt = new System.Windows.Forms.Button();
            this.deletebt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAccount
            // 
            this.comboBoxAccount.FormattingEnabled = true;
            this.comboBoxAccount.Location = new System.Drawing.Point(12, 28);
            this.comboBoxAccount.Name = "comboBoxAccount";
            this.comboBoxAccount.Size = new System.Drawing.Size(326, 21);
            this.comboBoxAccount.TabIndex = 0;
            this.comboBoxAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxAccount_SelectedIndexChanged);
            // 
            // classcbox
            // 
            this.classcbox.FormattingEnabled = true;
            this.classcbox.Location = new System.Drawing.Point(173, 73);
            this.classcbox.Name = "classcbox";
            this.classcbox.Size = new System.Drawing.Size(78, 21);
            this.classcbox.TabIndex = 11;
            this.classcbox.SelectedIndexChanged += new System.EventHandler(this.classcbox_SelectedIndexChanged);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(11, 72);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(156, 20);
            this.FirstName.TabIndex = 12;
            this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
            // 
            // MidlName
            // 
            this.MidlName.Location = new System.Drawing.Point(11, 114);
            this.MidlName.Name = "MidlName";
            this.MidlName.Size = new System.Drawing.Size(156, 20);
            this.MidlName.TabIndex = 13;
            this.MidlName.TextChanged += new System.EventHandler(this.MidlName_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(13, 154);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(156, 20);
            this.LastName.TabIndex = 14;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(10, 32);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(157, 20);
            this.Login.TabIndex = 15;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(173, 32);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(147, 20);
            this.Password.TabIndex = 16;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Location = new System.Drawing.Point(173, 115);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(147, 21);
            this.Position.TabIndex = 17;
            this.Position.SelectedIndexChanged += new System.EventHandler(this.Position_SelectedIndexChanged);
            // 
            // editbt
            // 
            this.editbt.Location = new System.Drawing.Point(358, 12);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(85, 28);
            this.editbt.TabIndex = 18;
            this.editbt.Text = "Изменить";
            this.editbt.UseVisualStyleBackColor = true;
            this.editbt.Click += new System.EventHandler(this.editbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Акаунт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Логин";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Класс";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Должность";
            // 
            // addbt
            // 
            this.addbt.Location = new System.Drawing.Point(358, 46);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(85, 28);
            this.addbt.TabIndex = 27;
            this.addbt.Text = "Добавить";
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // deletebt
            // 
            this.deletebt.Location = new System.Drawing.Point(358, 79);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(85, 28);
            this.deletebt.TabIndex = 28;
            this.deletebt.Text = "Удалить";
            this.deletebt.UseVisualStyleBackColor = true;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Login);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.classcbox);
            this.groupBox1.Controls.Add(this.MidlName);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 191);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные";
            // 
            // AccountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 260);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editbt);
            this.Controls.Add(this.comboBoxAccount);
            this.Name = "AccountEdit";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAccount;
        private System.Windows.Forms.ComboBox classcbox;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MidlName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}