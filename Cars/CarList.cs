using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Cars
{
    public class CarList
    {
        public List<Car> cars = new List<Car>();

        public List<Car> GetCars()
        {
            cars.Add(new Car().insertCar("BMV M5 F90", 450, "Available", "4875412369541"));
            cars.Add(new Car().insertCar("Lamborghini Aventador", 590, "Unavailable", "2136547895412"));
            cars.Add(new Car().insertCar("Mercedes CLS 63 AMG", 510, "Available", "1236541002385"));
            cars.Add(new Car().insertCar("BMW X5", 540, "Available", "9632541256987"));

            return cars;
        }
    }
}
