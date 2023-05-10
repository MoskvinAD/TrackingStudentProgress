using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class HomeWorkModel
    {
        /// <summary>
        /// Ид
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// id Предмета
        /// </summary>
        public int idProject { get; set; }
        /// <summary>
        /// id Класса
        /// </summary>
        public int idClass { get; set; }
        /// <summary>
        /// Дата начала
        /// </summary>
        public DateTime DateFrom { get; set; }
        /// <summary>
        /// Дата окончания
        /// </summary>
        public DateTime DateTo { get; set; }
        /// <summary>
        /// Описание задания
        /// </summary>
        public string Description { get; set; }

    }
}
