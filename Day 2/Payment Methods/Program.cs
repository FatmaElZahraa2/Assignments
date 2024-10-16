namespace Payment_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("To complete the payment process, you must choose one of the following methods ");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("1- Credit Card ");
            Console.WriteLine("2- Bank Transfer ");
            Console.WriteLine("3- PayPal");
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.Write("Your choice : ");

            int method = int.Parse(Console.ReadLine());

            Console.Write("And the Payed amount equals : ");

            IPayable wayOfPayment = null;

            double money = double.Parse(Console.ReadLine());

            if (method == 1)
                wayOfPayment = new CreditCardPayment();
            else if (method == 2)
                wayOfPayment = new BankTransfer();
            else if (method == 3)
                wayOfPayment= new PayPal();

            if (wayOfPayment != null)
                wayOfPayment.Payment_Process(money);
            else
                Console.WriteLine("Invalid choice");
            


        }

    }
}