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
        JournalModel JournalModel;
        List<ProjectModel> ProjectModelslist;
        public JournalEdit(int index, JournalModel journalModel, DBProvider.DBProvider dBProvider)
        {
            InitializeComponent();
            DBProvider = dBProvider;
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
            if (Cost.Text == string.Empty || Cost.Text == null) {
                JournalModel.Cost = "Nan";
            }
            if (DBProvider.UpdateRowJournal(JournalModel))
            {
                MessageBox.Show("Изменения применены");
            }
        }

        private void Cost_TextChanged(object sender, EventArgs e)
        {
            JournalModel.Cost = Cost.Text;  
        }
    }
}
