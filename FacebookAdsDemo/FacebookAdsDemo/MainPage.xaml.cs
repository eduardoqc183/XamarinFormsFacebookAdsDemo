using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookAdsDemo.AdsFb;
using Xamarin.Forms;

namespace FacebookAdsDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var fbAdsControl1 = new FacebookAdsControl
            {
                HeightRequest = 100,
                PlacementId = Constants.Banner_1,
                Size = FacebookAdsControl.FacebookAdSize.Banner32050,
                VerticalOptions = LayoutOptions.Center
            };
            FbBannerAd.Children.Add(fbAdsControl1);
        }

        private void btnIntestitial_Clicked(object sender, EventArgs e)
        {
            App.ShowInterstitial();
        }
    }
}
