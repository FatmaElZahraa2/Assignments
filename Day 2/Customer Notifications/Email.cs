using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Notifications
{
    internal class Email : INotifiable
    {
        public void Push()
        {
            Console.WriteLine("Email Notification was pushed");
        }
        public void Open()
        {
            Console.WriteLine("Email Notification was opened");
        }
        public void Content(string content)
        {
            Console.WriteLine("The Email notification says {0}",content);
        }
    }
}
