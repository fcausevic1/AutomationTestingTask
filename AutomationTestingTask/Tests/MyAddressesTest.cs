using AutomationTestingTask.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Tests
{
    [TestFixture]
    class MyAddressesTest : BaseTest
    {
        [Test]
        public void VerifyThatUserCanCheckAddresses()
        {
            RegisterLoginPage registerLoginPage = landingPage.SignInOrRegister();
            UserProfilePage userProfilePage = registerLoginPage.LogIn();
            MyAddressesPage myAddressesPage = userProfilePage.CheckAddresses();
            myAddressesPage.VerifyThatUserCanCheckAddresses();
        }

        [Test]
        public void VerifyThatUserCanAddedAnAddress()
        {
            Random rnd = new Random();
            string address = "ATest";
            string grad = "ATest";
            string zipCode = "00000";
            string phoneNumber = "12321";
            string alias = "My Address" + rnd.Next(1, 100);
                ;
            RegisterLoginPage registerLoginPage = landingPage.SignInOrRegister();
            UserProfilePage userProfilePage = registerLoginPage.LogIn();
            MyAddressesPage myAddressesPage = userProfilePage.CheckAddresses();
            NewAddressFormPage newAddressFormPage = myAddressesPage.AddANewAddress();
            myAddressesPage = newAddressFormPage.AddNewAddressForm(address, grad, zipCode, phoneNumber, alias);
            myAddressesPage.VerifyThatUserHasAddedANewAddress(alias);



        }
    }
}
