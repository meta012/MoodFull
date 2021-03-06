﻿using MoodFull.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MoodFull
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Opens RateRestaurantResult page when receives a message
            MessagingCenter.Subscribe<App, byte[]>(App.Current, "OpenRestaurantResultPage", (snd, arg) =>
            {
                Device.BeginInvokeOnMainThread(() => {
                    MainPage.Navigation.PushAsync(new RateRestaurantResult(arg));
                });
            });

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
