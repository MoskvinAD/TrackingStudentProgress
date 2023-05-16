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
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editbt = new System.Windows.Forms.Button();
            this.FIO = new System.Windows.Forms.TextBox();
            this.telegram = new System.Windows.Forms.TextBox();
            this.emal = new System.Windows.Forms.TextBox();
            this.studentbox = new System.Windows.Forms.ComboBox();
            this.comboBoxParent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // deletebt
            // 
            this.deletebt.Location = new System.Drawing.Point(267, 92);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(85, 28);
            this.deletebt.TabIndex = 47;
            this.deletebt.Text = "Удалить";
            this.deletebt.UseVisualStyleBackColor = true;
            // 
            // addbt
            // 
            this.addbt.Location = new System.Drawing.Point(267, 53);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(85, 28);
            this.addbt.TabIndex = 46;
            this.addbt.Text = "Добавить";
            this.addbt.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Ученик";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Телеграмм";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Почта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Родители";
            // 
            // editbt
            // 
            this.editbt.Location = new System.Drawing.Point(267, 14);
            this.editbt.Name = "editbt";
            this.editbt.Size = new System.Drawing.Size(85, 28);
            this.editbt.TabIndex = 37;
            this.editbt.Text = "Изменить";
            this.editbt.UseVisualStyleBackColor = true;
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(12, 84);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(244, 20);
            this.FIO.TabIndex = 34;
            // 
            // telegram
            // 
            this.telegram.Location = new System.Drawing.Point(140, 125);
            this.telegram.Name = "telegram";
            this.telegram.Size = new System.Drawing.Size(116, 20);
            this.telegram.TabIndex = 32;
            // 
            // emal
            // 
            this.emal.Location = new System.Drawing.Point(13, 125);
            this.emal.Name = "emal";
            this.emal.Size = new System.Drawing.Size(121, 20);
            this.emal.TabIndex = 31;
            // 
            // studentbox
            // 
            this.studentbox.FormattingEnabled = true;
            this.studentbox.Location = new System.Drawing.Point(12, 164);
            this.studentbox.Name = "studentbox";
            this.studentbox.Size = new System.Drawing.Size(121, 21);
            this.studentbox.TabIndex = 30;
            // 
            // comboBoxParent
            // 
            this.comboBoxParent.FormattingEnabled = true;
            this.comboBoxParent.Location = new System.Drawing.Point(12, 37);
            this.comboBoxParent.Name = "comboBoxParent";
            this.comboBoxParent.Size = new System.Drawing.Size(244, 21);
            this.comboBoxParent.TabIndex = 29;
            // 
            // ParentsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 211);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editbt);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.telegram);
            this.Controls.Add(this.emal);
            this.Controls.Add(this.studentbox);
            this.Controls.Add(this.comboBoxParent);
            this.Name = "ParentsEdit";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebt;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editbt;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox telegram;
        private System.Windows.Forms.TextBox emal;
        private System.Windows.Forms.ComboBox studentbox;
        private System.Windows.Forms.ComboBox comboBoxParent;
    }
}