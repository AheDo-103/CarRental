using FluentValidation;
using FluentValidation.Results;

namespace Business.Utilities
{
    public static class ValidationTool
    {
        public static ValidationResult Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            return result;
        }
    }
}