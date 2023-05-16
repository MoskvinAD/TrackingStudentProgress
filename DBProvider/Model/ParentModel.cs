using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class ParentModel
    {
        /// <summary>
        /// Ид
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; }
        /// <summary>
        /// Почта
        /// </summary>
        public string Emal { get; set; }
        /// <summary>
        /// Телеграмм
        /// </summary>
        public string Telegram { get; set; }
        /// <summary>
        /// id Ребёнка
        /// </summary>
        public string idChild { get; set; }
    }
}
