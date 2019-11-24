using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MoodFull.Views;
using MoodFull.Mocks;
using Xamarin.Forms;
using System.Threading.Tasks;
using MoodFull.Services;
using MoodFull.Models;

namespace MoodFull.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string username;
        string password;
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

        /*sukurta pavyzdziui*/
        private List<User> _usersList;
        private User _selectedUser = new User();
        public List<User> UsersList
        {
            get { return _usersList; }
            set
            {
                _usersList = value;
                OnPropertyChanged();
            }
        }
        public User SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }
        public Command PostCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var userServices = new UserService();
                    await userServices.PostUserAsync(_selectedUser);
                });
            }
        }
        private async Task InitializeDataAsync()
        {
            var usersServices = new UserService();
            UsersList = await usersServices.GetUsersAsync();
        }
        /*sukurta pavyzdziui*/
        public LoginViewModel()
        {
            /*sukurta pavyzdziui*/
            InitializeDataAsync();
            /*sukurta pavyzdziui*/

            //Executes when register button is clicked
            LauchRegisterWindowCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            });
        }

        public Command LauchLoginWindowCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        public Command LauchRegisterWindowCommand { get; }

        private void Login()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                Application.Current.MainPage.DisplayAlert("Empty values", "Please enter Username and Password", "OK");
            }
            else
            {
                //Executes when login button is clicked
                if (DataCollections.UserExists(Username, Password))
                {
                    Application.Current.MainPage.DisplayAlert("Login Success", "", "OK");
                    Application.Current.MainPage.Navigation.PushAsync(new MainPage());
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct email and password", "OK");
                }
            }
        }
    }
}
