using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Notifications
{
    internal class CentralCutomerNotification
    {

        public void PushNotification(INotifiable notify)
        {
            notify.Push();
        }
        public void OpenNotification(INotifiable notify)
        {
            notify.Open();
        }
        public void NotificationContent(INotifiable notify , string content)
        {
            notify.Content(content);    
        }
    }
}
