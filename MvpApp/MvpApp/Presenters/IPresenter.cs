using MvpApp.Core;
using MvpApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpApp.Presenters
{
    public interface IPresenter
    {
        void Initialize(IView view, params ViewParameter[] parameters);
    }
}
