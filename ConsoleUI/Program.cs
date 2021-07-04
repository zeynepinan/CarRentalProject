using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            Car car = new Car();
            car.BrandId = 7;
            car.ColorId = 3;
            car.ModelYear = "2000";
            car.DailyPrice = 0;
            car.Description = "ucuz ve güzel";

            carManager.Add(car);

            foreach (var c in carManager.GetCarsByBrandId(7))
            {
                Console.WriteLine(c.Description);
            }
            

        }
    }
}
