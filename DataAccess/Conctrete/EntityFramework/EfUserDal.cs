using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctrete;

namespace DataAccess.Conctrete.EntityFramework
{
    public class EfUserDal : EfEntityRepository<User, CarRentalContext>, IUserDal
    {
    }
}