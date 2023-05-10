using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class ScheduleModel
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
        /// id Класса
        /// </summary>
        public int idClass { get; set; }
        /// <summary>
        /// id Предмета
        /// </summary>
        public int idProject { get; set; }
    }
}
