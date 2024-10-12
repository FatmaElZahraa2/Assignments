using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }


        public Car(string Make, string Model, int Year, double Mileage)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Mileage = Mileage;
        }

        public int Age
        {

            get
            {
                return DateTime.Now.Year - Year;
            }

        }

        public void Drive(int distance)
        {
            if (distance > 0)
                Mileage += distance;
        }

    }
}
