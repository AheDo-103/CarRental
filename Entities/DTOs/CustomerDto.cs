using Core.Entities;
using Entities.Conctrete;

namespace Entities.DTOs
{
    public class CustomerS : Customer,IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class CustomerL : IDto
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}