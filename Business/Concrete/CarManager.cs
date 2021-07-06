using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            
            if (car.Description.Length<=2 || car.DailyPrice<=0)
            {
                Console.WriteLine("Hata oluştu . Girdiğiniz bilgileri gözden geçiriniz." +
                    "Araba ismi minimum 2 karakter olmalıdır." +
                    "Araba günlük fiyatı 0'dan büyük olmalıdır.");
            }
            else
            {

                _carDal.Add(car);
            }
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p=>p.ColorId==colorId);
        }
    }
}
