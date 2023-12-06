namespace TrackingStudentProgress.Forms
{
    partial class SheduleEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.edit = new System.Windows.Forms.Button();
            this.delite = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.add = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Класс:";
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(15, 77);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(141, 21);
            this.ProjectComboBox.TabIndex = 3;
            this.ProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectComboBox_SelectedIndexChanged);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(174, 52);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 4;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delite
            // 
            this.delite.Location = new System.Drawing.Point(174, 12);
            this.delite.Name = "delite";
            this.delite.Size = new System.Drawing.Size(75, 23);
            this.delite.TabIndex = 5;
            this.delite.Text = "Удалить";
            this.delite.UseVisualStyleBackColor = true;
            this.delite.Click += new System.EventHandler(this.delite_Click);
            // 
            // Date
            // 
            this.Date.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Date.Location = new System.Drawing.Point(15, 39);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(141, 20);
            this.Date.TabIndex = 6;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(174, 36);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(56, 9);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(0, 13);
            this.Class.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Предмет";
            // 
            // SheduleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 108);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.delite);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.ProjectComboBox);
            this.Controls.Add(this.label2);
            this.Name = "SheduleEdit";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delite;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}