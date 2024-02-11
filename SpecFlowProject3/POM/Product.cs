using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject3.POM
{
    public class Product
    {
        private readonly GetMethods _getMethods;
        public Product(IWebDriver driver)
        {
            _getMethods = new GetMethods(driver);
        }
        private IWebElement _searchBar => _getMethods.GetElement(ElementTypes.XPath, "//div[@id='entry_217822']//input[@placeholder='Search For Products']");
        private IWebElement _searchResult => _getMethods.GetElement(ElementTypes.XPath, "//button[normalize-space()='Search']");
        private IWebElement _item => _getMethods.GetElement(ElementTypes.XPath, "//a[@id='mz-product-grid-image-28-212469']//div[@class='carousel-item active']//img[@title='HTC Touch HD']");
        private IWebElement _price => _getMethods.GetElement(ElementTypes.XPath, "//div[@class='price']");
        private IWebElement _addToCart => _getMethods.GetElement(ElementTypes.XPath, "//div[@id='entry_216842']//button[@title='Add to Cart'][normalize-space()='Add to Cart']");
        private IWebElement _cartState => _getMethods.GetElement(ElementTypes.CssSelector, "div[id='entry_217825'] span[class='badge badge-pill badge-info cart-item-total']");
        private IWebElement _editCart => _getMethods.GetElement(ElementTypes.XPath, "(//a[normalize-space()='Edit cart'])[1]");
        private IWebElement _incorrectSearch => _getMethods.GetElement(ElementTypes.Id, "entry_212469");
        private IWebElement _removeItemFromCart => _getMethods.GetElement(ElementTypes.CssSelector, ".btn.btn-danger");
        private IWebElement _emptycart => _getMethods.GetElement(ElementTypes.XPath, "//p[@style='' and @xpath='1']");
        private IWebElement _quantity => _getMethods.GetElement(ElementTypes.ClassName, "form-control");
        private IWebElement _successCartChange => _getMethods.GetElement(ElementTypes.CssSelector, ".alert.alert-success.alert-dismissible");
        private IWebElement _updateQuantity => _getMethods.GetElement(ElementTypes.CssSelector, ".fas.fa-sync-alt");
        public void SearchBar(string search)
        {
            _searchBar.SendKeys(search);
        }
        public void SearchResult()
        {
            _searchResult.Click();
        }
        public void Item()
        {
            _item.Click();
        }
        public string ProductPrice()
        {
            return _price.Text;
        }
        public void AddToCart()
        {
            _addToCart.Click();
        }
        public void NavigateToCart()
        {
            _cartState.Click();
        }
        public string CartState()
        {
            return _cartState.Text;
        }
        public string IncorrectSearch()
        {
            return _incorrectSearch.Text;
        }
        public void RemoveFromCart()
        {
            _removeItemFromCart.Click();
        }
        public void Editcart()
        {
            _editCart.Click();
        }
        public string EmptyCart()
        {
            return _emptycart.Text;
        }
        public string Quantity()
        {
            return _quantity.Text;
        }
        public string SuccessCartChange()
        {
            return _successCartChange.Text;
        }
        public void ChangeQuantity(string quantity)
        {
            _quantity.Clear();
            _quantity.SendKeys(quantity);
        }
        public void UpdateQuantity()
        {
            _updateQuantity.Click();
        }
    }
}
