using System.Net;

namespace laget.Exceptions
{
    public class ExpectationException : Exception
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.ExpectationFailed;

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
