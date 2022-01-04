using FluentValidation.Results;

namespace Zeats.Error.FluentValidation.Extensions
{
    public static class ValidationFailureExtensions
    {
        public static ErrorItem ToErrorItem(this ValidationFailure validationFailure)
        {
            return new ErrorItem
            {
                Severity = (Severity) validationFailure.Severity,
                Type = "Validation",
                Property = validationFailure.PropertyName,
                Message = validationFailure.ErrorMessage
            };
        }
    }
}