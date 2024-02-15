using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowProject3.POM;
using System;
using TechTalk.SpecFlow;
using SpecFlowProject3.Drivers;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class PreExistingUserLoginStepDefinitions
    {
        private IWebDriver _driver;
        private Login loginPage;
        public PreExistingUserLoginStepDefinitions()
        {
            _driver = CommonSetup.GetDriverInstance();
            loginPage = new Login(_driver);
        }


        [Given(@"the valid url")]
        public void GivenTheValidUrl()
        {
            loginPage._dropdownMyAccount.Click();
        }

        [When(@"I enter the correct username and password")]
        public void WhenIEnterTheCorrectUsernameAndPassword()
        {
            loginPage.Emailfield("tez-o-b@hotmail.com");
            loginPage.Passwordfield("Password1234");
        }

        [When(@"Click Login")]
        public void WhenClickLogin()
        {
            loginPage.LoginButton();
        }

        [Then(@"I can view my accout information")]
        public void ThenICanViewMyAccoutInformation()
        {
            Assert.That(loginPage.AccountInfo(), Is.EqualTo("Edit your account information"));
        }

        [When(@"I enter the invalid email and valid password")]
        public void WhenIEnterTheInvalidEmailAndValidPassword()
        {
            loginPage.Emailfield("tez-o-b@hhotmail.com");
            loginPage.Passwordfield("Password1234");
        }

        [Then(@"I can not view my account information")]
        public void ThenICanNotViewMyAccountInformation()
        {
            Assert.That(loginPage.WanrningMessage(), Is.EqualTo("Warning: No match for E-Mail Address and/or Password."));
        }

        [When(@"I enter the invalid password and valid email")]
        public void WhenIEnterTheInvalidPasswordAndValidEmail()
        {
            loginPage.Emailfield("tez-o-b@hotmail.com");
            loginPage.Passwordfield("password1234");
        }

        [When(@"I navigate to the forgotten password page")]
        public void WhenINavigateToTheForgottenPasswordPage()
        {
            loginPage.ForgottenPasswordButton();
        }

        [When(@"enter the correct email address")]
        public void WhenEnterTheCorrectEmailAddress()
        {
            loginPage.ForgottenPasswordEmail("tez-o-b@hotmail.com");
        }

        [When(@"click continue")]
        public void WhenClickContinue()
        {
            loginPage.ForgottePasswordConfirm();
        }

        [Then(@"I am alerted that a confirmation link has been sent")]
        public void ThenIAmAlertedThatAConfirmationLinkHasBeenSent()
        {
            Assert.That(loginPage.SuccessMesssage(), Is.EqualTo("An email with a confirmation link has been sent your email address."));
        }

        [When(@"enter an incorrect email address")]
        public void WhenEnterAnIncorrectEmailAddress()
        {
            loginPage.ForgottenPasswordEmail("tz-o-b@hotmail.com");
        }

        [Then(@"I am alerted the email wasnt found in the records")]
        public void ThenIAmAlertedTheEmailWasntFoundInTheRecords()
        {
            Assert.That(loginPage.WanrningMessage(), Is.EqualTo("Warning: The E-Mail Address was not found in our records, please try again!"));
        }
    }

    
}
