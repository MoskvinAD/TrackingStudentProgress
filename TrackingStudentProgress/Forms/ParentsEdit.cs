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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TrackingStudentProgress.Forms
{
    public partial class ParentsEdit : Form
    {
        DBProvider.DBProvider DBProvider;
        Account Account;
        List<ParentModel> ParentModelsList;
        ParentModel Parent;

        public ParentsEdit(Account account, DBProvider.DBProvider dBProvider)
        {
            InitializeComponent();
            DBProvider = dBProvider;
            Account = account;
            AddcomboBoxParent();
            Parent = new ParentModel();
            Parent.Id = 0;
            Parent.idChild = "0";
        }

        private void AddcomboBoxParent()
        {
            ParentModelsList = DBProvider.GetParentList();
            if (ParentModelsList != null && ParentModelsList.Count > 0)
            {
                comboBoxParent.Items.Clear();
                foreach (ParentModel model in ParentModelsList)
                {
                    comboBoxParent.Items.Add(model.FIO);
                }
            }
        }

        private void editbt_Click(object sender, EventArgs e)
        {
            if (Parent.Id == 0) { MessageBox.Show("Выберите родителя из списка"); return; }
            if (DBProvider.UpdateParent(Parent))
            {
                MessageBox.Show("Данные изменены");
            }
            AddcomboBoxParent();
        }

        private void addbt_Click(object sender, EventArgs e)
        {
            if (DBProvider.AddParent(Parent))
            {
                MessageBox.Show("Родитель добавлен");
            }
            AddcomboBoxParent();
        }

        private void deletebt_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxParent.SelectedIndex + 1;
            foreach (ParentModel parent in ParentModelsList)
            {
                if (parent.Id == index)
                {
                    Parent.Id = index;
                    FIO.Text = parent.FIO;
                    emal.Text = parent.Emal;
                    telegram.Text = parent.Telegram;                   
                }
            }
        }

        private void FIO_TextChanged(object sender, EventArgs e)
        {
            Parent.FIO = FIO.Text;
        }

        private void emal_TextChanged(object sender, EventArgs e)
        {
            Parent.Emal = emal.Text;
        }

        private void telegram_TextChanged(object sender, EventArgs e)
        {
            Parent.Telegram = telegram.Text;
        }

       
    }
}
