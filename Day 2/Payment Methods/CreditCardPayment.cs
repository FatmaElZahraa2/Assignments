using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    internal class CreditCardPayment : IPayable
    {
        public void Payment_Process(double PayedAmount)
        {
            Console.WriteLine("This Process was done by using Credit Card Method and the payed amount equals {0} ", PayedAmount);
        }
    }
}
