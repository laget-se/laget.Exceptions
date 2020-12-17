using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace laget.Exceptions
{
    public class NotFoundException<T> : Exception
    {
        public override HttpStatusCode StatusCode { get; } = HttpStatusCode.NotFound;

        static string BaseMessage => $"{typeof(T).Name} was not found for";

        public NotFoundException(string message)
            : base(message)
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
          : base($"{BaseMessage} " + string.Join(',', propertyValuePairs.Select(x => $"{x.Key}: {x.Value}")))
        {
        }

        public NotFoundException(Dictionary<string, string> propertyValuePairs)
          : base($"{BaseMessage} " + string.Join(',', propertyValuePairs.Select(x => $"{x.Key}: {x.Value}")))
        {
        }
    }
}
