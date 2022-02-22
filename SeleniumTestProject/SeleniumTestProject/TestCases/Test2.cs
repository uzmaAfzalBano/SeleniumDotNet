using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace SeleniumTestProject.TestCases
{
    [Parallelizable]
    class Test2
    {
        [Test]
        public void Test21()
        {

            var cap = new ChromeOptions().ToCapabilities();
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), cap);

            driver.Navigate().GoToUrl("https://qed.onvio.co.uk");

            Thread.Sleep(2000);

        }
    }
}
