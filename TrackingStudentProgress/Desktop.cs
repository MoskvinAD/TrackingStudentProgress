﻿using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackingStudentProgress.Forms;
using TrackingStudentProgress.TrackingStudentProgressBDDataSet3TableAdapters;
using static System.Net.Mime.MediaTypeNames;

namespace TrackingStudentProgress
{
    public partial class Desktop : Form
    {
        DBProvider.DBProvider DBProvider;
        Account Account;
        List<ProjectModel> ProjectModelslist;
        private void Desktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DBProvider != null)
            {
                DBProvider.DBProviderClosed();
            }

        }
        public Desktop(Account account, DBProvider.DBProvider dBProvider)
        {
            InitializeComponent();
            DBProvider = dBProvider;
            Account = account;
            if (account.SurName != null) { FIOTeacher.Text = account.SurName.ToString(); }
            if (account.MidleName != null) { FIOTeacher.Text = FIOTeacher.Text + " " +account.MidleName.ToString(); }
            if (account.LastName != null) { FIOTeacher.Text = FIOTeacher.Text + " " + account.LastName.ToString(); }
            if (account.Position != null) { Post.Text = "Должность: "+account.Position.ToString(); }
            if (account.Class != null) { Class.Text = "Класс: " + account.Class.ToString(); }
            AddProjectComboBox();
        }

        private void AddProjectComboBox()
        {
            ProjectModelslist = DBProvider.GetProject();
            foreach (ProjectModel model in ProjectModelslist)
            {
                ProjectComboBox.Items.Add(model.Name);
                ProjectComboBox1.Items.Add(model.Name);
            }
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trackingStudentProgressBDDataSet2.dataGridViewHomework". При необходимости она может быть перемещена или удалена.
            this.dataGridViewHomeworkTableAdapter.Fill(this.trackingStudentProgressBDDataSet2.dataGridViewHomework);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trackingStudentProgressBDDataSet1.dataGridViewSchedule". При необходимости она может быть перемещена или удалена.
            this.dataGridViewScheduleTableAdapter.Fill(this.trackingStudentProgressBDDataSet1.dataGridViewSchedule);
            this.studentTableAdapter.Fill(this.trackingStudentProgressBDDataSet.Student);

        }
        private void RefreshStudent_Click(object sender, EventArgs e)
        {

            studentTableAdapter.Fill(trackingStudentProgressBDDataSet.Student);


        }



        private void ShowSchedule_Click(object sender, EventArgs e)
        {

            //getJournalInClassTableAdapter.Fill(getJournalInClassBDDataSet.GetJournalInClass, 1);
            getJournalScheduleTableAdapter.Fill(trackingStudentProgressBDDataSet4.GetJournalSchedule, int.Parse(Account.Class), Raspisanietos.Value, Raspisanieto.Value);

        }

        private void dataGridViewSchedule_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.CurrentRow == null) { return; }
            int IndexClick = dataGridViewSchedule.CurrentRow.Index;
            
            if (IndexClick > -1) {
                ScheduleModel scheduleModel = new ScheduleModel();
                scheduleModel.Id = Convert.ToInt32(dataGridViewSchedule[0, IndexClick].Value);
                scheduleModel.Date = Convert.ToDateTime(dataGridViewSchedule[1, IndexClick].Value);
                scheduleModel.idClass = int.Parse(Account.Class);
                scheduleModel.idProject = Convert.ToInt32(dataGridViewSchedule[5, IndexClick].Value);

                SheduleEdit sheduleEdit = new SheduleEdit(IndexClick, scheduleModel, DBProvider, Account);
                sheduleEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите позицию которую необходимо удалить");
                return;
            }
        }

        private void AddProject_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = new DataGridViewRow();
            //row.CreateCells(dataGridViewSchedule);


            //row.Cells[0].Value = 1;
            //row.Cells[1].Value = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            //row.Cells[2].Value = 1;
            //row.Cells[3].Value = "ы";
            //row.Cells[4].Value = 1;

            //dataGridViewSchedule.Rows.Add(row);

        }

        private void ShowJournal_Click(object sender, EventArgs e)
        {            
            getJournalInClassTableAdapter.Fill(getJournalInClassBDDataSet.GetJournalInClass, int.Parse(Account.Class));
        }

        private void dataGridViewSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
