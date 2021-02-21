using AutomationTestingTask.Pages;
using AutomationTestingTask.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask
{
    [TestFixture]
    class RegisterLoginPageTest : BaseTest
    {
        [Test]
        public void VerifyThatUserHasBeenGivenRegisterForm()
        {
            RegisterLoginPage registerLogin = landingPage.SignInOrRegister();
            registerLogin.Register("proba1.1proba@proba.com");
            registerLogin.VerifyThatUserHasBeenGivenRegisterForm();
        }

        [Test]
        public void VerifyThatUserCanSignIn()
        {
            string email = "nest.ene@nest.com";
            string password = "test123";
            RegisterLoginPage registerLoginPage = landingPage.SignInOrRegister();
            UserProfilePage userProfilePage = registerLoginPage.LogIn(email, password);
            userProfilePage.VerifyThatUserIsLoggedIn();
        }

        [Test]
        public void VerifyThatUserCanSignOut()
        {
            string email = "nest.ene@nest.com";
            string password = "test123";
            RegisterLoginPage registerLoginPage = landingPage.SignInOrRegister();
            UserProfilePage userProfilePage = registerLoginPage.LogIn(email, password);
            userProfilePage.VerifyThatUserIsLoggedIn();
            landingPage.LogOut();
            landingPage.VerifyThatUserIsNotLogedIn();
        }

    }
}
