using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationTestingTask.Pages;

namespace AutomationTestingTask.Tests
{
    [TestFixture]
    class OrderHistoryTests : BaseTest
    {
        

        [Test]
        public void VerifyThatUserCanCheckOrderHistory()
        {
            RegisterLoginPage registerLoginPage = landingPage.SignInOrRegister();
            UserProfilePage userProfilePage = registerLoginPage.LogIn();
            OrderHistoryPage orderHistoryPage = userProfilePage.CheckOrderHistory();
            orderHistoryPage.VerifyThatUserCanCheckOrderHistoryPage();
        }
    }
}
