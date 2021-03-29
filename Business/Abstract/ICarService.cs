using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GettAllByColorId(int id);
        List<Car> GettAllByBrandId(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<CarDetailDto> getCarDetails();
    }
}
