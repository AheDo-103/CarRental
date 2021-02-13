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
    public class EfCustomerDal : EfEntityRepository<Customer, CarRentalContext>, ICustomerDal
    {
        public List<CustomerS> GetAllDetailsForSingle(Expression<Func<CustomerS, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from customer in context.Customers
                    join user in context.Users on customer.UserId equals user.UserId
                    select new CustomerS()
                    {
                        CustomerId = customer.CustomerId,
                        UserId = user.UserId,
                        CompanyName = customer.CompanyName,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        Password = user.Password,
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public List<CustomerL> GetAllDetailsForList(Expression<Func<CustomerL, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from customer in context.Customers
                    join user in context.Users on customer.UserId equals user.UserId
                    select new CustomerL()
                    {
                        CustomerId = customer.CustomerId,
                        CompanyName = customer.CompanyName,
                        UserName = user.FirstName + " " + user.LastName,
                        Email = user.Email,
                        Password = user.Password,
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}