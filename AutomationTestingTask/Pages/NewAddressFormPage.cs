using AutomationTestingTask.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Pages
{
    public class NewAddressFormPage : BasePage
    {

        IWebElement addresField => driver.FindElement(By.Id("address1"));
        IWebElement cityField => driver.FindElement(By.Id("city"));
        IWebElement postalCodeField => driver.FindElement(By.Id("postcode"));

        IWebElement stateAlabama => driver.FindElement(By.XPath("//*[@id='id_state']/option[@value='1']"));
        IWebElement phoneNumberField => driver.FindElement(By.Id("phone"));
        IWebElement saveButton => driver.FindElement(By.XPath("//span[contains(text(),'Save')]"));
        IWebElement aliasField => driver.FindElement(By.Id("alias"));

        public NewAddressFormPage(IWebDriver driver) : base(driver) { }

        public MyAddressesPage AddNewAddressForm(string address, string city,string postalCode, string phoneNumber, string alias)
        {
            addresField.SendKeys(address);
            cityField.SendKeys(city);
            postalCodeField.SendKeys(postalCode);
            stateAlabama.Click();
            phoneNumberField.SendKeys(phoneNumber);
            aliasField.SendKeys(Keys.Control + "a");
            aliasField.SendKeys(Keys.Delete);
            aliasField.SendKeys(alias);
            saveButton.Click();
            return new MyAddressesPage(driver);
        }

    }
}
