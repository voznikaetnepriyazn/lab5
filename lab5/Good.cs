using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Good
    {
        protected decimal price;
        public decimal Price 
        {
            get { return price; }
            set { 
                if (value < 0) 
                {
                    price = 0;
                }
                price = value;
            } 
        }
        public Good()
        {
            Price = price; 
        }
        

    }
}
