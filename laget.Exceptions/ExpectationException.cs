using System.Net;
using laget.Exceptions.Abstractions;

namespace laget.Exceptions
{
    public class ExpectationException : BaseException
    {
        public override HttpStatusCode StatusCode { get; set; } = HttpStatusCode.ExpectationFailed;

        public ExpectationException(string message)
            : base(message)
        {
        }

        public ExpectationException(string message, System.Exception ex)
            : base(message, ex)
        {
        }
    }
}
