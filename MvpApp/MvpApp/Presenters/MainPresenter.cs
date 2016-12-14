using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvpApp.Views;
using MvpApp.Core;

namespace MvpApp.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private IMainView View;

        public void Initialize(IView view, params ViewParameter[] parameters)
        {
            this.View = view as IMainView;
            var currentUserParam = parameters.First(x => x.ParameterName == "currentUser");
            this.View.CurrentUser = currentUserParam.Value;
        }
    }
}
