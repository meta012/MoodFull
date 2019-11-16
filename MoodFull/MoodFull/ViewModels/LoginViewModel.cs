using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MoodFull.Views;
using Xamarin.Forms;

namespace MoodFull.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string username;
        string password;

        public LoginViewModel()
        {
            //Executes when login button is clicked
            LauchLoginWindowCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            });

            //Executes when register button is clicked
            LauchRegisterWindowCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            });
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public Command LauchLoginWindowCommand { get; }

        public Command LauchRegisterWindowCommand { get; }
    }
}
