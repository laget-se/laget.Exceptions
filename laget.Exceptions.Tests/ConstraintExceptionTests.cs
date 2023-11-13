using System.Net;
using Xunit;

namespace laget.Exceptions.Tests
{
    public class ConstraintExceptionTests
    {
        [Fact]
        public void ShouldCreateCorrectObject()
        {
            var message = "You cannot do this!";
            var exception = new ConstraintException(message);

            Assert.Equal(message, exception.Message);
            Assert.Equal(HttpStatusCode.BadRequest, exception.StatusCode);
            Assert.Equal("ConstraintException", exception.Type);
        }
    }
}
