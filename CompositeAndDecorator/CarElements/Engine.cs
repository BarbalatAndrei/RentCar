using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CarElements
{
    public class Engine: ICar
    {
        public string model { get; set; }
        public string capacity { get; set; }
        public double price { get; set; }

        public Engine setEngine(string model, string capacity, double price)
        {
            this.model = model;
            this.capacity = capacity;
            this.price = price;

            return this;
        }

        public double getElementPrice()
        {
            return this.price;
        }

        public string showElementDetail(int el)
        {
            return this.capacity;
        }

        public string showFullElements()
        {
            return this.model + " engine | ";
        }
    }
}
