﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using MoodFull.Views;
using MoodFull.Mocks;
using Xamarin.Forms;
using System.Threading.Tasks;
using MoodFull.Services;
using MoodFull.Models;
using MoodFull.Interfaces;

namespace MoodFull.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private IUserService usersServices = ServiceFactory.GetUserService();

        //Saugomi user sarasai
        private List<User> _usersList = new List<User>();
        private User _selectedUser = new User();
        string username;
        string password;

        //Get Set
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
        public Command LauchLoginWindowCommand
        {
            get
            {
                return new Command(Login);
            }
        }
        public Command LauchRegisterWindowCommand { get; }
        public List<User> UsersList
        {
            get { return _usersList; }
            set
            {
                _usersList = value;
                OnPropertyChanged();
            }
        }

        public LoginViewModel()
        {
            //Executes when register button is clicked
            LauchRegisterWindowCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
            });
        }

        /// <summary>
        /// Checks if all fields are empty or not. If username and password is not empty
        /// logs in the user
        /// </summary>
        private void Login()
        {
            UsersList = Task.Run(async () => await usersServices.GetUsersAsync()).Result;

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                Application.Current.MainPage.DisplayAlert("Empty values", "Please enter Username and Password", "OK");
            }
            else
            {
                //Executes when login button is clicked
                if (DataCollections.UserExists(Username, Password, UsersList))
                {
                    Application.Current.MainPage.DisplayAlert("Login Success", "", "OK");
                    Application.Current.MainPage.Navigation.PushAsync(new MainPage());
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct username and password", "OK");
                }
            }
        }
    }
}
