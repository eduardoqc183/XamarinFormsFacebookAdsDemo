using System;
using PelisGratis.App.Droid.Services;
using Xamarin.Forms;
using Com.Facebook.Ads;
using FacebookAdsDemo.AdsFb;

[assembly: Dependency(typeof(FacebookInterstitialAds))]
namespace PelisGratis.App.Droid.Services
{
    public class FacebookInterstitialAds : IFacebookInterstitialAds
    {
        private InterstitialAd _interstitial;
        public void ShowAds(string id)
        {
            _interstitial = new InterstitialAd(Android.App.Application.Context, id);
            var loadAdConfig = _interstitial.BuildLoadAdConfig()
                .WithAdListener(new InterstitialAdListener(_interstitial))
                .Build();

            _interstitial.LoadAd(loadAdConfig);
            //interstitial.SetAdListener(new InterstitialAdListener(interstitial)); //obsoleto
        }

        internal class InterstitialAdListener : Java.Lang.Object, IInterstitialAdListener
        {
            private readonly InterstitialAd _interstitial;

            public InterstitialAdListener(InterstitialAd interstitial)
            {
                _interstitial = interstitial;
            }

            public void OnAdClicked(IAd p0)
            {
                Console.WriteLine("OnAdClicked");
            }

            public void OnAdLoaded(IAd p0)
            {
                Console.WriteLine("OnAdLoaded");
                _interstitial.Show();
            }

            public void OnError(IAd p0, AdError p1)
            {
                Console.WriteLine("OnError: " + p1.ErrorMessage);
            }

            public void OnLoggingImpression(IAd p0)
            {
                Console.WriteLine("OnLoggingImpression");
            }

            public void OnInterstitialDismissed(IAd p0)
            {
                Console.WriteLine("OnInterstitialDismissed");
            }

            public void OnInterstitialDisplayed(IAd p0)
            {
                Console.WriteLine("OnInterstitialDisplayed");
            }
        }
    }
}