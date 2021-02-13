using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results.Abstract;
using Entities.Conctrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService : IServiceBase<Car>
    {
        IDataResult<List<CarS>> GetAllDetailsForSingle(Expression<Func<CarS, bool>> filter = null);
        IDataResult<List<CarL>> GetAllDetailsForList(Expression<Func<CarL, bool>> filter = null);
    }
}