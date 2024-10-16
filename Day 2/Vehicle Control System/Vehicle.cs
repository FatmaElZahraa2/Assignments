using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Control_System
{
    abstract class Vehicle
    {
        public  void Start()
        {
            Console.WriteLine(GetType().Name + " started");
        }
        public  void Stop()
        {
            Console.WriteLine(GetType().Name + " stopped");
        }
        public abstract void Describe();
    }
}
