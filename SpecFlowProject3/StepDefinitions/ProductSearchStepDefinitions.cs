using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecFlowProject3.POM;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using SpecFlowProject3.Drivers;

namespace SpecFlowProject3.StepDefinitions
{
    [Binding]
    public class ProductSearchStepDefinitions
    {
        private IWebDriver _driver;
        private Login loginPage;
        private Product product;

        public ProductSearchStepDefinitions()
        {
            _driver = CommonSetup.GetDriverInstance();
            loginPage = new Login(_driver);
            product = new Product(_driver);
        }


        [Given(@"a pre existing user logs in using their email and password")]
        public void GivenAPreExistingUserLogsInUsingTheirEmailAndPassword()
        {
            loginPage.DropdownMyAccount();
            loginPage.Emailfield("tez-o-b@hotmail.com");
            loginPage.Passwordfield("Password1234");
            loginPage.LoginButton();
        }

        [When(@"the user searches for an item")]
        public void WhenTheUserSearchesForAnItem()
        {
            product.SearchBar("HTC");
            product.SearchResult();
            product.Item();
        }

        [Then(@"the item is displayed with the correct price")]
        public void ThenTheItemIsDisplayedWithTheCorrectPrice()
        {
            Assert.That(product.ProductPrice, Is.EqualTo("$146.00"));
        }

        [Then(@"the user can add the prodcut to their cart")]
        public void ThenTheUserCanAddTheProdcutToTheirCart()
        {
            product.AddToCart();
            Thread.Sleep(3000);
            Assert.That(product.CartState(), Is.EqualTo("1"));
        }

        [Given(@"has an item in their cart")]
        public void GivenHasAnItemInTheirCart()
        {
            product.SearchBar("HTC");
            product.SearchResult();
            product.Item();
            product.AddToCart();
            product.AddToCart();
            Thread.Sleep(10000);
        }

        [When(@"the user navigates to the cart")]
        public void WhenTheUserNavigatesToTheCart()
        {
            product.NavigateToCart();
            product.Editcart();
        }

        [When(@"increases the amount of the item")]
        public void WhenIncreasesTheAmountOfTheItem()
        {
            product.ChangeQuantity("3");
            product.UpdateQuantity();
            Thread.Sleep(3000);
        }

        [Then(@"a success message is displayed")]
        public void ThenASuccessMessageIsDisplayed()
        {
            Assert.That(product.SuccessCartChange, Is.EqualTo("Success: You have modified your shopping cart!\r\n×"));
        }


        [When(@"decreases the amount of the item")]
        public void WhenDecreasesTheAmountOfTheItem()
        {
            product.ChangeQuantity("1");
            product.UpdateQuantity();
            Thread.Sleep(3000);
        }

        [When(@"the user searches for an invalid item")]
        public void WhenTheUserSearchesForAnInvalidItem()
        {
            product.SearchBar("wrong item");
            product.SearchResult();
        }

        [Then(@"a message is dsiaplyed that no products match the search criteria")]
        public void ThenAMessageIsDsiaplyedThatNoProductsMatchTheSearchCriteria()
        {
            Assert.That(product.IncorrectSearch(), Is.EqualTo("There is no product that matches the search criteria.\r\nContinue"));
        }

        [When(@"adds the item to cart")]
        public void WhenAddsTheItemToCart()
        {
            product.AddToCart();
            Thread.Sleep(10000);
        }

        [Then(@"removes the item from cart")]
        public void ThenRemovesTheItemFromCart()
        {
            product.RemoveFromCart();
            Thread.Sleep(2000);
            Assert.That(product.CartState, Is.EqualTo("0"));
        }


    }
}
