using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyWebsite.Controllers;
using System.Web.Mvc;

namespace MyWebsiteTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var homeController = new HomeController();

            var result = homeController.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
