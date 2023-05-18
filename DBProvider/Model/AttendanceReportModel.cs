using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class AttendanceReportModel
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string FIO { get; set; }
        /// <summary>
        /// Количество пропусков
        /// </summary>
        public int Count { get; set; }
    }
}
