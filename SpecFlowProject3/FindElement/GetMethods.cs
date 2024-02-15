using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.FindElement
{
    internal class GetMethods
    {
        private readonly IWebDriver _driver;

        public GetMethods(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement GetElement(ElementTypes elementType, string element)
        {
            By by = null;

            switch (elementType)
            {
                case ElementTypes.Id:
                    by = By.Id(element);
                    break;
                case ElementTypes.Name:
                    by = By.Name(element);
                    break;
                case ElementTypes.XPath:
                    by = By.XPath(element);
                    break;
                case ElementTypes.TagName:
                    by = By.TagName(element);
                    break;
                case ElementTypes.ClassName:
                    by = By.ClassName(element);
                    break;
                case ElementTypes.CssSelector:
                    by = By.CssSelector(element);
                    break;
            }
            return _driver.FindElement(by);
        }
    }
}
