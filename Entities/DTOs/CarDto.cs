using Core.Entities;
using Entities.Conctrete;

namespace Entities.DTOs
{
    public class CarS : Car, IDto
    {
        public string BrandName { get; set; }
        public string ColorName { get; set; }
    }

    public class CarL : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int? ModelYear { get; set; }
        public decimal? DailyPrice { get; set; }
        public string Description { get; set; }
    }
}