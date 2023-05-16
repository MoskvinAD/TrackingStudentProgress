using DBProvider.Model;
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

namespace TrackingStudentProgress.Forms
{
    public partial class StudentEdit : Form
    {
        DBProvider.DBProvider DBProvider;
        Account Account;
        StudentModel StudentModels;
        List<ClassModel> ClassModellist;
        List<ParentModel> ParentModelsList;
        List<StudentModel> StudentModelList;
        public StudentEdit(Account account, DBProvider.DBProvider dBProvider)
        {
            InitializeComponent();
            DBProvider = dBProvider;
            Account = account;
            StudentModels = new StudentModel();
            StudentModels.Id = 0;
            Addstudentbox();
            AddcomboBoxParent();
            AddClassComboBox();
        }

        private void editbt_Click(object sender, EventArgs e)
        {
            if (StudentModels.Id == 0) { MessageBox.Show("Выберите ученика из списка"); return; }
            if (DBProvider.UpdateStudent(StudentModels))
            {
                MessageBox.Show("Данные изменены");
            }
            Addstudentbox();
        }

        private void addbt_Click(object sender, EventArgs e)
        {
            if (DBProvider.AddStudent(StudentModels))
            {
                MessageBox.Show("Ученик добавлен");
            }
            Addstudentbox();
            
        }

        private void Addstudentbox()
        {
            StudentModelList = DBProvider.GetAllStudentModel();
            if (StudentModelList != null && StudentModelList.Count > 0)
            {
                studentbox.Items.Clear();
                foreach (StudentModel model in StudentModelList)
                {
                    studentbox.Items.Add(model.LastName + " " + model.MidleName + " " + model.FirstName);
                }
            }
        }

        private void AddClassComboBox()
        {
            ClassModellist = DBProvider.GetClass();
            if (ClassModellist != null && ClassModellist.Count > 0)
            {
                foreach (ClassModel model in ClassModellist)
                {
                    classbox.Items.Add(model.Name);
                }
            }
        }
        private void AddcomboBoxParent()
        {
            ParentModelsList = DBProvider.GetParentList();
            if (ParentModelsList != null && ParentModelsList.Count > 0)
            {
                foreach (ParentModel model in ParentModelsList)
                {
                    FazerBox.Items.Add(model.FIO);
                    Mazerbox.Items.Add(model.FIO);
                }
            }
        }


        private void studentbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = studentbox.SelectedIndex + 5;
            foreach (StudentModel student in StudentModelList)
            {
                if (student.Id == index)
                {
                    StudentModels.Id = index;
                    FStudent.Text = student.LastName;
                    NStudent.Text = student.MidleName;
                    OStudent.Text = student.FirstName;
                    DateBirth.Value = student.DateCreate;
                    Email.Text = student.Email;
                    Telegram.Text = student.Telegram;
                    FazerBox.Text = ParentModelsList[student.idF - 1].FIO;
                    Mazerbox.Text = ParentModelsList[student.idM - 1].FIO;
                    classbox.Text = ClassModellist[student.idClass - 1].Name;                    
                }
            }
        }

        private void FazerBox_SelectedValueChanged(object sender, EventArgs e)
        {
            StudentModels.idF = FazerBox.SelectedIndex + 1;
        }

        private void Mazerbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentModels.idM = Mazerbox.SelectedIndex + 1;
        }

        private void classbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentModels.idClass = classbox.SelectedIndex + 1;
        }

        private void FStudent_TextChanged(object sender, EventArgs e)
        {
            StudentModels.LastName = FStudent.Text;
        }

        private void NStudent_TextChanged(object sender, EventArgs e)
        {
            StudentModels.MidleName = NStudent.Text;
        }

        private void OStudent_TextChanged(object sender, EventArgs e)
        {
            StudentModels.FirstName = OStudent.Text;
        }

        private void DateBirth_ValueChanged(object sender, EventArgs e)
        {
            StudentModels.DateCreate = DateBirth.Value;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            StudentModels.Email = Email.Text;
        }

        private void Telegram_TextChanged(object sender, EventArgs e)
        {
            StudentModels.Telegram = Telegram.Text;
        }       
    }
}
