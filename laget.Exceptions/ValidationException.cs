using laget.Exceptions.Abstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace laget.Exceptions
{
    public class ValidationException : BaseException
    {
        public override HttpStatusCode StatusCode { get; set; } = HttpStatusCode.BadRequest;

        public ValidationException(string message)
            : base(message)
        {
        }

        public ValidationException(string message, System.Exception exception)
            : base(message, exception)
        {
        }

        public ValidationException(string message, object details)
            : base(message)
        {
            Details = details;
        }

        public ValidationException(IEnumerable<ValidationResult> result)
            : base("Model validation failed")
        {
            Details = result;
        }

        public ValidationException(ValidationContext context, IEnumerable<ValidationResult> result)
            : base($"Model validation failed for type {context.DisplayName}, please see details for further details.")
        {
            Details = result;
        }
    }
}
