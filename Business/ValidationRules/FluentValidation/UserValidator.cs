using Entities.Conctrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("Kullanıcı ismi en az 2 karakterden oluşmalıdır.");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("Kullanıcı soyismi en az 2 karakterden oluşmalıdır.");
            RuleFor(x => x.Email).NotNull().WithMessage("Kullanıcı e-postası boş olamaz.");
            RuleFor(x=>x.Email).MinimumLength(10).WithMessage("Kullanıcı e-postası en az 10 karakterden oluşmalıdır.");
            RuleFor(x => x.Password).NotNull().WithMessage("Kullanıcı şifresi boş olamaz.");
            RuleFor(x=>x.Password).MinimumLength(8).WithMessage("Kullanıcı şifresi en az 8 karakterden oluşmalıdır.");
        }
    }
}