using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumTestPack.WebDriverExtensions;

namespace SeleniumTestPack
{
    [TestFixture]
    public class TestPack : TestBase
    {
        [Test]
        public void SampleTest()
        {
            _driver.Navigate().GoToUrl("http://orojackson.com");
        }
    }
}
