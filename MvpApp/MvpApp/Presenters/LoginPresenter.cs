using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpApp.Views;
using MvpApp.Core;

namespace MvpApp.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginView View;
        private INavigationManager NavigationManager;

        public LoginPresenter(INavigationManager navigationManager)
        {
            NavigationManager = navigationManager;
        }

        public void Initialize(IView view, params ViewParameter[] parameters)
        {
            View = view as ILoginView;
            View.Login += OnLogin;
        }

        public void OnLogin()
        {
            if(View.Username == "demo" && View.Password == "123")
            {
                NavigationManager.Navigate<IMainView>(true, new ViewParameter("currentUser", View.Username));
            }
        }
    }
}
