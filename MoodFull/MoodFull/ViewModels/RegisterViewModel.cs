using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Views;
using MoodFull.Mocks;
using Xamarin.Forms;

namespace MoodFull.ViewModels
{
    /*klase kuri sukurs nauja vartotojo paskyra.  Paspaudus register sugrazins kontrole
      i login langa*/
    public class RegisterViewModel
    {
        string username;
        string password;
        string confirmPassword;
        string name;
        string lastName;
        

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }

        //public delegate bool PasswordMatches(string Password, string ConfirmPassword );
        Func<string, string, bool> PasswordMatches = delegate (string Password, string ConfirmPassword) { return Password.Equals(ConfirmPassword);};
        public RegisterViewModel()
        {

        }

        public Command LauchLoginWindowCommand
        {
            get
            {
                return new Command(Register);
            }
        }

        private void Register()
        {
            if (!PasswordMatches(Password,ConfirmPassword))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Password doesn't match", "OK");
                return;
            }
            if (IsEmptyFields())
            {
                Application.Current.MainPage.DisplayAlert("Error", "Fields cannot be empty", "OK");
                return;
            }


            DataCollections.AddUser(Username, Password, Name, LastName);
            Application.Current.MainPage.DisplayAlert("Success", "", "OK");

            Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        public bool IsEmptyFields()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName))
            {
                return true;
            }
            return false;
        }

    }
}
