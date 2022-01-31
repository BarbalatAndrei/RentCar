using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CarElements
{
    public class Roof: ICar
    {
        public string type { get; set; }
        public string length { get; set; }
        public double price { get; set; }

        public Roof setRoof(string type, string length, double price)
        {
            this.type = type;
            this.length = length;
            this.price = price;

            return this;
        }

        public double getElementPrice()
        {
            return this.price;
        }

        public string showElementDetail(int el)
        {
            return this.type;
        }

        public string showFullElements()
        {
            return this.type + " roof | ";
        }
    }
}
