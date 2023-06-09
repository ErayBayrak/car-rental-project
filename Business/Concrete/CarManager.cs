﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheAspect]
        public IResult Add(Car car)
        {
            if(car.Description.Length>2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.SuccessAdded);
            }
            return new ErrorResult(Messages.FailedAdd);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<Car> Get(Expression<Func<Car, bool>> filter)
        {
            return new SuccessDataResult<Car>(_carDal.Get(filter),Messages.SuccessGet);
        }

        public IDataResult<List<Car>> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(filter),Messages.SuccessGet);
        }

        public IDataResult<Car> GetById(int id)
        {
            var values = new SuccessDataResult<Car>(_carDal.Get(x => x.Id == id), Messages.SuccessGet);
            return values;
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByDto(),Messages.SuccessGet);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.BrandId == id),Messages.SuccessGet);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(x => x.ColorId == id),Messages.SuccessGet);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.SuccessUpdated);
        }
    }
}
