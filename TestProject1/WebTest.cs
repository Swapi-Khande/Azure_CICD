using System;
using TestWebApp.Controllers;

namespace TestProject1
{
    public class WebTest
    {
        [Fact]
        public void Test1()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "Value should be equal to 1");
        }

        [Fact]
        public void CheckAddFunction()
        {
            HomeController homeController = new HomeController();
            int y = homeController.Add(3, 3);

            bool result = false;

            if (y == 6) result = true;
            Assert.True(result, "Value should be equal to 6");
        }
    }
}