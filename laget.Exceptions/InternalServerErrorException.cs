using System.Net;

namespace laget.Exceptions
{
    public class InternalServerErrorException : Exception
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.InternalServerError;

        public InternalServerErrorException(string message)
            : base(message)
        {
        }

        public InternalServerErrorException(string message, System.Exception ex)
            : base(message, ex)
        {
        }
    }
}
