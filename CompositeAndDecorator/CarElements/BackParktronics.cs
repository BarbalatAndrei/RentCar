using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CarElements
{
    public class BackParktronics: ICar
    {
        public string model { get; set; }
        public int number { get; set; }
        public double price { get; set; }

        public BackParktronics setBackParktronics(string model, int number, double price)
        {
            this.model = model;
            this.number = number;
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
            return this.model + " | ";
        }
    }
}
