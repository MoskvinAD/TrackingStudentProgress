﻿using DBProvider;
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

namespace TrackingStudentProgress.Forms
{
    public partial class AccountEdit : Form
    {
        DBProvider.DBProvider DBProvider;
        Account Account;
        List<Account> AccountList;
        int idAccount = 1;
        int iClass = 0;
        int idPosition = 0;
        List<ClassModel> ClassModellist;
        List<PositionModel> PositionList;
        
        public AccountEdit(Account account, DBProvider.DBProvider dBProvider, List<ClassModel> classModellist)
        {
            InitializeComponent();
            DBProvider = dBProvider;
            Account = account;
            AddAccountComboBox();
            ClassModellist = classModellist;
            AddClassComboBox();
            AddPositionComboBox();
        }

        private void AddAccountComboBox()
        {
            AccountList = DBProvider.GetAccount();
            if (AccountList != null && AccountList.Count > 0)
            {
                comboBoxAccount.Items.Clear();
                foreach (Account model in AccountList)
                {
                    comboBoxAccount.Items.Add(model.SurName + " " + model.MidleName + " " + model.LastName);
                }
            }
        }

        private void AddClassComboBox()
        {
            if (ClassModellist != null && ClassModellist.Count > 0)
            {
                foreach (ClassModel model in ClassModellist)
                {
                    classcbox.Items.Add(model.Name);
                }
            }
        }

        private void AddPositionComboBox()
        {
            PositionList = DBProvider.GetPosition();
            if (PositionList != null && PositionList.Count > 0)
            {
                foreach (PositionModel model in PositionList)
                {
                    Position.Items.Add(model.Name);
                }
            }
        }

        private void comboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            idAccount = comboBoxAccount.SelectedIndex + 2;
            Account.Id = idAccount;
            foreach (Account account in AccountList)
            {
                if (account.Id == idAccount) {
                    Login.Text = account.Login;
                    Password.Text = account.Password;
                    FirstName.Text = account.SurName;
                    MidlName.Text = account.MidleName;
                    LastName.Text = account.LastName;
                    classcbox.Text = ClassModellist[int.Parse(account.Class) - 1].Name;
                    Position.Text = PositionList[int.Parse(account.Position) - 1].Name;
                }                
            }            
        }

        private void classcbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            iClass = classcbox.SelectedIndex + 1;
            Account.Class = iClass + "";
        }

        private void Position_SelectedIndexChanged(object sender, EventArgs e)
        {
            idPosition = Position.SelectedIndex + 1;
            Account.Position = idPosition + "";
        }

        private void addbt_Click(object sender, EventArgs e)
        {
            if (DBProvider.AddAccount(Account)) {
                MessageBox.Show("Сотрудник добавлен");
            }
            AddAccountComboBox();
        }

        private void editbt_Click(object sender, EventArgs e)
        {
            if (idAccount == 1) { MessageBox.Show("Выберите сотрудника из списка"); return; }
            if (DBProvider.UpdateAccount(Account)) {
                MessageBox.Show("Данные изменены");
            }
            AddAccountComboBox();
        }

        private void deletebt_Click(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            Account.Login = Login.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Account.Password = Password.Text;   
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
            Account.SurName = FirstName.Text;
        }

        private void MidlName_TextChanged(object sender, EventArgs e)
        {
            Account.MidleName = MidlName.Text;  
        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {
            Account.LastName = LastName.Text;
        }
    }
}
