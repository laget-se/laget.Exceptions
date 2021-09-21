using System.Net;
using Xunit;

namespace laget.Exceptions.Tests
{
    public class InternalServerErrorExceptionTest
    {
        [Fact]
        public void ShouldCreateCorrectObject()
        {
            var message = "You cannot do this!";
            var exception = new InternalServerErrorException(message);

            Assert.Equal(message, exception.Message);
            Assert.Equal(HttpStatusCode.InternalServerError, exception.StatusCode);
            Assert.Equal("InternalServerErrorException", exception.Type);
        }
    }
}
