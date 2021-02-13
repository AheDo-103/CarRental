using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Business.Abstract;
using Business.Constants;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Conctrete;
using DataAccess.Abstract;
using Entities.Conctrete;

namespace Business.Conctrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(filter), Messages.BrandListed);
        }

        public IDataResult<Brand> Get(int entityId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(x => x.BrandId == entityId), Messages.BrandGetted);
        }

        public IResult Add(Brand entity)
        {
            var result = ValidationTool.Validate(new BrandValidator(), entity);
            if (result.Errors.Count > 0)
                return new ErrorResult(result.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            if (_brandDal.Get(x => x.BrandName.ToLower() == entity.BrandName.ToLower()) != null)
                return new ErrorResult(Messages.BrandAddError);
            _brandDal.Add(entity);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Update(Brand entity)
        {
            var result = ValidationTool.Validate(new BrandValidator(), entity);
            if (result.Errors.Count > 0)
                return new ErrorResult(result.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            if (_brandDal.Get(x => x.BrandName.ToLower() == entity.BrandName.ToLower()) != null)
                return new ErrorResult(Messages.BrandAddError);
            _brandDal.Update(entity);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.BrandDeleted);
        }
    }
}