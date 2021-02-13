using Entities.Conctrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.BrandName).MinimumLength(3).WithMessage("Marka adı en az 3 karakterden oluşmalıdır.");
        }
    }
}