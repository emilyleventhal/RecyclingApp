using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace App2
{
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            InitializeComponent();
        }

        async void McIntire_Clicked(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new profilePage());
        }

        async void Ivy_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Ivy());
        }

        async void Paper_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Paper());
        }

        async void Pantops_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Pantops());
        }

        async void Northside_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new NorthsideLibrary());
        }

        async void Scottsville_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Scottsville());
        }

        async void BlueRidge_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new BlueRidge());
        }

        async void Pack_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Pack());
        }

        async void Package_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new Package());
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
