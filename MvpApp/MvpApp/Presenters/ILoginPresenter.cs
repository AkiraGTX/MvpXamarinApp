﻿using MvpApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpApp.Presenters
{
    public interface ILoginPresenter : IPresenter
    {
        void OnLogin();
    }
}
