using System;
using System.Collections.Generic;
using System.Text;
using MoodFull.Views;
using Xamarin.Forms;

namespace MoodFull.ViewModels
{
    class RegisterViewModel
    {
        //klase kuri sukurs nauja vartotojo paskyra.  Paspaudus register sugrazins kontrole
        //i login langa

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

        public Command LauchRegisterWindowCommand { get; }

        public RegisterViewModel()
        {
            LauchRegisterWindowCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
            });
        }

    }
}
