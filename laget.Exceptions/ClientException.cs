using System.Net;

namespace laget.Exceptions
{
    public class ClientException<T> : Exception
    {
        private static string ClientName => $"{typeof(T).Name}";

        public override HttpStatusCode StatusCode => HttpStatusCode.InternalServerError;

        public ClientException(string message)
            : base($"{message} (Client='{ClientName}')")
        {
        }

        public ClientException(string message, System.Exception ex)
            : base($"{message} (Client='{ClientName}')", ex)
        {
        }

        public ClientException(string message, object details)
            : base($"{message} (Client='{ClientName}')")
        {
            Details = details;
        }

        public ClientException(string message, int? status, object details)
            : base($"{message} (Client='{ClientName}')")
        {
            Details = details;
            StatusCode = status != null ? (HttpStatusCode)status : HttpStatusCode.InternalServerError;
        }
    }
}
