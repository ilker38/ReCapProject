using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1=new Car{BrandId = 2,ColorId = 4,CarName = "Murat131",DailyPrice = 100,Description = "1976 Model Hacı Murat",ModelYear = 1976};
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(car1);
                        
            foreach (var car in carManager.GetAll())
            {
                
                Console.WriteLine(car.CarId + " - " + car.BrandId + " - " + car.ColorId + " - " + car.DailyPrice + " - " + car.ModelYear + " - " + car.Description);
            }

           
            
        }
    }
}
