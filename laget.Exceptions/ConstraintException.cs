using System.Net;

namespace laget.Exceptions
{
    public class ConstraintException : Exception
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.MethodNotAllowed;

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
