using E2X.Hooks;
using E2X.PageObject;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace E2X.Steps
{
    [Binding]
    public class CheckOutSteps
    {
        public IWebDriver driver = WebHook.driver;
        CheckOutPage checkoutPage = new CheckOutPage();

        [Given(@"user is on the website")]
        public void GivenUserIsOnTheWebsite()
        {
            driver.Navigate().GoToUrl("https://cornerstone-light-demo.mybigcommerce.com");
        }
        
        [Given(@"user search for a product")]
        public void GivenUserSearchForAProduct()
        {
            //checkoutPage.ClickSearchField();
            //checkoutPage.EnterSearchField();
            checkoutPage.ClickShopAll();
            checkoutPage.ClickNextPage();
        }
        
        [Given(@"user adds that product to the cart")]
        public void GivenUserAddsThatProductToTheCart()
        {
            checkoutPage.ClickAddToCart();
        }
        
        [When(@"user completes the checkout process\.")]
        public void WhenUserCompletesTheCheckoutProcess_()
        {
            checkoutPage.ClickCheckOutButton();
            checkoutPage.EnterEmailAddress();
            checkoutPage.CheckPrivacyPolicyBox();
            checkoutPage.ClickContinueAsGuestButton();

            checkoutPage.EnterFirstName();
            checkoutPage.EnterLastName();
            checkoutPage.EnterAddress();
            checkoutPage.EnterCity();
            checkoutPage.EnterPostalCode();
            checkoutPage.EnterPhoneNumber();
            checkoutPage.ClickContinueButton();
            checkoutPage.EnterCreditCardNumber();
            //checkoutPage.EnterNameOnCard();
            //checkoutPage.EnterExpiry();
            //checkoutPage.EnterCvv();
            checkoutPage.ClickPlaceOrder();
        }

        [Then(@"user should get a order number")]
        public void ThenUserShouldGetAOrderNumber()
        {
            checkoutPage.DisplayOrderMessage().Should().BeTrue();
        }
    }
}
