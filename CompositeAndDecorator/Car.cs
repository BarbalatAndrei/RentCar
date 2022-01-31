using RentCar.CompositeAndDecorator.CarElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.CompositeAndDecorator
{
    public class Car
    {
        private CarComponents car = new CarComponents();

        public BackParktronics setParktonics()
        {
            return this.car.backParktronics = new BackParktronics().setBackParktronics("Sport Parktroniks", 8, 40);
        }

        public Dashboard setDashboard()
        {
            return this.car.dashboard = new Dashboard().setDashboard("Standard Dashboard", 60);
        }

        public Engine setEngine()
        {
            return this.car.engine = new Engine().setEngine("V4", "3.6", 200);
        }

        public Roof setRoof()
        {
            return this.car.roof = new Roof().setRoof("Half Transparent", "Half", 20);
        }

        public Seats setSeats()
        {
            return this.car.seats = new Seats().setSeats(4, "Alcantra", 140);
        }

        public TripComputer setTripComputer()
        {
            return this.car.tripComputer = new TripComputer().setTripComputer("Pioner", "Standard", 60);
        }

        public Trunk setTrunk()
        {
            return this.car.trunk = new Trunk().setTrunk("Automat", 10);
        }

        public WheelDrive setWheelDrive()
        {
            return this.car.wheelDrive = new WheelDrive().setWheelDrive("Standard WheelDrive", false, 35);
        }
    }
}
