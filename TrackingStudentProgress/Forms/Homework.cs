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
        public Homework(int index, HomeWorkModel homeWork, DBProvider.DBProvider dBProvider, Account account)
        {
            InitializeComponent();
            Account = account;
            Index = index;
            DBProvider = dBProvider;
            HomeWork = homeWork;
            dateTimePickerDZs.Value = Convert.ToDateTime(homeWork.DateFrom);
            dateTimePickerDZpo.Value = Convert.ToDateTime(homeWork.DateTo);
            Description.Text = homeWork.Description;
            AddProjectComboBox();
            ProjectComboBox.Text = ProjectModelslist[homeWork.idProject - 1].Name;
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
            HomeWork.DateFrom = dateTimePickerDZs.Value;
            HomeWork.DateTo = dateTimePickerDZpo.Value;
            HomeWork.Description = Description.Text;

            if (DBProvider.UpdareHomeWork(HomeWork))
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
    }
}
