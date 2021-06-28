using System;
using FacebookAdsDemo.AdsFb;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FacebookAdsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static void ShowInterstitial()
        {
            DependencyService.Get<IFacebookInterstitialAds>().ShowAds(Constants.InterstitialID);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
