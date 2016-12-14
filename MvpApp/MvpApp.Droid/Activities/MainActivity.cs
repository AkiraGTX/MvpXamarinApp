using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MvpApp.Presenters;
using MvpApp.Views;

namespace MvpApp.Droid.Activities
{
	[Activity (Label = "MainActivity")]
	public class MainActivity : BaseActivity<IMainPresenter>, IMainView
    {
        private TextView CurrentUserTextView;

        public string CurrentUser
        {
            get
            {
                return CurrentUserTextView.Text;
            }
            set
            {
                CurrentUserTextView.Text = value;
            }
        }

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView (Resource.Layout.Main);

            CurrentUserTextView = FindViewById<TextView>(Resource.Id.CurrentUserTextView);
            Initialize(bundle);
        }
	}
}


