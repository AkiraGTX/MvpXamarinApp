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

namespace MvpApp.Droid.Activities
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : BaseActivity<ILoginPresenter>, ILoginView
    {
        private EditText UsernameEditText;
        private EditText PasswordEditText;
        private Button LoginButton;

        public event Action Login;

        public string Username { get { return UsernameEditText.Text; } }

        public string Password { get { return PasswordEditText.Text; } }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            this.UsernameEditText = FindViewById<EditText>(Resource.Id.UsernameEditText);
            this.PasswordEditText = FindViewById<EditText>(Resource.Id.PasswordEditText);
            this.LoginButton = FindViewById<Button>(Resource.Id.LoginButton);
            this.LoginButton.Click += (object sender, EventArgs e) => this.Login?.Invoke();

            this.Initialize(savedInstanceState);
        }
    }
}