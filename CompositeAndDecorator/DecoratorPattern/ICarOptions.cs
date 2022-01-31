using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.DecoratorPattern
{
    public interface ICarOptions
    {
        public string getDescription();
        public double cost();
    }
}
