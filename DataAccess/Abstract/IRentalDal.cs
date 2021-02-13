using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Conctrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentalS> GetAllDetailsForSingle(Expression<Func<RentalS, bool>> filter = null);
        List<RentalL> GetAllDetailsForList(Expression<Func<RentalL, bool>> filter = null);
    }
}