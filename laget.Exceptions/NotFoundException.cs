using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace laget.Exceptions
{
    public class NotFoundException<T> : Exception
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;

        private static string BaseMessage => $"{typeof(T).Name} was not found for";

        public NotFoundException(string message)
            : base($"{message} ({typeof(T).Name})")
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
