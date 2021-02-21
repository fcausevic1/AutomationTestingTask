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
    public class CreditSlipsPage : BasePage
    {
        IWebElement creditSlips => driver.FindElement(By.Id("order-slip"));
        public CreditSlipsPage(IWebDriver driver) : base(driver) { }

        public void VerifyThatUserCanCheckCreditSlips()
        {
            Assert.True(creditSlips.Displayed);
        }
    }
}
