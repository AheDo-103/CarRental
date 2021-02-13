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
    public class EfRentalDal : EfEntityRepository<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalS> GetAllDetailsForSingle(Expression<Func<RentalS, bool>> filter = null)
        {
            using (CarRentalContext context  = new CarRentalContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.CarId
                    join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                    select new RentalS()
                    {
                        RentalId = rental.RentalId,
                        CarId = rental.CarId,
                        CustomerId = rental.CustomerId,
                        CarName = car.CarName,
                        CompanyName = customer.CompanyName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate,
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public List<RentalL> GetAllDetailsForList(Expression<Func<RentalL, bool>> filter = null)
        {
            using (CarRentalContext context  = new CarRentalContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.CarId
                    join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                    join user in context.Users on customer.UserId equals user.UserId
                    select new RentalL()
                    {
                        RentalId = rental.RentalId,
                        CarId = rental.CarId,
                        CustomerId = rental.CustomerId,
                        CarName = car.CarName,
                        CompanyName = customer.CompanyName,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate,
                        UserName = user.FirstName + " " + user.LastName,
                        Email = user.Email,
                        Password = user.Password,
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}