using RentCar.CompositeAndDecorator.CarElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator
{
    public class CarComponents
    {
        public BackParktronics backParktronics { get; set; }
        public Dashboard dashboard { get; set; }
        public Engine engine { get; set; }
        public Roof roof { get; set; }
        public Seats seats { get; set; }
        public TripComputer tripComputer { get; set; }
        public Trunk trunk { get; set; }
        public WheelDrive wheelDrive { get; set; }
    }
}
