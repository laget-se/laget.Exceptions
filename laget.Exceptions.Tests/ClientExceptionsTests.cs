using System.Net;
using Xunit;

namespace laget.Exceptions.Tests
{
    public class ClientExceptionsTests
    {
        [Fact]
        public void ShouldCreateCorrectObject()
        {
            var message = "You cannot do this!";
            var exception = new ClientException<SomeClient>(message)
            {
                StatusCode = HttpStatusCode.Conflict
            };

            Assert.Equal($"{message} (Client='SomeClient')", exception.Message);
            Assert.Equal(HttpStatusCode.Conflict, exception.StatusCode);
            Assert.IsType<ClientException<SomeClient>>(exception);
        }

        internal sealed class SomeClient
        {
        }
    }
}
