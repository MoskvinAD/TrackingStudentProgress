namespace TrackingStudentProgress
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Authorizationbt = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentEditbt = new System.Windows.Forms.Button();
            this.ParentsEditbt = new System.Windows.Forms.Button();
            this.AccountEditbt = new System.Windows.Forms.Button();
            this.Desktopbt = new System.Windows.Forms.Button();
            this.classcbox = new System.Windows.Forms.ComboBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authorizationbt
            // 
            this.Authorizationbt.Location = new System.Drawing.Point(117, 154);
            this.Authorizationbt.Name = "Authorizationbt";
            this.Authorizationbt.Size = new System.Drawing.Size(75, 23);
            this.Authorizationbt.TabIndex = 0;
            this.Authorizationbt.Text = "Вход";
            this.Authorizationbt.UseVisualStyleBackColor = true;
            this.Authorizationbt.Click += new System.EventHandler(this.Authorizationbt_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(85, 54);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(140, 20);
            this.Login.TabIndex = 1;
            this.Login.Text = "admin";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(85, 108);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(140, 20);
            this.Password.TabIndex = 2;
            this.Password.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Отслеживание успеваемости обучающихся";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // StudentEditbt
            // 
            this.StudentEditbt.Location = new System.Drawing.Point(3, 45);
            this.StudentEditbt.Name = "StudentEditbt";
            this.StudentEditbt.Size = new System.Drawing.Size(75, 23);
            this.StudentEditbt.TabIndex = 8;
            this.StudentEditbt.Text = "Ученики";
            this.StudentEditbt.UseVisualStyleBackColor = true;
            this.StudentEditbt.Click += new System.EventHandler(this.StudentEditbt_Click);
            // 
            // ParentsEditbt
            // 
            this.ParentsEditbt.Location = new System.Drawing.Point(96, 3);
            this.ParentsEditbt.Name = "ParentsEditbt";
            this.ParentsEditbt.Size = new System.Drawing.Size(75, 23);
            this.ParentsEditbt.TabIndex = 7;
            this.ParentsEditbt.Text = "Родители";
            this.ParentsEditbt.UseVisualStyleBackColor = true;
            this.ParentsEditbt.Click += new System.EventHandler(this.ParentsEditbt_Click);
            // 
            // AccountEditbt
            // 
            this.AccountEditbt.Location = new System.Drawing.Point(3, 3);
            this.AccountEditbt.Name = "AccountEditbt";
            this.AccountEditbt.Size = new System.Drawing.Size(75, 23);
            this.AccountEditbt.TabIndex = 6;
            this.AccountEditbt.Text = "Акаунты";
            this.AccountEditbt.UseVisualStyleBackColor = true;
            this.AccountEditbt.Click += new System.EventHandler(this.AccountEditbt_Click);
            // 
            // Desktopbt
            // 
            this.Desktopbt.Location = new System.Drawing.Point(96, 35);
            this.Desktopbt.Name = "Desktopbt";
            this.Desktopbt.Size = new System.Drawing.Size(75, 43);
            this.Desktopbt.TabIndex = 9;
            this.Desktopbt.Text = "Рабочее место";
            this.Desktopbt.UseVisualStyleBackColor = true;
            this.Desktopbt.Click += new System.EventHandler(this.Desktopbt_Click);
            // 
            // classcbox
            // 
            this.classcbox.FormattingEnabled = true;
            this.classcbox.Location = new System.Drawing.Point(194, 10);
            this.classcbox.Name = "classcbox";
            this.classcbox.Size = new System.Drawing.Size(121, 21);
            this.classcbox.TabIndex = 10;
            this.classcbox.SelectedIndexChanged += new System.EventHandler(this.classcbox_SelectedIndexChanged);
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.AccountEditbt);
            this.panelAdmin.Controls.Add(this.classcbox);
            this.panelAdmin.Controls.Add(this.ParentsEditbt);
            this.panelAdmin.Controls.Add(this.Desktopbt);
            this.panelAdmin.Controls.Add(this.StudentEditbt);
            this.panelAdmin.Location = new System.Drawing.Point(37, 43);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(351, 134);
            this.panelAdmin.TabIndex = 11;
            this.panelAdmin.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(403, 221);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Authorizationbt);
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panelAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Authorizationbt;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StudentEditbt;
        private System.Windows.Forms.Button ParentsEditbt;
        private System.Windows.Forms.Button AccountEditbt;
        private System.Windows.Forms.Button Desktopbt;
        private System.Windows.Forms.ComboBox classcbox;
        private System.Windows.Forms.Panel panelAdmin;
    }
}

