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
    public class RegisterLoginPage : BasePage
    {
        IWebElement registerText => driver.FindElement(By.XPath("//*[contains(text(),'Create an account')]"));

        public RegisterLoginPage(IWebDriver driver) : base(driver) { }

        public void VerifyThatPageHasLoaded()
        {
            Assert.True(registerText.Displayed);
        }
    }
}
