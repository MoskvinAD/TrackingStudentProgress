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
            if (account.Login != null) { FIOTeacher.Text = account.Id.ToString(); }
            if (account.Login != null) { Post.Text = account.Id.ToString(); }
            if (account.Login != null) { Class.Text = account.Id.ToString(); }
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
            this.Size = new Size(500,500);
        }
    }
}
