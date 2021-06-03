using E2X.Hooks;
using Nest;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace E2X.PageObject
{
    class CheckOutPage
    {

        public IWebDriver driver;
        public CheckOutPage()
        {
            driver = WebHook.driver;
        }
        private By shopAll = By.XPath("//*[@id='menu']/nav/ul[1]/li[2]/a");
        private By nextPage = By.XPath("//*[@id='product-listing-container']/nav/ul/li[4]/a");
        //private By searchField = By.Id("quick-search-expand");
        //private By enterSearchField = By.Id("nav-quick-search");
        private By addToCart = By.XPath("//*[@id='product-listing-container']/form[2]/ul/li[10]/article/figure/figcaption/div/a");
        private By checkOutButton = By.XPath("//*[@id='main-content']/div[1]/div/div/div[6]/a");
        private By emailAdress = By.Id("email");
        //private By privacyPolicyBox = By.XPath("//label[@for=\"privacyPolicy\"]");
        private By continueAsGuestButton = By.Id("checkout-customer-continue");

        private By firstName = By.Id("firstNameInput");
        private By lastName = By.Id("lastNameInput");
        private By Address = By.Id("addressLine1Input");
        private By city = By.Id("cityInput");
        private By postalCode = By.Id("postCodeInput");
        private By phoneNumber = By.Id("phoneInput");
        //private By continueButton = By.XPath("//*[@id='checkout-shipping-continue']");
        private By creditCardNumber = By.Id("ccNumber");
        private By nameOnCard = By.Id("ccName");
        private By expiration = By.Id("ccExpiry");
        private By cvv = By.Id("ccCvv");
        private By placeOrder = By.Id("checkout-payment-continue");
        private By orderMessage = By.XPath("//*[@id='checkout-app']/div/div/div/section");




        public void ClickShopAll()
        {
            driver.FindElement(shopAll).Click();
            IJavaScriptExecutor scrollpage = WebHook.driver as IJavaScriptExecutor;
            scrollpage.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
        }
        public void ClickNextPage()
        {
            driver.FindElement(nextPage).Click();


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor scrolldown = WebHook.driver as IJavaScriptExecutor;
            scrolldown.ExecuteScript("scroll(0,2000);");
        }

        //public void ClickSearchField()
        //{
        //    driver.FindElement(searchField).Click();

        //}

        //public void EnterSearchField()
        //{
        //    driver.FindElement(enterSearchField).SendKeys("kettle");
        //}
            public void ClickAddToCart()
        {
            driver.FindElement(addToCart).Click();
        }
        public void ClickCheckOutButton()
        {
            IJavaScriptExecutor scrollpage = WebHook.driver as IJavaScriptExecutor;
            scrollpage.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
            driver.FindElement(checkOutButton).Click();      
        }
        public void EnterEmailAddress()
        {
            driver.FindElement(emailAdress).SendKeys("testingtest108@mail.com");
        }

        public void CheckPrivacyPolicyBox()
        {
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", driver.FindElement(By.XPath("//label[@for=\"privacyPolicy\"]")));
            

        }
        public void ClickContinueAsGuestButton()
        {
            driver.FindElement(continueAsGuestButton).Click();  
        }

        public void EnterFirstName()
        {
            driver.FindElement(firstName).SendKeys("Benjamin");
        }

        public void EnterLastName()
        {
            driver.FindElement(lastName).SendKeys("Buttons");
        }

        public void EnterAddress()
        {
            driver.FindElement(Address).SendKeys("101 Close Avenue");
        }

        public void EnterCity()
        {
            driver.FindElement(city).SendKeys("London");
        }

        public void EnterPostalCode()
        {
            driver.FindElement(postalCode).SendKeys("W1 2ND");
        }
        public void EnterPhoneNumber()
        {
            driver.FindElement(phoneNumber).SendKeys("07908270331");
            IJavaScriptExecutor scrollpage = WebHook.driver as IJavaScriptExecutor;
            scrollpage.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
        }
        public void ClickContinueButton()
        {
            //Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", driver.FindElement(By.XPath("//*[@id='checkout-shipping-continue']")));
        }
      

        public void EnterCreditCardNumber()
        {
            driver.FindElement(creditCardNumber).SendKeys("4111 1111 1111 1111");
        }
        public void EnterNameOnCard()
        {
            driver.FindElement(nameOnCard).SendKeys("B J Buttons");
        }
        public void EnterExpiry()
        {
            driver.FindElement(expiration).SendKeys("1023");
        }
        public void EnterCvv()
        {
            driver.FindElement(cvv).SendKeys("909");
        }

        public void ClickPlaceOrder()
        {
            driver.FindElement(placeOrder).Click();
        }

        public bool DisplayOrderMessage()
        {
            return driver.FindElement(orderMessage).Displayed;
        }


    }
}
