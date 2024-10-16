using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Methods
{
    internal interface IPayable
    {
         void Payment_Process(double PayedAmount);
    }
}
