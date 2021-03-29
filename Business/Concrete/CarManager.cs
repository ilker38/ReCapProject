using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GettAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GettAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
            }else
            {
                throw new Exception("Araç Adı minimum 2 Karakter olmalıdır ve Araç Günlük Kiralama Tutarı 0 TL'den yüksek olmalıdır");
            }

        }
        
        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.GetAll(c => c.BrandId == car.BrandId);
            _carDal.Delete(car);
        }

        public List<CarDetailDto> getCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
