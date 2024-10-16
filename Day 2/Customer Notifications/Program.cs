namespace Customer_Notifications
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CentralCutomerNotification centralCutomerNotification = new CentralCutomerNotification();
            INotifiable n1 = new Email();
            INotifiable n2 = new SMS();

            centralCutomerNotification.PushNotification(n1);
            centralCutomerNotification.OpenNotification(n2);

            centralCutomerNotification.NotificationContent(n1, "This is a test");
        }
    }
}