using System.Net;
using laget.Exceptions.Tests.Models;
using Xunit;

namespace laget.Exceptions.Tests
{
    public class NotFoundExceptionTests
    {
        [Fact]
        public void ShouldCreateCorrectObjectForInt()
        {
            var model = new TestModel();
            var exception = new NotFoundException<TestModel>(model.Id);
            var message = $"TestModel was not found for Id: {model.Id}";

            Assert.Equal(message, exception.Message);
            Assert.Equal(HttpStatusCode.NotFound, exception.StatusCode);
            Assert.Equal("NotFoundException`1", exception.Type);
        }
    }
}
