using System.Collections.Generic;
using System.Linq;
using System.Net;
using laget.Exceptions.Abstractions;

namespace laget.Exceptions
{
    public class NotFoundException<T> : BaseException
    {
        public override HttpStatusCode StatusCode { get; set; } = HttpStatusCode.NotFound;

        private static string BaseMessage => $"{typeof(T).Name} was not found for";

        public NotFoundException(string message)
            : base($"{message} ({typeof(T).Name})")
        {
        }

        public NotFoundException(string message, System.Exception ex)
            : base(message, ex)
        {
        }

        public NotFoundException(int id)
            : base($"{BaseMessage} Id: {id}")
        {
        }

        public NotFoundException(string property, int value)
           : base($"{BaseMessage} {property}: {value}")
        {
        }

        public NotFoundException(string property, string value)
           : base($"{BaseMessage} {property}: {value}")
        {
        }

        public NotFoundException(Dictionary<string, int> propertyValuePairs)
            : base($"{BaseMessage} " + string.Join(",", propertyValuePairs.Select(x => $"{x.Key}: {x.Value}")))
        {
        }

        public NotFoundException(Dictionary<string, string> propertyValuePairs)
            : base($"{BaseMessage} " + string.Join(",", propertyValuePairs.Select(x => $"{x.Key}: {x.Value}")))
        {
        }
    }
}
