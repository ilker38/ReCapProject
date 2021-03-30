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
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());
            
            AddMethod(rentalManager, carManager, colorManager, brandManager);
            
            foreach (var users in userManager.GetAll().Data)
            {
               // Console.WriteLine(users.FirstName + " - " + users.LastName + " - " + users.Email + " - " + users.Password);
            }
            foreach (var car in carManager.GetAll().Data)
            {
               //Console.WriteLine(car.CarId + " - " + car.BrandId + " - " + car.ColorId + " - " + car.DailyPrice + " - " + car.ModelYear + " - " + car.Description);
            }

        }

        private static void AddMethod(RentalManager rentalManager, CarManager carManager, ColorManager colorManager,
            BrandManager brandManager)
        {
            //Rental rental1 = new Rental {CarId = 5, CustomerId = 2, RentDate = new DateTime(2020, 07, 10)};
            //rentalManager.Add(rental1);
            //Car car1 = new Car{BrandId = 2, ColorId = 4, CarName = "Murat131", DailyPrice = 100, Description = "1976 Model Hacı Murat",ModelYear = 1976};
            //Brand brand1 = new Brand {Name = "LINCOLN"};
            //Color color1 = new Color {Name = "Turquoise"};
            //carManager.Add(car1);
            //colorManager.Add(color1);
            //brandManager.Add(brand1);
            //User user1 = new User{FirstName = "ilker", LastName = "Uras", Email = "deneme@mymail.com", Password = "12345"};
            //User user2 = new User {FirstName = "Engin", LastName = "Altan", Email = "enginaltan@mail.com", Password = "54321" };
            //userManager.Add(user1);
            //userManager.Add(user2);
            //Customer customer1 = new Customer {UserId = 2,CompanyName = "NoNameCompany"};
            //customerManager.Add(customer1);
        }
    }
}
