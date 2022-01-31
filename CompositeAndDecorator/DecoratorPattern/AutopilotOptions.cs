using RentCar.CompositeAndDecorator.CompositePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.DecoratorPattern
{
    public class AutopilotOptions: ICarOptions
    {
        private Composite decoratedCar;

        public AutopilotOptions(Composite car)
        {
            this.decoratedCar = car;
        }

        public string getDescription()
        {
            return decoratedCar.showFullElements() + "+ Autopilot";
        }

        public double cost()
        {
            return decoratedCar.price + 150;
        }
    }
}
