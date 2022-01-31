using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator
{
    public class Client
    {
        public Car getCar()
        {
            return new Car();
        }
    }
}
