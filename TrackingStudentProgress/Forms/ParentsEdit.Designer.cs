namespace TrackingStudentProgress.Forms
{
    partial class ParentsEdit
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
            this.deletebt = new System.Windows.Forms.Button();
            this.addbt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editbt = new System.Windows.Forms.Button();
            this.FIO = new System.Windows.Forms.TextBox();
            this.telegram = new System.Windows.Forms.TextBox();
            this.emal = new System.Windows.Forms.TextBox();
            this.comboBoxParent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deletebt
            // 
            this.deletebt.Location = new System.Drawing.Point(265, 100);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(85, 28);
            this.deletebt.TabIndex = 47;
            this.deletebt.Text = "Удалить";
            this.deletebt.UseVisualStyleBackColor = true;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // addbt
            // 
            this.addbt.Location = new System.Drawing.Point(265, 59);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(85, 28);
            this.addbt.TabIndex = 46;
            this.addbt.Text = "Добавить";
            this.addbt.UseVisualStyleBackColor = true;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Телеграмм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Почта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Родители";
            // 
            // editbt
            // 
            this.editbt.Location = new System.Drawing.Point(265, 20);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(85, 28);
            this.editbt.TabIndex = 37;
            this.editbt.Text = "Изменить";
            this.editbt.UseVisualStyleBackColor = true;
            this.editbt.Click += new System.EventHandler(this.editbt_Click);
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(15, 64);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(244, 20);
            this.FIO.TabIndex = 34;
            this.FIO.TextChanged += new System.EventHandler(this.FIO_TextChanged);
            // 
            // telegram
            // 
            this.telegram.Location = new System.Drawing.Point(143, 108);
            this.telegram.Name = "telegram";
            this.telegram.Size = new System.Drawing.Size(116, 20);
            this.telegram.TabIndex = 32;
            this.telegram.TextChanged += new System.EventHandler(this.telegram_TextChanged);
            // 
            // emal
            // 
            this.emal.Location = new System.Drawing.Point(16, 108);
            this.emal.Name = "emal";
            this.emal.Size = new System.Drawing.Size(121, 20);
            this.emal.TabIndex = 31;
            this.emal.TextChanged += new System.EventHandler(this.emal_TextChanged);
            // 
            // comboBoxParent
            // 
            this.comboBoxParent.FormattingEnabled = true;
            this.comboBoxParent.Location = new System.Drawing.Point(15, 25);
            this.comboBoxParent.Name = "comboBoxParent";
            this.comboBoxParent.Size = new System.Drawing.Size(244, 21);
            this.comboBoxParent.TabIndex = 29;
            this.comboBoxParent.SelectedIndexChanged += new System.EventHandler(this.comboBoxParent_SelectedIndexChanged);
            // 
            // ParentsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 146);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editbt);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.telegram);
            this.Controls.Add(this.emal);
            this.Controls.Add(this.comboBoxParent);
            this.Name = "ParentsEdit";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox telegram;
        private System.Windows.Forms.TextBox emal;
        private System.Windows.Forms.ComboBox comboBoxParent;
    }
}