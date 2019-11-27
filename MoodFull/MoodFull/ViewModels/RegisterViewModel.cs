using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Views;
using MoodFull.Models;
using Xamarin.Forms;
using MoodFull.Services;
using System.Threading.Tasks;

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

        private List<User> _usersList = new List<User>();
        UserService USER_SERVICE = new UserService();

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }

        //public delegate bool PasswordMatches(string Password, string ConfirmPassword );
        Func<string, string, bool> PasswordMatches = delegate (string Password, string ConfirmPassword) { return Password.Equals(ConfirmPassword); };
        public List<User> UsersList
        {
            get { return _usersList; }
            set
            {
                _usersList = value;
            }
        }
        public RegisterViewModel()
        {

        }

        private bool IsCorrect()
        {
            if (IsEmptyFields())
            {
                Application.Current.MainPage.DisplayAlert("Error", "Fields cannot be empty", "OK");
                return false;
            }
            UsersList = Task.Run(async () => await USER_SERVICE.GetUsersAsync()).Result;

            if (UsersList.Find(x => x.Username.Equals(username)) != null)
            {
                Application.Current.MainPage.DisplayAlert("Error", "Username is already taken", "OK");
                return false;
            }
            if (!PasswordMatches(Password, ConfirmPassword))
            {
                Application.Current.MainPage.DisplayAlert("Error", "Password doesn't match", "OK");
                return false;
            }
            return true;
            
        }

        public bool IsEmptyFields()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName))
            {
                return true;
            }
            return false;
        }

        public Command LauchLoginWindowCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (IsCorrect())
                    {
                        User newUser = new User(username, password, name, lastName, 0);
                        await USER_SERVICE.PostUserAsync(newUser);
                        await Application.Current.MainPage.DisplayAlert("Success", "", "OK");

                        await Application.Current.MainPage.Navigation.PopAsync();
                    }
                    return;

                });
            }
        }

    }

}