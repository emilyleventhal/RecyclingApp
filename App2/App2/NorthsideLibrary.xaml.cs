﻿using System;
using System.Collections.Generic;
using System.Windows.Input;
using Rg.Plugins.Popup.Pages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App2
{
    public partial class NorthsideLibrary : PopupPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public NorthsideLibrary()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void OpenBrowser(string url)
        {
            Launcher.OpenAsync(new System.Uri(url));
        }
    }
}