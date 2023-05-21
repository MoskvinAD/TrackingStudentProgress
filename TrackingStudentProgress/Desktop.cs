﻿using DBProvider;
using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TrackingStudentProgress.Forms;
using TrackingStudentProgress.Helper.TrackingStudentProgressBDDataSet3TableAdapters;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;

namespace TrackingStudentProgress
{
    public partial class Desktop : Form
    {
        DBProvider.DBProvider DBProvider;
        Account Account;
        List<ProjectModel> ProjectModelslist;
        List<StudentModel> StudentModellist;
        int TypeReport = -1;
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
            AddStudentInList();
            getStudentTableAdapter.Fill(getStudentsBDDataSet.GetStudent, int.Parse(Account.Class));
        }

        private void AddProjectComboBox()
        {
            ProjectModelslist = DBProvider.GetProject();
            foreach (ProjectModel model in ProjectModelslist)
            {
                ProjectComboBox.Items.Add(model.Name);
            }
        }

        private void AddStudentInList()
        {
            StudentModellist = DBProvider.GetStudentinidClass(int.Parse(Account.Class));
        }

        private void ProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show();
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
            getStudentTableAdapter.Fill(getStudentsBDDataSet.GetStudent, int.Parse(Account.Class));            
        }



        private void ShowSchedule_Click(object sender, EventArgs e)
        {
            getJournalScheduleTableAdapter.Fill(trackingStudentProgressBDDataSet4.GetJournalSchedule, int.Parse(Account.Class), Raspisanietos.Value, Raspisanieto.Value);
        }

        private void dataGridViewSchedule_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.CurrentRow == null) { return; }
            int IndexClick = dataGridViewSchedule.CurrentRow.Index;
            
            if (IndexClick > -1) {
                try
                {
                    ScheduleModel scheduleModel = new ScheduleModel();
                    scheduleModel.Id = Convert.ToInt32(dataGridViewSchedule[0, IndexClick].Value);
                    scheduleModel.Date = Convert.ToDateTime(dataGridViewSchedule[1, IndexClick].Value);
                    scheduleModel.idClass = int.Parse(Account.Class);
                    scheduleModel.idProject = Convert.ToInt32(dataGridViewSchedule[5, IndexClick].Value);

                    SheduleEdit sheduleEdit = new SheduleEdit(IndexClick, scheduleModel, DBProvider, Account);
                    sheduleEdit.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void ShowJournal_Click(object sender, EventArgs e)
        {
            
            if (dateJuurnalContol.Value == null)
            {
                MessageBox.Show("Выберите дату");
                return;
            }
            if (ProjectComboBox.SelectedIndex == -1) {
                MessageBox.Show("Выберите предмет");
                return;
            }
            int countReturnDataSet = getJournalTableAdapter.Fill(getJournalBDDataSet.GetJournal,
                  int.Parse(Account.Class),
               ProjectComboBox.SelectedIndex + 1,
               dateJuurnalContol.Value);
            int countReturnDBProvider = DBProvider.GetScheduleCount(int.Parse(Account.Class), ProjectComboBox.SelectedIndex + 1, dateJuurnalContol.Value);

            if (countReturnDataSet == 0 &&
                countReturnDBProvider > 0 &&
                StudentModellist.Count > 0) {

                DBProvider.SetJournalStudent(ProjectComboBox.SelectedIndex + 1, dateJuurnalContol.Value, StudentModellist);

                getJournalTableAdapter.Fill(getJournalBDDataSet.GetJournal,
                     int.Parse(Account.Class),
               ProjectComboBox.SelectedIndex + 1,
               dateJuurnalContol.Value);
            }

        }

        private void dataGridViewHomework_Click(object sender, EventArgs e)
        {
            if (dataGridViewHomework.CurrentRow == null) { return; }
            int IndexClick = dataGridViewHomework.CurrentRow.Index;

            if (IndexClick > -1)
            {
                try
                {
                    HomeWorkModel homeWork = new HomeWorkModel();
                    homeWork.Id = Convert.ToInt32(dataGridViewHomework[0, IndexClick].Value);
                    homeWork.idProject = Convert.ToInt32(dataGridViewHomework[1, IndexClick].Value);
                    homeWork.idClass = int.Parse(Account.Class);
                    homeWork.DateFrom = Convert.ToDateTime(dataGridViewHomework[5, IndexClick].Value);
                    homeWork.DateTo = Convert.ToDateTime(dataGridViewHomework[6, IndexClick].Value);
                    homeWork.Description = Convert.ToString(dataGridViewHomework[7, IndexClick].Value);
                    Homework homework = new Homework(IndexClick, homeWork, DBProvider, Account);
                    homework.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            getHomeWorkTableAdapter1.Fill(trackingStudentProgressBDDataSet6.GetHomeWork, int.Parse(Account.Class));
        }

        private void StudentGrid_Click(object sender, EventArgs e)
        {
            if (StudentGrid.CurrentRow == null) { return; }
            int IndexClick = StudentGrid.CurrentRow.Index;

            if (IndexClick > -1)
            {
                try
                {
                    StudentModel studentmodel = new StudentModel();
                    studentmodel.Id = Convert.ToInt32(StudentGrid[0, IndexClick].Value);
                    studentmodel.LastName = Convert.ToString(StudentGrid[1, IndexClick].Value);
                    studentmodel.MidleName = Convert.ToString(StudentGrid[2, IndexClick].Value);
                    studentmodel.FirstName = Convert.ToString(StudentGrid[3, IndexClick].Value);
                    studentmodel.DateCreate = Convert.ToDateTime(StudentGrid[4, IndexClick].Value);
                    studentmodel.Email = Convert.ToString(StudentGrid[5, IndexClick].Value);
                    studentmodel.Telegram = Convert.ToString(StudentGrid[6, IndexClick].Value);
                    studentmodel.idClass = int.Parse(Account.Class);
                    studentmodel.NumberClass = Convert.ToString(StudentGrid[8, IndexClick].Value);
                    studentmodel.FioM = Convert.ToString(StudentGrid[9, IndexClick].Value);
                    studentmodel.EmalM = Convert.ToString(StudentGrid[10, IndexClick].Value);
                    studentmodel.TelegramM = Convert.ToString(StudentGrid[11, IndexClick].Value);
                    studentmodel.idM = Convert.ToInt32(StudentGrid[12, IndexClick].Value);
                    studentmodel.FioF = Convert.ToString(StudentGrid[13, IndexClick].Value);
                    studentmodel.EmalF = Convert.ToString(StudentGrid[14, IndexClick].Value);
                    studentmodel.TelegramF = Convert.ToString(StudentGrid[15, IndexClick].Value);
                    studentmodel.idF = Convert.ToInt32(StudentGrid[16, IndexClick].Value);

                    Student student = new Student(IndexClick, studentmodel, DBProvider, Account);
                    student.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
        }

        private void dataGridViewJournal_Click(object sender, EventArgs e)
        {
            if (dataGridViewJournal.CurrentRow == null) { return; }
            int IndexClick = dataGridViewJournal.CurrentRow.Index;

            if (IndexClick > -1)
            {
                try
                {
                    JournalModel journalModel = new JournalModel();
                    journalModel.Id = Convert.ToInt32(dataGridViewJournal[0, IndexClick].Value);
                    journalModel.Date = Convert.ToDateTime(dataGridViewJournal[1, IndexClick].Value);
                    journalModel.nameProject = Convert.ToString(dataGridViewJournal[2, IndexClick].Value);
                    journalModel.idProject = Convert.ToInt32(dataGridViewJournal[3, IndexClick].Value);
                    journalModel.LastName = Convert.ToString(dataGridViewJournal[4, IndexClick].Value);
                    journalModel.MidleName = Convert.ToString(dataGridViewJournal[5, IndexClick].Value);
                    journalModel.FirstName = Convert.ToString(dataGridViewJournal[6, IndexClick].Value);
                    journalModel.idStudent = Convert.ToInt32(dataGridViewJournal[7, IndexClick].Value);
                    journalModel.Cost = Convert.ToString(dataGridViewJournal[8, IndexClick].Value);


                    JournalEdit student = new JournalEdit(IndexClick, journalModel, DBProvider);
                    student.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void addShedule_Click(object sender, EventArgs e)
        {
            SheduleEdit sheduleEdit = new SheduleEdit(0, null, DBProvider, Account, true);
            sheduleEdit.ShowDialog();
        }

        private void addHomeWork_Click(object sender, EventArgs e)
        {
            Homework homework = new Homework(0, null, DBProvider, Account,true);
            homework.ShowDialog();
        }

        private void typeReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeReport = typeReport.SelectedIndex;
        }

        private void LoadReport_Click(object sender, EventArgs e)
        {
            if (TypeReport == 0)
            {
                List<TrackingStudentProgressModel> listStr = DBProvider.GetTrackingStudentProgress(int.Parse(Account.Class));
                if (listStr.Count > 0)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("ФИО" + ";" + listStr[0].NameProject1 + ";" + listStr[0].NameProject2 + ";" + listStr[0].NameProject3 + ";" + listStr[0].NameProject4 + ";" + listStr[0].NameProject5 + ";" + listStr[0].NameProject6 + ";" + listStr[0].NameProject7);
                        foreach (TrackingStudentProgressModel item in listStr)
                        {
                            sb.AppendLine(item.Fio + ";" + item.Resul1 + ";" + item.Resul2 + ";" + item.Resul3 + ";" + item.Resul4 + ";" + item.Resul5 + ";" + item.Resul6 + ";" + item.Resul7);
                        }
                        var createdir = System.IO.Directory.CreateDirectory("C:\\Выгрузка\\");
                        string filePathOut = "\\TrackingStudentProgress_report.csv";
                        File.WriteAllText(createdir.FullName + filePathOut, sb.ToString(), System.Text.Encoding.GetEncoding(1251));
                        MessageBox.Show($"Отчёт создан по пути {createdir.FullName + filePathOut}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (TypeReport == 1)
            {
                List<AttendanceReportModel> listStr = DBProvider.GetAttendanceReport(int.Parse(Account.Class));
                if (listStr.Count > 0)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("ФИО" + ";" + "Количество пропусков" + ";");
                        foreach (AttendanceReportModel item in listStr)
                        {
                            sb.AppendLine(item.FIO + ";" + item.Count + ";");
                        }
                        var createdir = System.IO.Directory.CreateDirectory("C:\\Выгрузка\\");
                        string filePathOut = "\\Attendance_report.csv";
                        File.WriteAllText(createdir.FullName + filePathOut, sb.ToString(), System.Text.Encoding.GetEncoding(1251));
                        MessageBox.Show($"Отчёт создан по пути {createdir.FullName + filePathOut}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else {
                MessageBox.Show("Выберите отчёт"); 
                return;
            }
                       
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {

        }

        private void RemoveStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
