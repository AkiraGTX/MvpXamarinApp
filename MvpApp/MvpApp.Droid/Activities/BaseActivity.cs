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
using MvpApp.Views;
using MvpApp.Presenters;
using Autofac;
using MvpApp.Droid.PlatformSpecific;
using MvpApp.Core;

namespace MvpApp.Droid.Activities
{
    public abstract class BaseActivity<TPresenter> : Activity, IView where TPresenter : IPresenter
    {
        protected TPresenter Presenter { get; set; }

        public void InitializePresenter(params ViewParameter[] parameters)
        {
            Presenter = AndroidApplication.Current.Container.Resolve<TPresenter>();
            Presenter.Initialize(this, parameters);
        }

        protected void Initialize(Bundle bundle)
        {
            var parameters = GetParametersFromExtras(bundle).ToArray();
            InitializePresenter(parameters);
        }

        private IEnumerable<ViewParameter> GetParametersFromExtras(Bundle bundle)
        {
            var keys = this.Intent.Extras?.KeySet();
            var parameters = new List<ViewParameter>();
            if (keys != null)
            {
                foreach (string key in keys)
                {
                    parameters.Add(new ViewParameter(key, this.Intent.Extras.GetString(key)));
                }
            }
            return parameters;
        }
    }
}