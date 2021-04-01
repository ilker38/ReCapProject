using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        IColorService _colorService;
        IBrandService _brandService;

        public CarManager(ICarDal carDal,IBrandService brandService,IColorService colorService)
        {
            _carDal = carDal;
            _colorService=colorService;
            _brandService=brandService;
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GettAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<Car>> GettAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfColorCountOfCategoryCorrect(car.ColorId), CheckIfCarNameExists(car.CarName), CheckIfBrandCategoryLimitExceded());
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.GetAll(c => c.BrandId == car.BrandId);
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }



        private IResult CheckIfColorCountOfCategoryCorrect(int colorId)
        {
            var result = _carDal.GetAll(c => c.ColorId == colorId).Count;
            if (result >= 15)
            {
                return new ErrorResult(Messages.CarColorCountOfCategoryError);
            }

            return new SuccessResult();
        }
        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(c => c.CarName == carName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CarNameAlreadyExists);
            }

            return new SuccessResult();
        }

        private IResult CheckIfBrandCategoryLimitExceded()
        {
            var result = _brandService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.CarBrandLimitExceded);
            }

            return new SuccessResult();
        }



    }
}
