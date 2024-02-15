using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.Drivers
{
    public  class Driver
    {
        public IWebDriver GetDriver()
        {
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            //options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://ecommerce-playground.lambdatest.io/index.php?route=common/home");
            return driver;
        }
            
    }
}
 