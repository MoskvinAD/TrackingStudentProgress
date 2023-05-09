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
        string sqlConnection = @"Data Source=DESKTOP-7T5TKDF;Initial Catalog=test;Integrated Security=True";


        public DBProvider()
        {
            _connection = new SqlConnection(sqlConnection);
            _connection.Open();
        }

        public void DBProviderClosed()
        {
            _connection.Close();
        }

        /// <summary>
        /// Вход в аккаунт
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Account InputAccaunt(string Login, string pass)
        {
            Account account = new Account();              
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = $"SELECT top 1 * FROM Table_1 where name = '{Login}'";
                account.Id = (cmd.ExecuteScalar() as int?).GetValueOrDefault();
            }

            return account;
        }

    }
}
