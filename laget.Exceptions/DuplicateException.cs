using System.Net;

namespace laget.Exceptions
{
    public class DuplicateException : Exception
    {
        public override HttpStatusCode StatusCode { get; } = HttpStatusCode.Conflict;

        public DuplicateException(string message)
            : base(message)
        {
        }

        public DuplicateException(string message, System.Exception ex)
            : base(message, ex)
        {
        }
    }
}
