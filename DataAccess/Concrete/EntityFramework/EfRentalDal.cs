using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        //public List<RentalDetailDto> GetRentalDetails()
        //{
        //    //using (RentACarContext context=new RentACarContext())
        //    //{
        //    //    var result = from car in context.Cars
        //    //        join rental in context.Rentals on car.CarId equals rental.CarId
        //    //        select new RentalDetailDto
        //    //        {
        //    //            ReturnDate = rental.ReturnDate
        //    //        };
        //    //    return result.ToList();
        //    //}
        //}
    }
}
