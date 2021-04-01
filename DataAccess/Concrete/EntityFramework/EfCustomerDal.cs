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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from u in context.Users
                    join c in context.Customers
                        on u.UserId equals c.UserId
                    select new CustomerDetailDto { UserId = u.UserId, FirstName = u.FirstName, CompanyName = c.CompanyName, Email = u.Email, LastName = u.LastName };
                return result.ToList();
            }
        }
    }
}
