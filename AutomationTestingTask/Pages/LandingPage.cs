using AutomationTestingTask.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Pages
{
    public class LandingPage : BasePage
    {

        IWebElement signInButton => driver.FindElement(By.ClassName("login"));
        IWebElement signOutButton => driver.FindElement(By.ClassName("logout"));

        public LandingPage(IWebDriver driver) : base(driver) { }

        public RegisterLoginPage SignInOrRegister()
        {
            signInButton.Click();
            return new RegisterLoginPage(driver);
        }

        public UserProfilePage LogIn(string email, string password)
        {
            RegisterLoginPage registerLoginPage = SignInOrRegister();
            UserProfilePage userProfilePage = registerLoginPage.LogIn(email, password);
            userProfilePage.VerifyThatUserIsLoggedIn();
            return userProfilePage;

        }

        public LandingPage LogOut()
        {         
            signOutButton.Click();
           
            return new LandingPage(driver);
        }

        public void VerifyThatUserIsNotLogedIn()
        {
            Assert.True(signInButton.Displayed);
        }
    }
}
