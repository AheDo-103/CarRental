using Entities.Conctrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.RentDate).NotNull().WithMessage("Kiralanan aracın kiralama tarihi boş olamaz.");
        }
    }
}