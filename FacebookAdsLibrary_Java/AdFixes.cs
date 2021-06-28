using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Facebook.Ads
{
    public partial class AdView
    {
        internal partial class IAdViewLoadConfigBuilderInvoker
        {
            IAdLoadAdConfig IAdLoadConfigBuilder.Build()
            {
                return Build();
            }

            IAdLoadConfigBuilder IAdLoadConfigBuilder.WithBid(string p0)
            {
                return WithBid(p0);
            }
        }
    }

    public partial class InterstitialAd
    {
        IAdLoadConfigBuilder IFullScreenAd.BuildLoadAdConfig()
        {
            return BuildLoadAdConfig();
        }

        IFullScreenAdShowConfigBuilder IFullScreenAd.BuildShowAdConfig()
        {
            return BuildShowAdConfig();
        }

        internal partial class IInterstitialAdLoadConfigBuilderInvoker
        {
            IAdLoadAdConfig IAdLoadConfigBuilder.Build()
            {
                return Build();
            }

            IAdLoadConfigBuilder IAdLoadConfigBuilder.WithBid(string p0)
            {
                return WithBid(p0);
            }
        }

        internal partial class IInterstitialAdShowConfigBuilderInvoker
        {
            IFullScreenAdShowAdConfig IFullScreenAdShowConfigBuilder.Build()
            {
                return Build();
            }
        }
    }

    public abstract partial class NativeAdBase
    {
        internal partial class INativeAdLoadConfigBuilderInvoker
        {

            IAdLoadAdConfig IAdLoadConfigBuilder.Build()
            {
                return Build();
            }

            IAdLoadConfigBuilder IAdLoadConfigBuilder.WithBid(string p0)
            {
                return WithBid(p0);
            }
        }
    }

    public partial class RewardedVideoAd
    {
        IAdLoadConfigBuilder IFullScreenAd.BuildLoadAdConfig()
        {
            return BuildLoadAdConfig();
        }

        IFullScreenAdShowConfigBuilder IFullScreenAd.BuildShowAdConfig()
        {
            return BuildShowAdConfig();
        }

        internal partial class IRewardedVideoAdLoadConfigBuilderInvoker
        {
            IAdLoadAdConfig IAdLoadConfigBuilder.Build()
            {
                return Build();
            }

            IAdLoadConfigBuilder IAdLoadConfigBuilder.WithBid(string p0)
            {
                return WithBid(p0);
            }
        }

        internal partial class IRewardedVideoAdShowConfigBuilderInvoker
        {
            IFullScreenAdShowAdConfig IFullScreenAdShowConfigBuilder.Build()
            {
                return Build();
            }
        }
    }
}