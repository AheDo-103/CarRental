using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Conctrete;
using Entities.DTOs;

namespace DataAccess.Conctrete.EntityFramework
{
    public class EfCarDal : EfEntityRepository<Car, CarRentalContext>, ICarDal
    {
        public List<CarS> GetAllDetailsForSingle(Expression<Func<CarS, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join color in context.Colors on car.ColorId equals color.ColorId
                    select new CarS()
                    {
                        CarId = car.CarId,
                        BrandId = car.BrandId,
                        ColorId = car.ColorId,
                        CarName = car.CarName,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        ModelYear = car.ModelYear,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public List<CarL> GetAllDetailsForList(Expression<Func<CarL, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join color in context.Colors on car.ColorId equals color.ColorId
                    select new CarL()
                    {
                        CarId = car.CarId,
                        CarName = car.CarName,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        ModelYear = car.ModelYear,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}