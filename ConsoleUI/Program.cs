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
            car.CarName = "Enzo Ferrari";
            car.BrandId = 4;
            car.ColorId = 6;
            car.ModelYear = "2000";
            car.DailyPrice = 230;
            car.Description = "Ferrari çok iyi";

            carManager.Add(car);

            //foreach (var c in carManager.GetCarsByBrandId(7))
            //{
            //    Console.WriteLine(c.Description);
            //}
            foreach (var c in carManager.GetCarDetails() )
            {
                Console.WriteLine(c.CarName+" / "+ c.BrandName+" / "+c.ColorName +" / "+ c.DailyPrice );
            }

        }
    }
}
