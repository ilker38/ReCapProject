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
            //Car car1=new Car{BrandId = 2,ColorId = 4,CarName = "Murat131",DailyPrice = 100,Description = "1976 Model Hacı Murat",ModelYear = 1976};
            //Brand brand1 = new Brand {Name = "LINCOLN"};
            //Color color1 = new Color {Name = "Turquoise"};
            
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            

            //carManager.Add(car1);
            //colorManager.Add(color1);
            //brandManager.Add(brand1);
            
            
            
            foreach (var car in carManager.GetAll())
            {
               
                //Console.WriteLine(car.CarId + " - " + car.BrandId + " - " + car.ColorId + " - " + car.DailyPrice + " - " + car.ModelYear + " - " + car.Description);
            }

           
            
        }
    }
}
