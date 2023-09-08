using System.Net;
using laget.Exceptions.Abstractions;

namespace laget.Exceptions
{
    public class UnhandledException : BaseException
    {
        public override HttpStatusCode StatusCode { get; set; } = HttpStatusCode.InternalServerError;

        public UnhandledException(string message)
            : base(message)
        {
        }

        public UnhandledException(string message, System.Exception ex)
            : base(message, ex)
        {
        }
    }
}
