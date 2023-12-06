using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProvider.Model
{
    public class NotificationModel
    {
        /// <summary>
        /// Email
        /// </summary>
        public List<string> Email { get; set; }
        /// <summary>
        /// subject
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// body
        /// </summary>
        public string Body { get; set; }
    }
}
