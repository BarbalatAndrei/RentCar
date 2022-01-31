using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CarElements
{
    public class TripComputer: ICar
    {
        public string model { get; set; }
        public string type { get; set; }
        public double price { get; set; }

        public TripComputer setTripComputer(string model, string type, double price)
        {
            this.model = model;
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
            return this.model;
        }

        public string showFullElements()
        {
            return this.model + " tripComputer | ";
        }
    }
}
