using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    internal class Product
    {
        private double _price;
        private int _stockQuantity; 
        public string Name { get; set; }


        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }
        public int StockQuantity { 
            
            get { return _stockQuantity; }
            set
            {
                if (value >= 0)
                    _stockQuantity = value;
            }
        }

        public bool IsAvaliable
        {
            get
            {
                return StockQuantity > 0;
            }
        }

        

        public void UpdateStock(int stock) 
        {
           if (stock >= 0)
            {
                StockQuantity += stock;
            }
            else if (  StockQuantity >= (stock * -1))
            {
                StockQuantity += stock;
            }
        }

    }
}
