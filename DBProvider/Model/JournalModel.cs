using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class JournalModel
    {
        /// <summary>
        /// Ид
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }        
        /// <summary>
        /// id Предмета
        /// </summary>
        public int idProject { get; set; }
        /// <summary>
        /// Название предмета
        /// </summary>
        public string nameProject { get; set; }
        /// <summary>
        /// Фамилия ученика
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Имя ученика
        /// </summary>
        public string MidleName { get; set; }
        /// <summary>
        /// Отчество ученика
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// id Ученика
        /// </summary>
        public int idStudent { get; set; }
        /// <summary>
        /// Оценка
        /// </summary>
        public string Cost { get; set; }

    }
}
