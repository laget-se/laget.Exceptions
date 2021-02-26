using System.Net;
using Xunit;

namespace laget.Exceptions.Tests
{
    public class ExpectationExceptionTests
    {
        [Fact]
        public void ShouldCreateCorrectObject()
        {
            var message = "You cannot do this!";
            var exception = new ExpectationException(message);

            Assert.Equal(message, exception.Message);
            Assert.Equal(HttpStatusCode.ExpectationFailed, exception.StatusCode);
            Assert.Equal(nameof(ExpectationException), exception.Type);
        }
    }
}
