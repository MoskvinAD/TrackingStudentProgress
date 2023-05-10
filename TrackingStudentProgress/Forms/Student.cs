using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void delite_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
