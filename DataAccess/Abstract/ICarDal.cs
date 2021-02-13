using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Conctrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarS> GetAllDetailsForSingle(Expression<Func<CarS, bool>> filter = null);
        List<CarL> GetAllDetailsForList(Expression<Func<CarL, bool>> filter = null);
    }
}