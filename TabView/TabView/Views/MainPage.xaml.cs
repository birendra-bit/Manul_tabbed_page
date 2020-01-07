using System;
using System.Diagnostics;
using TabView.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            //BindingContext = new AccountViewModal();

            //var viewmodel = this.BindingContext as AccountViewModal;

            var tapEvent = new TapGestureRecognizer();
            tapEvent.Tapped += TapEvent_Tapped;
            homePage.GestureRecognizers.Add(tapEvent);

            var accTap = new TapGestureRecognizer();
            accTap.Tapped += AccTap_Tapped;
            accPage.GestureRecognizers.Add(accTap);

            var setTap = new TapGestureRecognizer();
            setTap.Tapped += SetTap_Tapped;
            setPage.GestureRecognizers.Add(setTap);

            var musicTap = new TapGestureRecognizer();
            musicTap.Tapped += MusicTap_Tapped;
            musicPage.GestureRecognizers.Add(musicTap);

            TapEvent_Tapped(null, null);

        }

        private void SetTap_Tapped(object sender, System.EventArgs e)
        {
            DefaultValues();
            content.Content = new Setting();

            setPage.BorderColor = Color.FromHex("FF9800");
            settingBtn.Source = "settin1.png";
            settingBtn.Margin = -10;
            settingBtn.HeightRequest = 30;
            settingBtn.WidthRequest = 40;
        }

        private void MusicTap_Tapped(object sender, System.EventArgs e)
        {
            DefaultValues();
            content.Content = new Music();

            musicPage.BorderColor = Color.FromHex("FF9800");
            musicBtn.Source = "music1.png";
            musicBtn.Margin = -10;
            musicBtn.HeightRequest = 30;
            musicBtn.WidthRequest = 40;
        }

        private void AccTap_Tapped(object sender, System.EventArgs e)
        {
            DefaultValues();
            content.Content = new Account();

            accPage.BorderColor = Color.FromHex("FF9800");
            accountBtn.Source = "acc1.png";
            accountBtn.Margin = -10;
            accountBtn.HeightRequest = 30;
            accountBtn.WidthRequest = 40;
        }

        private void TapEvent_Tapped(object sender, System.EventArgs e)
        {
            DefaultValues();
            content.Content = new Home();
            homePage.BorderColor = Color.FromHex("FF9800");
            homeBtn.Source = "homeActive.png";
            homeBtn.Margin = -10;
            homeBtn.HeightRequest = 30;
            homeBtn.WidthRequest = 40;
        }

        private void DefaultValues()
        {
            homeBtn.Source = "home.png";
            homePage.BorderColor = Color.Transparent;

            accountBtn.Source = "account.png";
            accPage.BorderColor = Color.Transparent;

            settingBtn.Source = "setting.png";
            setPage.BorderColor = Color.Transparent;

            musicBtn.Source = "music.png";
            musicPage.BorderColor = Color.Transparent;
        }
    }
}