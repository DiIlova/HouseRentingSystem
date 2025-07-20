using Microsoft.AspNetCore.Mvc;
using NUnit.Framework.Legacy;
using HouseRentingSystem.Web.Controllers;

namespace HouseRentingSystem.Tests.IntegrationsTests
{
    public class HomeControllerTests
    {
        private HomeController _homeController;

        [OneTimeSetUp]
        public void SetUp()
            => _homeController = new HomeController(null);

        [OneTimeTearDown]
        public void TearDown()
        {
            _homeController?.Dispose();   
        }

        [Test]
        public void Error_ShouldReturnCorrectView()
        {
            // Arrange: assign a valid status code to a variable
            var statusCode = 500;

            // Act: invoke the controller method with valid data
            var result = _homeController.Error(statusCode);

            // Assert the returned result is not null
            ClassicAssert.IsNotNull(result);

            // Assert the returned result is a view
            var viewResult = result as ViewResult;
            ClassicAssert.IsNotNull(viewResult);
        }
    }
}
