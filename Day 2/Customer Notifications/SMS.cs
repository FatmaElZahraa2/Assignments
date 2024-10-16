using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Notifications
{
    internal class SMS :INotifiable
    {
        public void Push()
        {
            Console.WriteLine("SMS Notification was pushed");
        }
        public void Open()
        {
            Console.WriteLine("SMS Notification was opened");
        }
        public void Content(string content)
        {
            Console.WriteLine("The SMS notification says {0}", content);
        }
    }
}
