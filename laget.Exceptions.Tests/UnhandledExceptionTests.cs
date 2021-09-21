using System.Net;
using Xunit;

namespace laget.Exceptions.Tests
{
    public class UnhandledExceptionTests
    {
        [Fact]
        public void ShouldCreateCorrectObject()
        {
            var message = "You cannot do this!";
            var exception = new UnhandledException(message);

            Assert.Equal(message, exception.Message);
            Assert.Equal(HttpStatusCode.InternalServerError, exception.StatusCode);
            Assert.Equal("UnhandledException", exception.Type);
        }
    }
}
