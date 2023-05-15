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
        public AccountEdit(Account account, DBProvider.DBProvider dBProvider)
        {
            InitializeComponent();
            DBProvider = dBProvider;
            Account = account;
        }
    }
}
