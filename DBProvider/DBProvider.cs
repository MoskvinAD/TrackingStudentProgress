using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider
{
    public class DBProvider
    {
        SqlConnection _connection;
        string sqlConnection = @"Data Source=DESKTOP-7T5TKDF;Initial Catalog=TrackingStudentProgressBD;Integrated Security=True";


        public DBProvider()
        {
            _connection = new SqlConnection(sqlConnection);
            _connection.Open();
        }

        public void DBProviderClosed()
        {
            _connection.Close();
        }

        public Account InputAccaunt(string Login, string pass)
        {
            Account account = new Account();              
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = $"SELECT top 1 "
                    + "Account.id, "
                    + "Account.Login, "
                    + "Account.Password, "
                    + "Account.Surname, "
                    + "Account.FirstName, "
                    + "Account.MidlleName, "
                    + "Position.Position_Name, "
                    + "Class.NumberClass "
                    + "FROM Account "
                    + "left join Position "
                    + "on Position.id = Account.Position "
                    + "left join Class "
                    + "on Class.id = Account.Class "
                    + "where Login = 'admin' and Password = 'admin'";
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        account.Id = rdr.GetInt32(0);
                        account.Login = rdr.GetString(1);
                        account.Password = rdr.GetString(2);
                        account.SurName = rdr.GetString(3);
                        account.MidleName = rdr.GetString(4);
                        account.LastName = rdr.GetString(5);
                        account.Position = rdr.GetString(6);
                        account.Class = rdr.GetString(7);
                    }
                }
            }

            return account;
        }

    }
}
