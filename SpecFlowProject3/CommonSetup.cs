using OpenQA.Selenium;
using SpecFlowProject3.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3
{
    [Binding]
    public class CommonSetup
    {
        private static IWebDriver _driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            if (_driver == null)
            {
                Driver driver = new Driver();
                _driver = driver.GetDriver();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
            _driver.Dispose();
            _driver = null;
        }

        public static IWebDriver GetDriverInstance()
        {
            return _driver;
        }
    }
}
