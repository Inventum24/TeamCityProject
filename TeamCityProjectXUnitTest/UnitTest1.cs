using System;
using System.Linq;
using TeamCityProject.Controllers;
using Xunit;

namespace TeamCityProjectXUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();
            var item = controller.Get();
            Assert.Equal(2, item.Count());
        }

    }
}
