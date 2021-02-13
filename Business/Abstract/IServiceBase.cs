using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Conctrete;

namespace Business.Abstract
{
    public interface IServiceBase<TEntity> where TEntity : class, IEntity, new()
    {
        IDataResult<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null);
        IDataResult<TEntity> Get(int entityId);
        IResult Add(TEntity entity);
        IResult Update(TEntity entity);
        IResult Delete(TEntity entity);
    }
}