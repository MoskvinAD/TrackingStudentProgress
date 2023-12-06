using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using DBProvider.Model;
using System.Windows.Forms;
using TrackingStudentProgress.Forms;

namespace TrackingStudentProgress.Notifications
{
    public class NotificationCreater
    {
        public static void CreateMessageHomeWork(DBProvider.DBProvider DBProvider, HomeWorkModel HomeWork, string projectName) {
            NotificationModel notification = new NotificationModel();
            notification.Subject = $"Домашние задание по предмету ' {projectName}' ({HomeWork.DateFrom.ToString("yyyy.dd.MM")} - {HomeWork.DateTo.ToString("yyyy.dd.MM")})";
            notification.Body = $"<h2>{HomeWork.Description}</h2>";
            notification.Email = DBProvider.GetEmailsInHomeWork(HomeWork.idClass);          
            Notifications.Send(notification);
        }

        public static void CreateMessageJournal(DBProvider.DBProvider DBProvider, JournalModel JournalModel)
        {
            NotificationModel notification = new NotificationModel();
            notification.Subject = $"Выставлена оценка по предмету '{JournalModel.nameProject}' ({JournalModel.Date.ToString("yyyy.dd.MM")})";
            notification.Body = $"<h2>Результат: {JournalModel.Cost}</h2>";
            notification.Email = DBProvider.GetEmailsInidStudent(JournalModel.idStudent);
            Notifications.Send(notification);
        }
    }
}
