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
    public class MyAddressesPage : BasePage
    {
        IWebElement addresses => driver.FindElement(By.ClassName("container"));
        string newAddressAlias = "";
        IWebElement newAddress => driver.FindElement(By.XPath("//ul[@class='last_item item box']//*[contains(text(),'My address2')]"));
        IWebElement addNewAddressButton => driver.FindElement(By.XPath("//*[contains(text(),'Add a new address')]"));
        public MyAddressesPage(IWebDriver driver) : base(driver) { }


       public void VerifyThatUserCanCheckAddresses()
        {
            Assert.True(addresses.Displayed);
        }

        public NewAddressFormPage AddANewAddress()
        {
            addNewAddressButton.Click();
            return new NewAddressFormPage(driver);
        }

        public void VerifyThatUserHasAddedANewAddress(string alias)
        {
            Assert.True(driver.FindElement(By.XPath($"//ul[@class='last_item item box']//*[contains(text(),'{alias}')]")).Displayed);
        }
    }
}
