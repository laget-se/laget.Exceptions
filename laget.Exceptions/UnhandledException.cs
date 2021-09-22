using System.Net;

namespace laget.Exceptions
{
    public class UnhandledException : Exception
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.InternalServerError;

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
