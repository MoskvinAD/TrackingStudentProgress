using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace TrackingStudentProgress.Forms
{
    public partial class Student : Form
    {
        int Index;
        DBProvider.DBProvider DBProvider;
        Account Account;
        StudentModel Studentmodel;
        public Student(int index, StudentModel studentmodel, DBProvider.DBProvider dBProvider, Account account)
        {
            InitializeComponent();
            DBProvider = dBProvider;
            Account = account;
            Studentmodel = studentmodel;
            FStudent.Text = studentmodel.LastName;
            NStudent.Text = studentmodel.MidleName;
            OStudent.Text = studentmodel.FirstName;
            Email.Text = studentmodel.Email;
            DateBirth.Value = studentmodel.DateCreate;
            Telegram.Text = studentmodel.Telegram;
            Parent1.Text = studentmodel.FioM;
            Emal1.Text = studentmodel.EmalM;
            Telegram1.Text = studentmodel.TelegramM;
            Parent2.Text = studentmodel.FioF;
            Emal2.Text = studentmodel.EmalF;
            Telegram2.Text = studentmodel.TelegramF;

            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Успеваемость за четверть");
            t.SetToolTip(button2, "Средний бал за четверть");
            t.SetToolTip(button3, "Средний бал за учебный год");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quarterReport quarterReport = new quarterReport(1, Studentmodel, DBProvider, Account);
            quarterReport.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            quarterReport quarterReport = new quarterReport(2, Studentmodel, DBProvider, Account);
            quarterReport.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> listStr = DBProvider.GetAverageScoreForByTelegramByColum(Studentmodel.Telegram);

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(Studentmodel.LastName + " " + Studentmodel.MidleName + " " + Studentmodel.FirstName + ";");
                foreach (var item in listStr)
                {
                    sb.AppendLine(item);
                }
                var createdir = System.IO.Directory.CreateDirectory("C:\\Выгрузка\\");
                string filePathOut = "\\AverageScore.csv";
                File.WriteAllText(createdir.FullName + filePathOut, sb.ToString(), System.Text.Encoding.GetEncoding(1251));
                MessageBox.Show($"Отчёт создан по пути {createdir.FullName + filePathOut}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
