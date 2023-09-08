using laget.Exceptions.Abstractions;
using System.Net;

namespace laget.Exceptions
{
    public class ConstraintException : BaseException
    {
        public override HttpStatusCode StatusCode { get; set; } = HttpStatusCode.MethodNotAllowed;

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
