using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());


            Car car = new Car();
            car.CarId = 6;
            car.BrandId = 7;
            car.ColorId = 3;
            car.ModelYear = "2000";
            car.DailyPrice = 123;
            car.Description = "ucuz ve güzel";

            carManager.Add(car);

            foreach (var c in carManager.GetAll())
            {

                Console.WriteLine(c.Description);
            }

        }
    }
}
