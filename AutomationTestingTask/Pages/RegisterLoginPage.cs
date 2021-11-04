using AutomationTestingTask.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using proba.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Pages
{
    public class RegisterLoginPage : BasePage
    {
        IWebElement registerText => driver.FindElement(By.XPath("//*[contains(text(),'Create an account')]"));
        IWebElement registerMailField => driver.FindElement(By.Id("email_create"));
        IWebElement creatAnAccountButton => driver.FindElement(By.Id("SubmitCreate"));
        IWebElement registerForm => driver.FindElement(By.Id("noSlide"));
        IWebElement logInEmailField => driver.FindElement(By.Id("email"),5);
        IWebElement logInPasswordField => driver.FindElement(By.Id("passwd"));
        IWebElement logInButton => driver.FindElement(By.Id("SubmitLogin"));
        
       

        public RegisterLoginPage(IWebDriver driver) : base(driver) { }


        public void VerifyThatPageHasLoaded()
        {
            Assert.True(ElementExtension.WaitUntilClickable(registerText, driver, 5));
        }

        public RegisterPage Register(string email)
        {
            registerMailField.SendKeys(email);
            creatAnAccountButton.Click();

            return new RegisterPage(driver);
        }

        public void VerifyThatUserHasBeenGivenRegisterForm()
        {

            RegisterLoginPage.WaitToLoad(driver, 5);
            Assert.True(registerForm.Displayed);
        }

        public UserProfilePage LogIn(string email= "nest.ene@nest.com", string password="test123")
        {
            logInEmailField.SendKeys(email);
            logInPasswordField.SendKeys(password);
            logInButton.Click();

            return new UserProfilePage(driver);
        }

        

        
    }
}
