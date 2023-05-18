using DBProvider.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NLog;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBProvider
{
    public class DBProvider
    {
        SqlConnection _connection;
        string sqlConnection = @"Data Source=DESKTOP-7T5TKDF;Initial Catalog=TrackingStudentProgressBD;Integrated Security=True";

        Logger log = LogManager.GetCurrentClassLogger();

        public DBProvider()
        {
            try
            {
                _connection = new SqlConnection(sqlConnection);
                _connection.Open();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }                        
        }

        public void DBProviderClosed()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            
        }

        public Account InputAccaunt(string Login, string pass)
        {
            log.Info($"START InputAccaunt: {Login} {pass}");
            Account account = new Account();
            try
            {                
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
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return account;
        }
        public List<ProjectModel> GetProject()
        {
            List<ProjectModel> projectsList = new List<ProjectModel>();
            try
            {
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
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }
           
            return projectsList;
        }

        public List<ClassModel> GetClass()
        {
            List<ClassModel> classList = new List<ClassModel>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT "
                        + "Class.id,"
                        + "Class.NumberClass "
                        + "FROM Class";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ClassModel classM = new ClassModel();
                            classM.Id = rdr.GetInt32(0);
                            classM.Name = rdr.GetString(1);
                            classList.Add(classM);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return classList;
        }       

        public List<Account> GetAccount()
        {
            List<Account> AccountList = new List<Account>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT *"
                        + "FROM Account";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Account classM = new Account();
                            classM.Id = rdr.GetInt32(0);
                            classM.Login = rdr.GetString(1);
                            classM.Password = rdr.GetString(2);
                            classM.SurName = rdr.GetString(3);
                            classM.MidleName = rdr.GetString(4);
                            classM.LastName = rdr.GetString(5);
                            classM.Position = rdr.GetInt32(6).ToString();
                            classM.Class = rdr.GetInt32(7).ToString();                            
                            AccountList.Add(classM);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return AccountList;
        }

        public List<PositionModel> GetPosition()
        {
            List<PositionModel> PositionList = new List<PositionModel>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT *"
                        + "FROM Position";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            PositionModel Position = new PositionModel();
                            Position.Id = rdr.GetInt32(0);
                            Position.Name = rdr.GetString(1);                           
                            PositionList.Add(Position);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return PositionList;
        }

        public List<StudentModel> GetStudentinidClass(int idClass)
        {
            List<StudentModel> StudentList = new List<StudentModel>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT Student.id,Student.LastName, Student.FirstName, Student.MidleName FROM Student WHERE Student.idClass = {idClass} ";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            StudentModel student = new StudentModel();
                            student.Id = rdr.GetInt32(0);
                            student.LastName = rdr.GetString(1);
                            student.FirstName = rdr.GetString(2);
                            student.MidleName = rdr.GetString(3);
                            StudentList.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }
           
            return StudentList;
        }

        public List<StudentModel> GetAllStudent()
        {
            List<StudentModel> StudentList = new List<StudentModel>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT Student.id,Student.LastName, Student.FirstName, Student.MidleName FROM Student";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            StudentModel student = new StudentModel();
                            student.Id = rdr.GetInt32(0);
                            student.LastName = rdr.GetString(1);
                            student.FirstName = rdr.GetString(2);
                            student.MidleName = rdr.GetString(3);
                            StudentList.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return StudentList;
        }

        public List<StudentModel> GetAllStudentModel()
        {
            List<StudentModel> StudentList = new List<StudentModel>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT Student.id" +
                        $",Student.LastName" +
                        $", Student.FirstName" +
                        $", Student.MidleName" +
                        $", Student.DateCreate" +
                        $", Student.Email" +
                        $", Student.Telegram" +
                        $", Student.idClass" +
                        $", Student.idParentM" +
                        $", Student.idParentF" +
                        $" FROM Student";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            StudentModel student = new StudentModel();
                            student.Id = rdr.GetInt32(0);
                            student.LastName = rdr.GetString(1);
                            student.FirstName = rdr.GetString(2);
                            student.MidleName = rdr.GetString(3);
                            student.DateCreate = rdr.GetDateTime(4);
                            student.Email = rdr.GetString(5);
                            student.Telegram = rdr.GetString(6);
                            student.idClass = rdr.GetInt32(7);
                            student.idM = rdr.GetInt32(8);
                            student.idF = rdr.GetInt32(9);
                            StudentList.Add(student);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return StudentList;
        }

        public int GetScheduleCount(int idClass,int idProject, DateTime date)
        {
            int count = 0;
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"select count(*) as count from Schedule where Schedule.Date >= '{Helper.StartOfDay(date)}' and Schedule.Date <= '{Helper.EndOfDay(date)}' and Schedule.idClass = {idClass} and Schedule.idProject = {idProject}";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            count = rdr.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex )
            {

                log.Error(ex.Message);
            }
           
            return count;
        }

        public void SetJournalStudent(int idProject, DateTime date, List<StudentModel> stModel )
        {
            try
            {
                foreach (StudentModel student in stModel)
                {
                    using (var cmd = _connection.CreateCommand())
                    {
                        cmd.CommandText = $"INSERT INTO Journal VALUES ('{date}'," +
                            $"{idProject}," +
                            $"'{student.Id}', 'Nan')";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
                          
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
                log.Error(ex.Message);
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
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool UpdateSchedule(ScheduleModel schedule)
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
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool UpdateRowJournal(JournalModel journal)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Update Journal set Cost = '{journal.Cost}' Where id = '{journal.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
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
                log.Error(ex.Message);
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
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool UpdateHomeWork(HomeWorkModel HomeWork)
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
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool AddAccount(Account account)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO Account VALUES ('{account.Login}'," +
                        $"'{account.Password}'," +
                        $"'{account.SurName}'," +
                        $"'{account.MidleName}'," +
                         $"'{account.LastName}'," +
                          $"'{account.Position}'," +
                        $"'{account.Class}')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool UpdateAccount(Account account)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Update Account set Login = '{account.Login}' ," +
                        $"  Password = '{account.Password}' ," +
                        $"  SurName = '{account.SurName}' ," +
                        $"  MidlleName = '{account.LastName}' ," +
                        $"  FirstName = '{account.MidleName}' ," +
                        $"  Position = '{account.Position}' ," +
                        $"  Class = '{account.Class}'" +
                        $"  Where id = '{account.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool UpdateParent(ParentModel parent)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Update Parent set FIO = '{parent.FIO}' ," +
                        $"  Emal = '{parent.Emal}' ," +
                        $"  Telegram = '{parent.Telegram}' ," +
                        $"  idChild = '{parent.idChild}'" +
                        $"  Where id = '{parent.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool UpdateStudent(StudentModel student)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"Update Student set" +
                        $" LastName = '{student.LastName}' ," +
                        $"  FirstName = '{student.FirstName}' ," +
                        $"  MidleName = '{student.MidleName}' ," +
                        $"  DateCreate = '{student.DateCreate}' ," +
                        $"  Email = '{student.Email}' ," +
                        $"  Telegram = '{student.Telegram}' ," +
                        $"  idClass = '{student.idClass}' ," +
                        $"  idParentM = '{student.idM}' ," +
                        $"  idParentF = '{student.idF}'" +
                        $"  Where id = '{student.Id}'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool AddStudent(StudentModel student)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO Student VALUES (" +
                        $"'{student.LastName}'," +
                        $"'{student.FirstName}'," +
                        $"'{student.MidleName}'," +
                        $"'1'," +
                        $"'{student.DateCreate}'," +
                        $"'{student.Email}'," +
                        $"'{student.Telegram}'," +
                        $"'{student.idClass}'," +
                        $"'{student.idM}'," +
                        $"'{student.idF}')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public bool AddParent(ParentModel parent)
        {
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO Parent VALUES ('{parent.FIO}'," +
                        $"'{parent.Emal}'," +
                        $"'{parent.Telegram}'," +
                        $"'{parent.idChild}')";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return false;
            }
            return true;
        }

        public List<ParentModel> GetParentList()
        {
            List<ParentModel> ParentList = new List<ParentModel>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"SELECT *"
                        + "FROM Parent";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            ParentModel parent = new ParentModel();
                            parent.Id = rdr.GetInt32(0);
                            parent.FIO = rdr.GetString(1);
                            parent.Emal = rdr.GetString(2);
                            parent.Telegram = rdr.GetString(3);
                            parent.idChild = rdr.GetInt32(4).ToString();
                            ParentList.Add(parent);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            return ParentList;
        }

        public List<string> GetEmailsInHomeWork(int idClass)
        {
            List<string> Emails = new List<string>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"select Email from Student where Student.idClass = '{idClass}'";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Emails.Add(rdr.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return Emails;
        }

        public List<string> GetEmailsInidStudent(int idStudent)
        {
            List<string> Emails = new List<string>();
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = $"select Email from Student where Student.id = '{idStudent}'";
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Emails.Add(rdr.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return Emails;
        }
        public List<string> GetJournalCostByTelegram(string telegram)
        {
            List<string> listStr = new List<string>();
            try
            {
                // название процедуры
                string sqlExpression = "GetJournalCostByTelegram";

                SqlCommand command = new SqlCommand(sqlExpression, _connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@telegram",
                    Value = telegram
                };
                // добавляем параметр
                 command.Parameters.Add(nameParam);
                 var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        log.Error($"{reader.GetDateTime(0).ToString("yyyy-dd-MM")} {reader.GetString(1)} {reader.GetString(2)}");
                        listStr.Add($"{reader.GetDateTime(0).ToString("yyyy-dd-MM")} {reader.GetString(1)} : {reader.GetString(2)}");
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return listStr;
        }

        public List<string> GetHomeWorktByTelegram(string telegram)
        {
            List<string> listStr = new List<string>();
            try
            {
                // название процедуры
                string sqlExpression = "GetHomeWorktByTelegram";

                SqlCommand command = new SqlCommand(sqlExpression, _connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@telegram",
                    Value = telegram
                };
                // добавляем параметр
                command.Parameters.Add(nameParam);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        log.Error($"{reader.GetDateTime(0).ToString("yyyy-dd-MM")} {reader.GetString(1)} {reader.GetString(2)}");
                        listStr.Add($"{reader.GetDateTime(0).ToString("yyyy-dd-MM")} {reader.GetString(1)} : {reader.GetString(2)}");
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return listStr;
        }

        public List<string> GetScheduletByTelegram(string telegram)
        {
            List<string> listStr = new List<string>();
            try
            {
                // название процедуры
                string sqlExpression = "GetScheduletByTelegram";

                SqlCommand command = new SqlCommand(sqlExpression, _connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                // параметр для ввода имени
                SqlParameter nameParam = new SqlParameter
                {
                    ParameterName = "@telegram",
                    Value = telegram
                };
                // добавляем параметр
                command.Parameters.Add(nameParam);
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        log.Error($"{reader.GetDateTime(0).ToString("yyyy-dd-MM")} {reader.GetString(1)}");
                        listStr.Add($"{reader.GetDateTime(0).ToString("yyyy-dd-MM")} {reader.GetString(1)}");
                    }
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
            }

            return listStr;
        }

    }
}
