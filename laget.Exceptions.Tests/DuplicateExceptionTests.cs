using System.Net;
using Xunit;

namespace laget.Exceptions.Tests
{
    public class DuplicateExceptionTests
    {
        [Fact]
        public void ShouldCreateCorrectObject()
        {
            var message = "You cannot do this!";
            var exception = new DuplicateException(message);

            Assert.Equal(message, exception.Message);
            Assert.Equal(HttpStatusCode.Conflict, exception.StatusCode);
            Assert.Equal(nameof(DuplicateException), exception.Type);
        }
    }
}
