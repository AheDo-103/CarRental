using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results.Abstract;
using Entities.Conctrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        IDataResult<List<CustomerS>> GetAllDetailsForSingle(Expression<Func<CustomerS, bool>> filter = null);
        IDataResult<List<CustomerL>> GetAllDetailsForList(Expression<Func<CustomerL, bool>> filter = null);
    }
}