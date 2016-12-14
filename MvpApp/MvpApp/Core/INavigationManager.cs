using MvpApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpApp.Core
{
    public interface INavigationManager
    {
        void Navigate<TView>(bool newStack = false, params ViewParameter[] parameters) where TView : IView;
    }
}
