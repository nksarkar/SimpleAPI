using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new WeatherForecastController(null);
            var actual = controller.GetName();
            Assert.Equal("TestName", actual);
        }
    }
}
