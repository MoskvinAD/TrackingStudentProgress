using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBProvider;
using DBProvider.Model;
using TrackingStudentProgress.Forms;

namespace TrackingStudentProgress
{
    public partial class Authorization : Form
    {
        DBProvider.DBProvider DBProvider;
        Account Account;
        List<ClassModel> ClassModellist;
        int iClass = 0;
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
            Account = DBProvider.InputAccaunt(Login.Text, Password.Text);
            if (Account.Id == 0) { MessageBox.Show("Пользователь не найден"); return; }
            if (Account.Position == "Преподаватель") {
                Hide();
                Desktop desktop = new Desktop(Account, DBProvider);
                desktop.ShowDialog();
                this.Close();
            } else if (Account.Position == "Администратор") {
                panelAdmin.Visible = true;
                Authorizationbt.Visible = false;

                AddClassComboBox();
            }       
        }

        private void AddClassComboBox()
        {
            ClassModellist = DBProvider.GetClass();
            if (ClassModellist != null && ClassModellist.Count > 0)
            {
                foreach (ClassModel model in ClassModellist)
                {
                    classcbox.Items.Add(model.Name);
                }
            }            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (DBProvider != null) {
                DBProvider.DBProviderClosed();
            }
            
        }

        private void Desktopbt_Click(object sender, EventArgs e)
        {
            if (iClass == 0) { MessageBox.Show("Выберите Класс"); return; }
            Hide();
            Account.Class = iClass+"";
            Desktop desktop = new Desktop(Account, DBProvider);
            desktop.ShowDialog();
            this.Close();
        }

        private void classcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            iClass = classcbox.SelectedIndex + 1;
        }

        private void AccountEditbt_Click(object sender, EventArgs e)
        {
            AccountEdit accountEdit = new AccountEdit(Account, DBProvider, ClassModellist);
            accountEdit.ShowDialog();
        }

        private void ParentsEditbt_Click(object sender, EventArgs e)
        {
            ParentsEdit parentsEdit = new ParentsEdit(Account, DBProvider);
            parentsEdit.ShowDialog();
        }

        private void StudentEditbt_Click(object sender, EventArgs e)
        {
            StudentEdit studentEdit = new StudentEdit(Account, DBProvider);
            studentEdit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
