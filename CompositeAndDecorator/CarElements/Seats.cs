using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CarElements
{
    public class Seats: ICar
    {
        public int number { get; set; }
        public string material { get; set; }
        public double price { get; set; }

        public Seats setSeats(int number, string material, double price)
        {
            this.number = number;
            this.material = material;
            this.price = price;

            return this;
        }

        public double getElementPrice()
        {
            return this.price;
        }

        public string showElementDetail(int el)
        {
            return this.material;
        }

        public string showFullElements()
        {
            return this.number + " seats | ";
        }
    }
}
