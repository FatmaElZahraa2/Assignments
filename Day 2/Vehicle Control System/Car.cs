using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Control_System
{
    internal class Car : Vehicle
    {
        public override void Describe()
        {
            Console.WriteLine("A car is a four-wheeled motor vehicle designed for transporting passengers");
        }
    }
}
