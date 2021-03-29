using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
           _colorDal.Add(color);
        }

        public void Update(Color color)
        {
            //Yeni Girilen Değerler şuanki Değerler ile eşitlenecek ve Bilgiler Update edilmiş olacak fakat henüz eşitleyemedim çünkü Referans numarasına ulaşmayı başaramadım.
            //var result =_colorDal.GetAll(c => c.ColorId == color.ColorId);
            _colorDal.Update(color);
            
        }

        public void Delete(Color color)
        {
            _colorDal.GetAll(c => c.ColorId == color.ColorId);
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
    }
}
