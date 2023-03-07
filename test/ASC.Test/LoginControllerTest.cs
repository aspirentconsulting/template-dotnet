using ASC.API.Controllers;
using ASC.API.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace ASC.Test
{
    [TestClass]
    public class LoginControllerTest
    {
        private Mock<ILogger<LoginController>> moqLogger = new Mock<ILogger<LoginController>>();

        [TestMethod]
        public void TestGreetUserByPostInvalidUser()
        {
            // var moqLogger = new Mock<ILogger<LoginController>>();
            // moqLogger.Setup(x => x.LogDebug(It.IsAny<string>()));
            var loginController = new LoginController(moqLogger.Object);
            loginController.ModelState.AddModelError("Name", "Input is required");
            var response = loginController.GreetUserByPost(new User(string.Empty));
            Assert.IsInstanceOfType<BadRequestObjectResult>(response);
        }

        [TestMethod]
        public void TestGreetUserByPostValidUser()
        {
            var loginController = new LoginController(moqLogger.Object);

            // loginController.ModelState.AddModelError("Name", "Input is required");
            var response = loginController.GreetUserByPost(new User("Sam"));
            Assert.IsInstanceOfType<CreatedResult>(response);
        }
    }
}