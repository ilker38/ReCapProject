using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.RentalDeleted);
        }
    }
}
