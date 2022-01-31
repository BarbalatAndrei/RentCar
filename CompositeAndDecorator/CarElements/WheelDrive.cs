using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CarElements
{
    public class WheelDrive: ICar
    {
        public string model { get; set; }
        public bool backFront { get; set; }
        public double price { get; set; }

        public WheelDrive setWheelDrive(string model, bool backFront, double price)
        {
            this.model = model;
            this.backFront = backFront;
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
            return this.model + " wheelDrive | ";
        }
    }
}
