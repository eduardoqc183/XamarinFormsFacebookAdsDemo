using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Facebook.Ads.Internal.Api
{
    public abstract partial class AdComponentFrameLayout
    {
        public void SetLayoutParams(ViewGroup.LayoutParams p0)
        {
            SetLayoutParams(p0);
        }
    }

    public abstract partial class AdNativeComponentView
    {
        public void SetLayoutParams(ViewGroup.LayoutParams p0)
        {
            SetLayoutParams(p0);
        }
    }

    internal partial class IInterstitialAdApiInvoker
    {
        IAdLoadConfigBuilder IFullScreenAd.BuildLoadAdConfig()
        {
            return BuildLoadAdConfig();
        }

        IFullScreenAdShowConfigBuilder IFullScreenAd.BuildShowAdConfig()
        {
            return BuildShowAdConfig();
        }
    }

    public partial class InitSettingsBuilder
    {
        AudienceNetworkAds.IInitSettingsBuilder AudienceNetworkAds.IInitSettingsBuilder.WithInitListener(AudienceNetworkAds.IInitListener p0)
        {
            return WithInitListener(p0);
        }

        AudienceNetworkAds.IInitSettingsBuilder AudienceNetworkAds.IInitSettingsBuilder.WithMediationService(string p0)
        {
            return WithMediationService(p0);
        }

        AudienceNetworkAds.IInitSettingsBuilder AudienceNetworkAds.IInitSettingsBuilder.WithPlacementIds(IList<string> p0)
        {
            return WithPlacementIds(p0);
        }
    }

    internal partial class IRewardedVideoAdApiInvoker
    {
        IAdLoadConfigBuilder IFullScreenAd.BuildLoadAdConfig()
        {
            return BuildLoadAdConfig();
        }

        IFullScreenAdShowConfigBuilder IFullScreenAd.BuildShowAdConfig()
        {
            return BuildShowAdConfig();
        }
    }
}