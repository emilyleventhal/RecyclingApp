﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2
{
    public partial class profilePage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);
        public profilePage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        void OpenBrowser(string url)
        {
            Launcher.OpenAsync(new System.Uri(url));
        }

        async void OnList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListView());
        }

        async void OnMap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void OnProfile(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new profilePage());
        }
    }
}
