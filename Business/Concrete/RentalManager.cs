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
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }
        /*Altta yazılan if şart bloğunda ilk çalışma esnasında bakıyor araç return date null mı değil mi diye ama ilk çalıştırma olduğundan
         dolayı exception veriyor çünkü orda öyle bir data yok !!! Farklı bir algoritmik yapı geliştirilmesi gerekiyor orası için*/
        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.BrandUpdated);
         /*   if (rental.ReturnDate==null)
            { return new ErrorResult(Messages.CarNotReturned);}
            else { return new SuccessResult(Messages.RentalAdded);}*/
            
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }
    }
}
