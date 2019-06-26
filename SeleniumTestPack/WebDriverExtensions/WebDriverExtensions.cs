using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPack.WebDriverExtensions
{
    public static class WebDriverExtensions
    {
        public static IWebElement WaitForElementToExist(this IWebDriver driver, By element, int timeToWait)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeToWait));
                return wait.Until(d => d.FindElement(element));
            }
            catch (NoSuchElementException)
            {
                return null;
            }
           
        } 
    }
}
