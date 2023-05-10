using DBProvider;
using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackingStudentProgress.Forms
{
    public partial class SheduleEdit : Form
    {
        int Index;
        ScheduleModel ScheduleModel;
        DBProvider.DBProvider DBProvider;
        List<ProjectModel> ProjectModelslist;
        DataGridView DataGridViewSchedule;
        Account Account;
        public SheduleEdit(int index, ScheduleModel scheduleModel, DBProvider.DBProvider dBProvider, Account account)
        {           
            InitializeComponent();
            Account = account;
            Index = index;
            ScheduleModel = scheduleModel;
            DBProvider = dBProvider;
            label1.Text = Index.ToString();
            Class.Text = Account.Class.ToString();            
            Date.Value = Convert.ToDateTime(ScheduleModel.Date);
            AddProjectComboBox();
            ProjectComboBox.Text = ProjectModelslist[ScheduleModel.idProject - 1].Name;
        }

        private void AddProjectComboBox() {
            ProjectModelslist = DBProvider.GetProject();
            foreach (ProjectModel model in ProjectModelslist)
            {
                ProjectComboBox.Items.Add(model.Name);
            }
        }


        private void add_Click(object sender, EventArgs e)
        {
            if (DBProvider.SetSchedule(ScheduleModel)) {
                MessageBox.Show("Занятие добавлено");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (DBProvider.UpdareSchedule(ScheduleModel))
            {
                MessageBox.Show("Занятие было изменено");
            }
            
        }

        private void delite_Click(object sender, EventArgs e)
        {
            if (DBProvider.DeliteSchedule(ScheduleModel))
            {
                MessageBox.Show("Строка удалена");
            }
        }

        private void ProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScheduleModel.idProject = ProjectComboBox.SelectedIndex + 1;
        }
    }
}
