using System.Linq;
using FluentValidation;

namespace Zeats.Error.FluentValidation.Extensions
{
    public static class ValidationExceptionExtensions
    {
        public static ErrorInfo ToErrorInfo(this ValidationException exception)
        {
            return new ErrorInfo
            {
                Severity = Severity.Error,
                Type = "Validation",
                Message = exception.Message,
                Details = exception.ToString(),
                Errors = exception.Errors?.Select(error => error.ToErrorItem()).ToList()
            };
        }
    }
}