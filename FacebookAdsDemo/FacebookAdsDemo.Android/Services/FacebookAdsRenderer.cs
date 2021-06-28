using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Facebook.Ads;
using FacebookAdsDemo.AdsFb;
using PelisGratis.App.Droid.Services;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Xamarin.Forms.View;

[assembly: ExportRenderer(typeof(FacebookAdsControl), typeof(FacebookAdsRenderer))]
namespace PelisGratis.App.Droid.Services
{
    public class FacebookAdsRenderer : ViewRenderer
    {

        public FacebookAdsRenderer() : base(Android.App.Application.Context)
        {

        }

        protected FacebookAdsControl AdViewControl => (FacebookAdsControl)Element;
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || Element == null)
                return;

            SetNativeControl();
        }

        private void SetNativeControl()
        {
            try
            {
                if (AdViewControl != null)
                {
                    AdView adView = new AdView(Context, AdViewControl.PlacementId, GetAdSize(AdViewControl.Size))
                    {
                        LayoutParameters = new LayoutParams(LayoutParams.WrapContent, LayoutParams.WrapContent)
                    };

                    adView.LoadAd();
                    adView.Click += (sender, args) => AdViewControl.OnClick();
                    SetNativeControl(adView);
                }
            }
            catch (Exception e)
            {
                Toast.MakeText(Context, e.Message, ToastLength.Long).Show();
            }
        }

        private AdSize GetAdSize(FacebookAdsControl.FacebookAdSize size)
        {
            switch (size)
            {
                case FacebookAdsControl.FacebookAdSize.Banner32050:
                    return AdSize.Banner32050;
                case FacebookAdsControl.FacebookAdSize.BannerHeight50:
                    return AdSize.BannerHeight50;
                case FacebookAdsControl.FacebookAdSize.BannerHeight90:
                    return AdSize.BannerHeight90;
                case FacebookAdsControl.FacebookAdSize.Interstitial:
                    return AdSize.Interstitial;
            }
            return AdSize.RectangleHeight250;
        }
    }
}