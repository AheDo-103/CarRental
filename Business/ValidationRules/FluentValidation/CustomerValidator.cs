using Entities.Conctrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CompanyName).MinimumLength(3).WithMessage("Şirket adı en az 3 karakterden oluşmalıdır.");
        }
    }
}