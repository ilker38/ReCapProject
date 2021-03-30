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
    public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.Name.Length>3)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
            }
            else
            {
                return new ErrorResult(Messages.BrandNameInvalid + " " + "Please Try Again You Must Be Bigger than 2 Character for Brand Name");
            }
            
        }

        public IResult Update(Brand brand)
        {   //Yeni Girilen Değerler şuanki Değerler ile eşitlenecek ve Bilgiler Update edilmiş olacak fakat henüz eşitleyemedim çünkü Referans numarasına ulaşmayı başaramadım.
            //_brandDal.GetAll(b => b.BrandId == brand.BrandId);
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.GetAll(b => b.BrandId == brand.BrandId);
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll()) ;
        }
    }
}
