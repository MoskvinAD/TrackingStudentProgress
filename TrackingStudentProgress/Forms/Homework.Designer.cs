namespace TrackingStudentProgress.Forms
{
    partial class Homework
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
            this.label19 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePickerDZpo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDZs = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.delite = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(152, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Задание";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(155, 25);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(227, 89);
            this.Description.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "по";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "с";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Срок выполнения";
            // 
            // dateTimePickerDZpo
            // 
            this.dateTimePickerDZpo.Location = new System.Drawing.Point(28, 90);
            this.dateTimePickerDZpo.Name = "dateTimePickerDZpo";
            this.dateTimePickerDZpo.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerDZpo.TabIndex = 4;
            // 
            // dateTimePickerDZs
            // 
            this.dateTimePickerDZs.Location = new System.Drawing.Point(28, 64);
            this.dateTimePickerDZs.Name = "dateTimePickerDZs";
            this.dateTimePickerDZs.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerDZs.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Предмет";
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(15, 21);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(131, 21);
            this.ProjectComboBox.TabIndex = 1;
            this.ProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectComboBox_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(411, 92);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 12;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delite
            // 
            this.delite.Location = new System.Drawing.Point(411, 12);
            this.delite.Name = "delite";
            this.delite.Size = new System.Drawing.Size(75, 23);
            this.delite.TabIndex = 11;
            this.delite.Text = "Удалить";
            this.delite.UseVisualStyleBackColor = true;
            this.delite.Click += new System.EventHandler(this.delite_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(411, 52);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 10;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Homework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 133);
            this.Controls.Add(this.add);
            this.Controls.Add(this.delite);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ProjectComboBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePickerDZs);
            this.Controls.Add(this.dateTimePickerDZpo);
            this.Name = "Homework";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePickerDZpo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDZs;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delite;
        private System.Windows.Forms.Button edit;
    }
}