using System.Net;
using laget.Exceptions.Abstractions;

namespace laget.Exceptions.Extensions
{
    public static class ExceptionExtensions
    {
        public static Models.Response GetResponse(this System.Exception exception, object details = null, string instance = null)
        {
            return new Models.Response
            {
                Type = exception.GetType().Name,
                Title = exception.Message,
                Status = (int)HttpStatusCode.InternalServerError,
                Details = details,
                Instance = instance
            };
        }

        public static Models.Response GetResponse(this BaseException exception)
        {
            return new Models.Response
            {
                Type = exception.Type,
                Title = exception.Message,
                Status = (int)exception.StatusCode,
                Details = exception.Details,
                Instance = exception.Instance
            };
        }
    }
}
