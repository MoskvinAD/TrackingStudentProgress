using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackingStudentProgress.Forms
{
    public partial class Homework : Form
    {
        int Index;
        DBProvider.DBProvider DBProvider;
        List<ProjectModel> ProjectModelslist;
        Account Account;
        HomeWorkModel HomeWork;
        public Homework(int index = 0, HomeWorkModel homeWork = null, DBProvider.DBProvider dBProvider = null, Account account = null, bool addcheck = false)
        {
            InitializeComponent();

            Account = account;
            Index = index;
            DBProvider = dBProvider;
            AddProjectComboBox();
            if (addcheck)
            {
                HomeWork = new HomeWorkModel();
                delite.Visible = false;
                edit.Visible = false;
                HomeWork.idClass = int.Parse(Account.Class);
            }
            else {
                HomeWork = homeWork;
                dateTimePickerDZs.Value = Convert.ToDateTime(homeWork.DateFrom);
                dateTimePickerDZpo.Value = Convert.ToDateTime(homeWork.DateTo);
                Description.Text = homeWork.Description;                
                ProjectComboBox.Text = ProjectModelslist[homeWork.idProject - 1].Name;
                add.Visible = false;
            }
            
        }

        private void AddProjectComboBox()
        {
            ProjectModelslist = DBProvider.GetProject();
            foreach (ProjectModel model in ProjectModelslist)
            {
                ProjectComboBox.Items.Add(model.Name);
            }
        }

        private void ProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeWork.idProject = ProjectComboBox.SelectedIndex + 1;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (DBProvider.SetHomeWork(HomeWork))
            {
                MessageBox.Show("Задание добавлено");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDZpo.Value < dateTimePickerDZs.Value) {
                MessageBox.Show("Дата начала больше даты окончания");
                return;
            }
            HomeWork.DateFrom = dateTimePickerDZs.Value;
            HomeWork.DateTo = dateTimePickerDZpo.Value;
            HomeWork.Description = Description.Text;

            if (DBProvider.UpdateHomeWork(HomeWork))
            {
                MessageBox.Show("Задание было изменено");
            }

        }

        private void delite_Click(object sender, EventArgs e)
        {
            if (DBProvider.DeliteHomeWork(HomeWork))
            {
                MessageBox.Show("Задание удалено");
            }
        }

        private void Description_TextChanged(object sender, EventArgs e)
        {
            HomeWork.Description = Description.Text;
        }

        private void dateTimePickerDZs_ValueChanged(object sender, EventArgs e)
        {
            HomeWork.DateFrom = dateTimePickerDZs.Value;
        }

        private void dateTimePickerDZpo_ValueChanged(object sender, EventArgs e)
        {
            HomeWork.DateTo = dateTimePickerDZpo.Value;
        }
    }
}
