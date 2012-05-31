using System.Web.Mvc;
using HarborFirstTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarborFirstTest.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
