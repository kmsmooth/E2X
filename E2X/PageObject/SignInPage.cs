using E2X.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace E2X.PageObject
{
    class SignInPage
    {
        public IWebDriver driver;
        public SignInPage()
        {
            driver = WebHook.driver;
        }

        private By signIn = By.XPath("(//a[@class='navUser-action'])[2]");
        private By emailAddress = By.Id("login_email");
        private By password = By.Id("login_pass");
        private By orderMessage = By.XPath("//*[@id='main-content']/div[1]/h1");


        public void ClickAcceptCookies()
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", driver.FindElement(By.XPath("//*[contains(text(),'Accept')]")));
        }
        public void ClickSignIn()
        {
            Thread.Sleep(1000);
            driver.FindElement(signIn).Click();
        }

        public void EnterEmailAddress(string p0)
        {
            IJavaScriptExecutor scrolldown = WebHook.driver as IJavaScriptExecutor;
            scrolldown.ExecuteScript("scroll(0,250);");
            driver.FindElement(emailAddress).SendKeys(p0);
        }

        public void EnterPassword(string p1)
        {
            driver.FindElement(password).SendKeys(p1);
        }
        public void ClickSignInButton()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click()", driver.FindElement(By.XPath("//*[@id='main-content']/div[1]/div/div/form/div[3]/input")));
        }
        public bool OrderMessage()
        {
            return driver.FindElement(orderMessage).Displayed;
        }

    }
}
