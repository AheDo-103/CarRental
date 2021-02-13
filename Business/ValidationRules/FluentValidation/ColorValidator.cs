using Entities.Conctrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(x => x.ColorName).MinimumLength(2).WithMessage("Renk adı en az 2 karakterden oluşmalıdır.");
        }
    }
}