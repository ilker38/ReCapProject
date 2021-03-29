using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Update(Brand brand)
        {   //Yeni Girilen Değerler şuanki Değerler ile eşitlenecek ve Bilgiler Update edilmiş olacak fakat henüz eşitleyemedim çünkü Referans numarasına ulaşmayı başaramadım.
            //_brandDal.GetAll(b => b.BrandId == brand.BrandId);
            _brandDal.Update(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.GetAll(b => b.BrandId == brand.BrandId);
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
