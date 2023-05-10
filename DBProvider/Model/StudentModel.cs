using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class StudentModel
    {
        /// <summary>
        /// Ид Ученика
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string MidleName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateCreate { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Телеграмм
        /// </summary>
        public string Telegram { get; set; }
        /// <summary>
        /// id Класс
        /// </summary>
        public int idClass { get; set; }
        /// <summary>
        /// Класс
        /// </summary>
        public string NumberClass { get; set; }
        /// <summary>
        /// ФИО Матери
        /// </summary>
        public string FioM { get; set; }
        /// <summary>
        /// Почта Матери
        /// </summary>
        public string EmalM { get; set; }
        /// <summary>
        /// Телеграм Матери
        /// </summary>
        public string TelegramM { get; set; }
        /// <summary>
        /// id Матери
        /// </summary>
        public int idM { get; set; }
        /// <summary>
        /// ФИО Отца
        /// </summary>
        public string FioF { get; set; }
        /// <summary>
        /// Почта Отца
        /// </summary>
        public string EmalF { get; set; }
        /// <summary>
        /// Телеграмм Отца
        /// </summary>
        public string TelegramF { get; set; }
        /// <summary>
        /// id Отца
        /// </summary>
        public int idF { get; set; }
    }
}
