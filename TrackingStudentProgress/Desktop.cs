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

namespace TrackingStudentProgress
{
    public partial class Desktop : Form
    {
        DBProvider.DBProvider DBProvider;
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
            if (account.SurName != null) { FIOTeacher.Text = account.SurName.ToString(); }
            if (account.MidleName != null) { FIOTeacher.Text = FIOTeacher.Text + " " +account.MidleName.ToString(); }
            if (account.LastName != null) { FIOTeacher.Text = FIOTeacher.Text + " " + account.LastName.ToString(); }
            if (account.Position != null) { Post.Text = "Должность: "+account.Position.ToString(); }
            if (account.Class != null) { Class.Text = "Класс: " + account.Class.ToString(); }
        }

        private void VivisibilitiShowPanelStudent_Click(object sender, EventArgs e)
        {
            ShowStudent.Visible = false;
        }

        private void SaveStudent_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(500,300);
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trackingStudentProgressBDDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter.Fill(this.trackingStudentProgressBDDataSet.Student);

        }

        private void StudentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
