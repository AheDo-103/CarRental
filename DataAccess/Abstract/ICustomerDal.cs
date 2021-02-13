using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Conctrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
        List<CustomerS> GetAllDetailsForSingle(Expression<Func<CustomerS, bool>> filter = null);
        List<CustomerL> GetAllDetailsForList(Expression<Func<CustomerL, bool>> filter = null);
    }
}