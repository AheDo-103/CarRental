using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results.Abstract;
using Entities.Conctrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService : IServiceBase<Rental>
    {
        IDataResult<List<RentalS>> GetAllDetailsForSingle(Expression<Func<RentalS, bool>> filter = null);
        IDataResult<List<RentalL>> GetAllDetailsForList(Expression<Func<RentalL, bool>> filter = null);
    }
}