using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetIdentityDemo.Api.Services;
using Moq;
using AspNetIdentityDemo.Api.Dtos;

namespace AspNetIdentityDemo.Api.Controllers.Tests
{
    [TestClass()]
    public class AuthControllerTests
    {
        [TestMethod]
        public void thereIsAUserController()
        {
            var mockUsuarioService = new Mock<IUserService>();
            var controller = new AuthController(mockUsuarioService.Object);
            Assert.IsNotNull(controller);
        }

        [TestMethod()]
        public void LoginAsyncTest()
        {
            var mockUsuarioService = new Mock<IUserService>();
            var controller = new AuthController(mockUsuarioService.Object);
            Assert.IsNotNull(controller.LoginAsync(new LoginViewModel
            {
                Email = "carlos@gmail.com",
                Password = "Carlos.123"
            }));
        }
    }
}