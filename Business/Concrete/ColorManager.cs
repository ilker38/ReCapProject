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
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            if (color.Name.Length>4)
           {
               _colorDal.Add(color);
               return new SuccessResult(Messages.ColorAdded);

           }
           else
           {
               return new ErrorResult(Messages.ColorNameInvalid + " " +"Please Try Again.");
           }
        }

        public IResult Update(Color color)
        {
            //Yeni Girilen Değerler şuanki Değerler ile eşitlenecek ve Bilgiler Update edilmiş olacak fakat henüz eşitleyemedim çünkü Referans numarasına ulaşmayı başaramadım.
            //var result =_colorDal.GetAll(c => c.ColorId == color.ColorId);
            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);

        }

        public IResult Delete(Color color)
        {
            _colorDal.GetAll(c => c.ColorId == color.ColorId);
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }
    }
}
