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
            car.BrandId = 5;
            car.ColorId = 1;
            car.ModelYear = "2004";
            car.DailyPrice = 250;
            car.Description = "Yeni araba";

            carManager.Add(car);

            foreach (var c in carManager.GetCarsByBrandId(7))
            {
                Console.WriteLine(c.Description);
            }
            

        }
    }
}
