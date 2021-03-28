using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car{Id = 1,BrandId = 2,ColorId = 3,DailyPrice = 1500,ModelYear = 2012,Description = "2012 Model Araç"},
            new Car{Id = 2,BrandId = 3,ColorId = 8,DailyPrice = 4500,ModelYear = 2018,Description = "2018 Model Araç"},
            new Car{Id = 3,BrandId = 5,ColorId = 7,DailyPrice = 6500,ModelYear = 2019,Description = "2019 Model Araç"},
            new Car{Id = 4,BrandId = 4,ColorId = 5,DailyPrice = 8500,ModelYear = 2020,Description = "2020 Model Araç"},
            new Car{Id = 5,BrandId = 6,ColorId = 4,DailyPrice = 10500,ModelYear = 2021,Description = "2021 Model Araç"}

            };

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(int carId)
        {
            throw new NotImplementedException();
            //  Car getByCarId = _cars.SingleOrDefault(c => c.Id == carId);
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }
    }
}
