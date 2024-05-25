using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class PriceLessZeroExseption: Exception
    {
        public PriceLessZeroExseption(string price) : base("Цена меньше нуля"){ }
    }
}
