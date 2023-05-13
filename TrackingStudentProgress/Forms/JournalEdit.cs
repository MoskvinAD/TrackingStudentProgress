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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrackingStudentProgress.Forms
{
    public partial class JournalEdit : Form
    {
        int Index;
        DBProvider.DBProvider DBProvider;
        Account Account;
        JournalModel JournalModel;
        List<ProjectModel> ProjectModelslist;
        public JournalEdit(int index = 0, JournalModel journalModel = null, DBProvider.DBProvider dBProvider = null, Account account = null)
        {
            InitializeComponent();

            DBProvider = dBProvider;
            Account = account;
            JournalModel = journalModel;
            FIO.Text = journalModel.LastName + " " + journalModel.MidleName + " " + journalModel.FirstName;
            dateJuurnalContol.Value = journalModel.Date;
            Cost.Text = journalModel.Cost;
            AddProjectComboBox();
            ProjectComboBox.Text = ProjectModelslist[JournalModel.idProject - 1].Name;

        }
        private void AddProjectComboBox()
        {
            ProjectModelslist = DBProvider.GetProject();
            foreach (ProjectModel model in ProjectModelslist)
            {
                ProjectComboBox.Items.Add(model.Name);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void delite_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
