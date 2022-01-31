using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator.CompositePattern
{
    public interface ICar
    {
        public double getElementPrice();
        public string showElementDetail(int el);
        public string showFullElements();
    }
}
