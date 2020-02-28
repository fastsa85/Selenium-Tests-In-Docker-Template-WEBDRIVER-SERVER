using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace UITests
{
    [TestClass]
    public class ChromeDriverTest
    {        
        private RemoteWebDriver _driver;

        [TestInitialize]
        public void ChromeDriverInitialize()
        {
            // Initialize driver 
            var options = new ChromeOptions
            {
                PageLoadStrategy = PageLoadStrategy.Normal
            };
            options.AddArguments("start-maximized"); // open Browser in maximized mode
            options.AddArguments("disable-infobars"); // disabling infobars
            options.AddArguments("--disable-extensions"); // disabling extensions
            options.AddArguments("--disable-gpu"); // applicable to windows os only
            options.AddArguments("--disable-dev-shm-usage"); // overcome limited resource problems
            options.AddArguments("--no-sandbox"); // Bypass OS security model
                        
            _driver = new RemoteWebDriver(new Uri("http://seleniumchromedriver:4444"), options);
        }

        [TestMethod]
        public void VerifyPageTitle()
        {            
            _driver.Url = "https://www.google.com";
            Assert.AreEqual("Google", _driver.Title);
        }

        [TestCleanup]
        public void ChromeDriverCleanup()
        {
            _driver.Quit();
        }
    }
}
