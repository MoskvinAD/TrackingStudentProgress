using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBProvider;
using DBProvider.Model;

namespace TrackingStudentProgress
{
    public partial class Authorization : Form
    {
        DBProvider.DBProvider DBProvider;
        public Authorization()
        {
            InitializeComponent();
            DBProvider = new DBProvider.DBProvider();
        }

        private void Authorizationbt_Click(object sender, EventArgs e)
        {
            if (Login.Text.Length == 0) { MessageBox.Show("Введите Логин"); return; }
            if (Password.Text.Length == 0) { MessageBox.Show("Введите Пароль"); return; }
            if (DBProvider == null) { MessageBox.Show("Ошибка соединения"); return; }
            Account account = DBProvider.InputAccaunt(Login.Text, Password.Text);
            if (account.Id == 0) { MessageBox.Show("Пользователь не найден"); return; }
            Hide();
            Desktop desktop = new Desktop(account, DBProvider);
            desktop.ShowDialog();
            this.Close();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DBProvider != null) {
                DBProvider.DBProviderClosed();
            }
            
        }
    }
}
