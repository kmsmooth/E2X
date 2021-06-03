using E2X.Hooks;
using E2X.PageObject;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace E2X.Steps
{
    [Binding]
    public class RegistrationSteps
    {
        public IWebDriver driver = WebHook.driver;
        RegistrationPage registrationPage = new RegistrationPage();

        [Given(@"user clicks register")]
        public void GivenUserClicksRegister()
        {
            registrationPage.ClickRegister();
        }
        
        [Given(@"user fill in their details (.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),(.*),")]
        public void GivenUserFillInTheirDetails(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        {
            registrationPage.EnterEmailAddress(p0);
            registrationPage.EnterPassword(p1);
            registrationPage.EnterConfirmPassword(p2);
            registrationPage.SelectCountry();
            registrationPage.EnterFirstName(p3);
            registrationPage.EnterLastName(p4);
            registrationPage.EnterAddress(p5);
            registrationPage.EnterCity(p6);
            registrationPage.EnterPostCode(p7);
            registrationPage.EnterPhoneNumber(p8);
        }
        
        [When(@"user clicks on create account")]
        public void WhenUserClicksOnCreateAccount()
        {
            registrationPage.ClickCreateAccountButton();
        }
        
        [Then(@"user should see account has been created")]
        public void ThenUserShouldSeeAccountHasBeenCreated()
        {
           registrationPage.MessageAccountCreated().Should().BeTrue();
        }
    }
}
