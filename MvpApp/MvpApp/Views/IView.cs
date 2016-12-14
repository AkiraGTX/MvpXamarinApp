using MvpApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpApp.Views
{
    public interface IView
    {
        void InitializePresenter(params ViewParameter[] parameters);
    }
}
