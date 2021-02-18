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
        
        IWebElement signInButton=> driver.FindElement(By.ClassName("login"));

        public LandingPage(IWebDriver driver) : base(driver) { }

        public RegisterLoginPage SignInOrRegister()
        {
            signInButton.Click();
            return new RegisterLoginPage(driver);

        }
    }
}
