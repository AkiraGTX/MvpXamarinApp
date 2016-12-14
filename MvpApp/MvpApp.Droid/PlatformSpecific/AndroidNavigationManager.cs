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
using System.Reflection;
using MvpApp.Core;
using MvpApp.Views;

namespace MvpApp.Droid.PlatformSpecific
{
    public class AndroidNavigationManager : INavigationManager
    {

        private Context Context;
        private static Type[] TypesCache = null;

        public AndroidNavigationManager(Context context)
        {
            this.Context = context;
        }

        private Type GetActivityType<TView>()
        {
            if (TypesCache == null)
            {
                TypesCache = Assembly.GetExecutingAssembly().GetTypes();
            }
            return TypesCache.FirstOrDefault(type => typeof(TView).IsAssignableFrom(type));
        }

        public void Navigate<TView>(bool newStack = false ,params ViewParameter[] parameters) where TView : IView
        {
            var activityType = GetActivityType<TView>();

            Intent intent = new Intent(this.Context, activityType);
            if(parameters!= null)
            {
                foreach (var parameter in parameters)
                {
                    intent.PutExtra(parameter.ParameterName, parameter.Value);
                }
            }

            intent.AddFlags(ActivityFlags.NewTask);
            if (newStack)
            {
                intent.AddFlags(ActivityFlags.ClearTop);
            }

            this.Context.StartActivity(intent);
        }
    }
}