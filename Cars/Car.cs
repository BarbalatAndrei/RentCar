using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Cars
{
    public class Car
    {
        public string Brand { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string VIN { get; set; }

        public Car insertCar(string Brand, int Price, string Status, string VIN)
        {
            this.Brand = Brand;
            this.Price = Price;
            this.Status = Status;
            this.VIN = VIN;
            return this;
        }
    }
}
