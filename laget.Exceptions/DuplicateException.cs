using laget.Exceptions.Abstractions;
using System.Net;

namespace laget.Exceptions
{
    public class DuplicateException : BaseException
    {
        public override HttpStatusCode StatusCode { get; set; } = HttpStatusCode.Conflict;

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
