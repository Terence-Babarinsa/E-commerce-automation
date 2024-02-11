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
            IWebDriver driver = null;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
            options.AddArgument("--headless");
            driver = new ChromeDriver();

            return driver;
        }
            
    }
}
