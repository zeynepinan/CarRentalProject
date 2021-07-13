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
            //CarTest();

            //ColorTest();

            //BrandTest();

            //UserTest();
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            User user = new User();
            user.FirstName = "Zeynep";
            user.LastName = "İnan";
            user.Email = "zeynep@gmail.com";
            user.Password = "123456";

            User user1 = new User();
            user1.FirstName = "Canan";
            user1.LastName = "Serper";
            user1.Email = "canan@gmail.com";
            user1.Password = "12345";

            User user2 = new User();
            user2.FirstName = "Aysu";
            user2.LastName = "Sarı";
            user2.Email = "aysu@gmail.com";
            user2.Password = "1234";

            userManager.Add(user);
            userManager.Add(user1);
            userManager.Add(user2);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Brand brand = new Brand();
            brandManager.Add(new Brand { BrandName = "Alfa Romeo" });
            brandManager.Update(new Brand { BrandId = 1, BrandName = " Alfa romeo" });
            brandManager.Delete(new Brand { BrandId = 1002 });

            //Console.WriteLine(brandManager.GetById(1).BrandName);

            //foreach (var b in brandManager.GetAll())
            //{
            //    Console.WriteLine(b.BrandName);
            //}
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Color color = new Color();
            colorManager.Add(new Color { ColorName = "Fıstık Yeşili" });
            colorManager.Update(new Color { ColorId = 1004, ColorName = "Koyu Yeşil" });
            colorManager.Delete(new Color { ColorId = 1003 });

            //Console.WriteLine(colorManager.GetById(7).ColorName);

            //foreach (var cl in colorManager.GetAll())
            //{
            //    Console.WriteLine(cl.ColorName);
            //}
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Car car = new Car();
            car.CarName = "Enzo Ferrari";
            car.BrandId = 4;
            car.ColorId = 6;
            car.ModelYear = "2000";
            car.DailyPrice = 0;
            car.Description = "F";


            var result1 = carManager.Add(car);
            if (result1.Success == false)
            {
                Console.WriteLine(result1.Message);
            }
            //carManager.Add(car);
            //carManager.Delete(new Car { CarId = 4002 });
            var result2 =carManager.Update(new Car
            {
                CarId = 1,
                BrandId = 1,
                ColorId = 1,
                ModelYear = "1990",
                DailyPrice = 150,
                Description = "8 kişilik",
                CarName = "Bmw"
            });
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);
            }


            //Console.WriteLine(carManager.GetById(1).CarName);

            //foreach (var c in carManager.GetCarsByBrandId(7))
            //{
            //    Console.WriteLine(c.Description);
            //}
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CarName + " / " + c.BrandName + " / " + c.ColorName + " / " + c.DailyPrice);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
