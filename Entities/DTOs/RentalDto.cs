using System;
using Core.Entities;
using Entities.Conctrete;

namespace Entities.DTOs
{
    public class RentalS : Rental, IDto
    {
        public string CarName { get; set; }
        public string CompanyName { get; set; }
    }

    public class RentalL : IDto
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}