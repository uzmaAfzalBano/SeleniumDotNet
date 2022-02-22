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
    class LoginTest
    {
        [Test]
        public void Test1()
        {

            var cap = new ChromeOptions().ToCapabilities();
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), cap);

            driver.Navigate().GoToUrl("https://demo.onvio.co.uk");

            Thread.Sleep(2000);
            driver.Close();
          
        }

        //[Test]
        //public void Test2()
        //{
        //    var cap = new ChromeOptions().ToCapabilities();
        //    IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), cap);
        //    driver.Navigate().GoToUrl("https://qed.onvio.co.uk");
        //    Thread.Sleep(2000);
        //    driver.Close();
        //}


        //[Test]
        //public void Test3()
        //{
        //    var cap = new ChromeOptions().ToCapabilities();
        //    IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), cap);
        //    driver.Navigate().GoToUrl("https://www.selenium.dev/");
        //    Thread.Sleep(2000);
        //    driver.Close();
        //}
    }
}
