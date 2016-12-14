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
using Autofac;
using MvpApp.Views;
using MvpApp.Droid.PlatformSpecific;
using MvpApp.Core;

namespace MvpApp.Droid
{
    [Activity(Label = "SplashScreen" , MainLauncher = true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            AndroidApplication.Current = new AndroidApplication();
            var navigationManager = AndroidApplication.Current.Container.Resolve<INavigationManager>();
            navigationManager.Navigate<ILoginView>(newStack:true);
        }
    }
}