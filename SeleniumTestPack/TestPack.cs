﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPack
{
    [TestFixture]
    public class TestPack
    {
        private IWebDriver _driver;

        [OneTimeSetUp]
        public void BeforeTestRun()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Cookies.DeleteAllCookies();
        }

        [OneTimeTearDown]
        public void AfterTestRun()
        {
            _driver.Dispose();
            _driver.Close();
        }

        [Test]
        public void SampleTest()
        {
            _driver.Navigate().GoToUrl("http://orojackson.com");
        }
    }
}
