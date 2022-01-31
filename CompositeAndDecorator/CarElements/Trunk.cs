using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CarElements
{
    public class Trunk: ICar
    {
        public string type { get; set; }
        public double price { get; set; }

        public Trunk setTrunk(string type, double price)
        {
            this.type = type;
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
            return this.type + " trunk | ";
        }
    }
}
