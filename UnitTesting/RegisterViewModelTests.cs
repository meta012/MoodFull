using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MoodFull.ViewModels;

namespace UnitTesting
{
    class RegisterViewModelTests
    {
        //tests methods and properties from RegisterViewModel.cs


        RegisterViewModel model = new RegisterViewModel();

        [Test]
        public void UserPropertyUsernameGetSetWorks()
        {
            model.Username = "test";
            Assert.AreEqual(model.Username, "test");
        }

        [Test]
        public void UserPropertyPasswordGetSetWorks()
        {
            RegisterViewModel model = new RegisterViewModel();
            model.Password = "password";
            Assert.AreEqual(model.Password, "password");
        }


        [Test]
        public void UserPropertyConfirmPasswordGetSetWorks()
        {
            model.ConfirmPassword = "password";
            Assert.AreEqual(model.ConfirmPassword, "password");
        }

        [Test]
        public void UserPropertyNameGetSetWorks()
        {
            model.Name = "test";
            Assert.AreEqual(model.Name, "test");
        }

        [Test]
        public void UserPropertyLastnameGetSetWorks()
        {
            model.LastName = "test";
            Assert.AreEqual(model.LastName, "test");
        }

        [Test]
        public void IfPasswordMatchesReturnsTrue()
        {
            model.ConfirmPassword = "password";
            model.Password = "password";
            Assert.AreEqual(model.PasswordMatches(),true);
        }

        [Test]
        public void IfPasswordNotMatchesReturnsFalse()
        {
            model.ConfirmPassword = "password1";
            model.Password = "password";
            Assert.AreEqual(model.PasswordMatches(), false);
        }


        //field testing
        [Test]
        public void IsEmptyFieldsOneFieldEnteredReturnFalse()
        {
            model = new RegisterViewModel();
            model.Name = "test";
            Assert.AreEqual( !model.IsEmptyFields(), false);

        }
        [Test]
        public void IsEmptyFieldsTwoFieldEnteredReturnFalse()
        {
            model = new RegisterViewModel();
            model.Name = "test";
            model.LastName = "test";
            Assert.AreEqual(!model.IsEmptyFields(), false);

        }
        [Test]
        public void IsEmptyFieldsThreeFieldEnteredReturnFalse()
        {
            model = new RegisterViewModel();
            model.Name = "test";
            model.LastName = "test";
            model.Password = "test";
            Assert.AreEqual(!model.IsEmptyFields(), false);

        }
        [Test]
        public void IsEmptyFieldsAllFieldEnteredReturnTrue()
        {
            model = new RegisterViewModel();
            model.Name = "test";
            model.LastName = "test";
            model.Password = "test";
            model.Username = "test";
            Assert.AreEqual(!model.IsEmptyFields(), true);

        }
    }
}
