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
using MvpApp.Core;
using MvpApp.Droid.PlatformSpecific;

namespace MvpApp.Droid
{
    public class AndroidApplication : IApplication
    {
        public IContainer Container { get; private set; }

        public AndroidApplication()
        {
            var factory = new ContainerFactory();

            //Platform registrations
            factory.AddRegistrations(builder =>
            {
                builder.RegisterType<AndroidNavigationManager>().As<INavigationManager>();
                builder.Register<Context>(container => Application.Context);
            });

            this.Container = factory.Build();
        }

        public static AndroidApplication Current { get; set; }
    }
}