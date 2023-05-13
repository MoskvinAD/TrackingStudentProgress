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
        Account Account;
        public SheduleEdit(int index = 0,
            ScheduleModel scheduleModel = null,
            DBProvider.DBProvider dBProvider = null,
            Account account = null,
            bool addcheck = false)
        {           
            InitializeComponent();

            DBProvider = dBProvider;
            Account = account;
            Class.Text = Account.Class.ToString();

            AddProjectComboBox();
            if (addcheck)
            {
                delite.Visible = false;
                edit.Visible = false;
                ScheduleModel = new ScheduleModel();
                ScheduleModel.idClass = int.Parse(Account.Class);
            }
            else {
                Index = index;
                ScheduleModel = scheduleModel;                
                Date.Value = Convert.ToDateTime(ScheduleModel.Date);
                ProjectComboBox.Text = ProjectModelslist[ScheduleModel.idProject - 1].Name;
                add.Visible = false;
            }           
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

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            ScheduleModel.Date = Date.Value;
        }
    }
}
