﻿using DBProvider.Model;
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
        public List<ProjectModel> GetProject()
        {
            List<ProjectModel> projectsList = new List<ProjectModel>();
            using (var cmd = _connection.CreateCommand())
            {
                cmd.CommandText = $"SELECT "                   
                    + "Project.id,"
                    + "Project.Name "
                    + "FROM Project";
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        ProjectModel project = new ProjectModel();
                        project.Id = rdr.GetInt32(0);
                        project.Name = rdr.GetString(1);
                        projectsList.Add(project);
                    }
                }
            }
            return projectsList;
        }

        public bool SetSchedule(ScheduleModel schedule)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO Schedule VALUES ('{schedule.Date.ToString("yyyy-dd-MM HH:mm:ss:fff")}',{schedule.idClass},{schedule.idProject})";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
               return false;
            }
            return true;
        }

        public bool DeliteSchedule(ScheduleModel schedule)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Delete from Schedule Where id = '{schedule.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdareSchedule(ScheduleModel schedule)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Update Schedule set Date = '{schedule.Date}' ,  idClass = '{schedule.idClass}' ,  idProject = '{schedule.idProject}'  Where id = '{schedule.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool SetHomeWork(HomeWorkModel HomeWork)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO HomeWork VALUES ({HomeWork.idProject}," +
                        $"{HomeWork.idClass}," +
                        $"'{HomeWork.DateFrom}'," +
                        $"'{HomeWork.DateTo}'," +
                        $"'{HomeWork.Description}')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeliteHomeWork(HomeWorkModel HomeWork)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Delete from HomeWork Where id = '{HomeWork.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UpdareHomeWork(HomeWorkModel HomeWork)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Update HomeWork set idProject = '{HomeWork.idProject}' ,  idClass = '{HomeWork.idClass}' ,  DateFrom = '{HomeWork.DateFrom}' ,  DateTo = '{HomeWork.DateTo}' ,  Description = '{HomeWork.Description}'  Where id = '{HomeWork.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

    }
}
