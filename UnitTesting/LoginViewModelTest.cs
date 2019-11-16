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
    class LoginViewModelTest
    {
        [Test]
        public void UserPropertyUserNameGetSetWorks()
        {
            LoginViewModel model = new LoginViewModel();
            model.Username = null;
            Assert.AreEqual(model.Username, null);
        }

        [Test]
        public void UserPropertyPasswordGetSetWorks()
        {
            LoginViewModel model = new LoginViewModel();
            model.Password = null;
            Assert.AreEqual(model.Password, null);
        }

    }
}
