namespace TrackingStudentProgress.Forms
{
    partial class JournalEdit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delite = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.dateJuurnalContol = new System.Windows.Forms.DateTimePicker();
            this.FIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Предмет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(53, 10);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(0, 13);
            this.Class.TabIndex = 18;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(186, 138);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 17;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delite
            // 
            this.delite.Location = new System.Drawing.Point(186, 58);
            this.delite.Name = "delite";
            this.delite.Size = new System.Drawing.Size(75, 23);
            this.delite.TabIndex = 15;
            this.delite.Text = "Удалить";
            this.delite.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(186, 98);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 14;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(12, 113);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(141, 21);
            this.ProjectComboBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Оценка";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(68, 141);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(50, 20);
            this.Cost.TabIndex = 21;
            // 
            // dateJuurnalContol
            // 
            this.dateJuurnalContol.Location = new System.Drawing.Point(12, 75);
            this.dateJuurnalContol.Name = "dateJuurnalContol";
            this.dateJuurnalContol.Size = new System.Drawing.Size(140, 20);
            this.dateJuurnalContol.TabIndex = 22;
            // 
            // FIO
            // 
            this.FIO.AutoSize = true;
            this.FIO.Location = new System.Drawing.Point(9, 29);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(34, 13);
            this.FIO.TabIndex = 23;
            this.FIO.Text = "ФИО";
            // 
            // JournalEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 169);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.dateJuurnalContol);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delite);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.ProjectComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JournalEdit";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delite;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.DateTimePicker dateJuurnalContol;
        private System.Windows.Forms.Label FIO;
    }
}