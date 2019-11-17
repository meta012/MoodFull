using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodFull.ViewModels;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UnitTesting
{
    class LoginViewModelTests
    {
        [Test]
        public void UserPropertyUsernameGetSetWorks()
        {
            LoginViewModel model = new LoginViewModel();
            model.Username = "test";
            Assert.AreEqual(model.Username, "test");
        }

        [Test]
        public void UserPropertyPasswordGetSetWorks()
        {
            LoginViewModel model = new LoginViewModel();
            model.Password = "test";
            Assert.AreEqual(model.Password, "test");
        }




    }
}
