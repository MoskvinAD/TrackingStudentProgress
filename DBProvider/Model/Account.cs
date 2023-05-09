using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class Account
    {
        /// <summary>
        /// Ид сотудника
        /// </summary>
        public int Id { get; set; }     
        /// <summary>
        /// Логин сотрудника
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль сотрудника
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string MidleName { get; set; }
        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Класс
        /// </summary>
        public string Class { get; set; }
    }
}
