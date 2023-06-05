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

namespace TrackingStudentProgress.Forms
{
    public partial class quarterReport : Form
    {
        DBProvider.DBProvider DBProvider;
        Account Account;
        StudentModel Studentmodel;
        int TypeReport;
        public quarterReport(int typeReport ,StudentModel studentmodel, DBProvider.DBProvider dBProvider, Account account)
        {
            InitializeComponent();
            DBProvider = dBProvider;
            Account = account;
            Studentmodel = studentmodel;
            TypeReport = typeReport;
            if (typeReport == 1)
            {
                label1.Text = "Успеваемость за четверть";
            }else if (typeReport == 2)
            {
                label1.Text = "Средний бал за четверть";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxQuarter.SelectedIndex == -1) {
                MessageBox.Show("Выберите четверть");
                return;
            }
            List<string> listStr;
            if (TypeReport == 1) {
                listStr = DBProvider.GetJournalCostByTelegramByQuarterImColum(Studentmodel.Telegram, comboBoxQuarter.SelectedIndex + 1);               
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(Studentmodel.LastName+ " " +Studentmodel.MidleName + " " + Studentmodel.FirstName + ";");
                    foreach (var item in listStr)
                    {
                        sb.AppendLine(item);
                    }
                    var createdir = System.IO.Directory.CreateDirectory("C:\\Выгрузка\\");
                    string filePathOut = "\\JournalCostByQuarter_report.csv";
                    File.WriteAllText(createdir.FullName + filePathOut, sb.ToString(), System.Text.Encoding.GetEncoding(1251));
                    MessageBox.Show($"Отчёт создан по пути {createdir.FullName + filePathOut}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (TypeReport == 2)
            {
                listStr = DBProvider.GetAverageScoreForQuarterByTelegramInColum(Studentmodel.Telegram, comboBoxQuarter.SelectedIndex + 1);

                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(Studentmodel.LastName + " " + Studentmodel.MidleName + " " + Studentmodel.FirstName + ";");
                    foreach (var item in listStr)
                    {
                        sb.AppendLine(item);
                    }
                    var createdir = System.IO.Directory.CreateDirectory("C:\\Выгрузка\\");
                    string filePathOut = "\\AverageScoreForQuarter.csv";
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
}
