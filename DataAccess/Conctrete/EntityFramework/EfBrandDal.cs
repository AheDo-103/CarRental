using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctrete;

namespace DataAccess.Conctrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepository<Brand, CarRentalContext>, IBrandDal
    {
    }
}