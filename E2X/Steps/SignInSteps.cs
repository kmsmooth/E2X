using E2X.Hooks;
using E2X.PageObject;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace E2X.Steps
{
    [Binding]
    public class SignInSteps
    {
        public IWebDriver driver = WebHook.driver;
        SignInPage signInPage = new SignInPage();


        [Given(@"user click accept cookies")]
        public void GivenUserClickAcceptCookies()
        {
            signInPage.ClickAcceptCookies();
        }


        [Given(@"user clicks sign in")]
        public void GivenUserClicksSignIn()
        {
            signInPage.ClickSignIn();
        }
        
        [When(@"user enters valid credentials ""(.*)"",""(.*)""")]
        public void WhenUserEntersValidCredentials(string p0, string p1)
        {
            signInPage.EnterEmailAddress(p0);
            signInPage.EnterPassword(p1);
        }
        
        [Then(@"user should be signed in")]
        public void ThenUserShouldBeSignedIn()
        {
            signInPage.ClickSignInButton();
            signInPage.OrderMessage().Should().BeTrue();
        }

    }
}
