using laget.Exceptions.Abstractions;
using System.Net;

namespace laget.Exceptions
{
    public class ConstraintException : BaseException
    {
        public override HttpStatusCode StatusCode { get; set; } = HttpStatusCode.BadRequest;

        public ConstraintException(string message)
            : base(message)
        {
        }

        public ConstraintException(string message, System.Exception ex)
            : base(message, ex)
        {
        }
    }
}
