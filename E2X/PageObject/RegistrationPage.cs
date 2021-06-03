using E2X.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace E2X.PageObject
{
    class RegistrationPage
    {
        public IWebDriver driver;
        public RegistrationPage()
        {
            driver = WebHook.driver;
        }

        private By register = By.XPath("(//a[@class='navUser-action'])[3]");
        private By emailAddress = By.Id("FormField_1_input");
        private By password = By.Id("FormField_2_input");
        private By confirmPassword = By.Id("FormField_3_input");
        private By country = By.XPath("//*[@id='FormField_11_select']/option[228]");
        private By firstName = By.Id("FormField_4_input");
        private By lastName = By.Id("FormField_5_input");
        private By address = By.Id("FormField_8_input");
        private By city = By.Id("FormField_10_input");
        private By postCode = By.Id("FormField_13_input");
        private By phoneNumber = By.Id("FormField_7_input");
        private By createAccountButton = By.XPath("(//*[contains(@type,'submit')])[1]");
        private By messageAccountCreated = By.XPath("//*[@id='main-content']/div[1]/section/div/h1");


        public void ClickRegister()
        {
            Thread.Sleep(1000);
            driver.FindElement(register).Click();
        }
        public void EnterEmailAddress(string p0)
        {
            driver.FindElement(emailAddress).SendKeys(p0);
        }
        public void EnterPassword(string p1)
        {
            driver.FindElement(password).SendKeys(p1);
        }
        public void EnterConfirmPassword(string p2)
        {
            driver.FindElement(confirmPassword).SendKeys(p2);
        }
        public void SelectCountry()
        {
            driver.FindElement(country).Click();
        }
        public void EnterFirstName(string p3)
        {
            driver.FindElement(firstName).SendKeys(p3);
        }
        public void EnterLastName(string p4)
        {
            driver.FindElement(lastName).SendKeys(p4);
        }

        public void EnterAddress(string p5)
        {
            driver.FindElement(address).SendKeys(p5);
        }

        public void EnterCity(string p6)
        {
            driver.FindElement(city).SendKeys(p6);
        }

        public void EnterPostCode(string p7)
        {
            driver.FindElement(postCode).SendKeys(p7);
        }

        public void EnterPhoneNumber(string p8)
        {
            driver.FindElement(phoneNumber).SendKeys(p8);
        }

        public void ClickCreateAccountButton()
        {
            Thread.Sleep(1000);
            driver.FindElement(createAccountButton).Click();
        }

        public bool MessageAccountCreated()
        {
            return driver.FindElement(messageAccountCreated).Displayed;
        }





    }
}




