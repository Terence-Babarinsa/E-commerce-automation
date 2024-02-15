using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecFlowProject3.FindElement;

namespace SpecFlowProject3.POM
{
    public class Login
    {
        private readonly GetMethods _getMethods;
        public Login(IWebDriver driver)
        {
             _getMethods = new GetMethods(driver);
        }
        public IWebElement _dropdownMyAccount => _getMethods.GetElement(ElementTypes.XPath, "//a[@role='button']//span[@class='title'][normalize-space()='My account']");
        private IWebElement _emailField => _getMethods.GetElement(ElementTypes.Id, "input-email");
        private IWebElement _passwordField => _getMethods.GetElement(ElementTypes.Id, "input-password");
        private IWebElement _loginButton => _getMethods.GetElement(ElementTypes.XPath, "//input[@value='Login']");
        private IWebElement _accountInfo => _getMethods.GetElement(ElementTypes.XPath, "//a[normalize-space()='Edit your account information']");
        private IWebElement _successMessage => _getMethods.GetElement(ElementTypes.XPath, "//div[@class='alert alert-success alert-dismissible']");
        private IWebElement _wanrningMessage => _getMethods.GetElement(ElementTypes.XPath, "//div[@class='alert alert-danger alert-dismissible']");
        private IWebElement _forgottenPasswordButton => _getMethods.GetElement(ElementTypes.XPath, "//div[@class='form-group']//a[normalize-space()='Forgotten Password']");
        private IWebElement _forgottenPasswordEmail => _getMethods.GetElement(ElementTypes.Id, "input-email");
        private IWebElement _forgottenPasswordConfirm => _getMethods.GetElement(ElementTypes.XPath, "//button[normalize-space()='Continue']");

        public void DropdownMyAccount()
        {
            _dropdownMyAccount.Click();
        }
        public void Emailfield(string email)
        {
            _emailField.SendKeys(email);
        }
        public void Passwordfield(string password)
        {
            _passwordField.SendKeys(password);
        }
        public void LoginButton()
        {
            _loginButton.Click();
        }
        public string SuccessMesssage()
        {
            return _successMessage.Text;
        }
        public string WanrningMessage()
        {
            return _wanrningMessage.Text;
        }
        public void ForgottenPasswordButton()
        {
            _forgottenPasswordButton.Click();
        }
        public string AccountInfo()
        {
            return _accountInfo.Text;
        }
        public void ForgottenPasswordEmail(string email)
        {
            _forgottenPasswordEmail.SendKeys(email);
        }
        public void ForgottePasswordConfirm()
        {
            _forgottenPasswordConfirm.Click();
        }
    }
}
