using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace App2
{
    public partial class Paper : PopupPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public Paper()
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
