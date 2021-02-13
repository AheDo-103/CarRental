using Core.DataAccess;
using Entities.Conctrete;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        
    }
}