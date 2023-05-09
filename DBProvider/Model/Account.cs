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
        /// ФИО сотрудника
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Логин сотрудника
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль сотрудника
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Флаг администратора
        /// </summary>
        public bool Administration { get; set; }
    }
}
