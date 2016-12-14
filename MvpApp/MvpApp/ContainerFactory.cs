using Autofac;
using MvpApp.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpApp
{
    public class ContainerFactory
    {
        private ContainerBuilder ContainerBuilder;

        public ContainerFactory()
        {
            ContainerBuilder = new ContainerBuilder();

            //Common
            ContainerBuilder.RegisterType<LoginPresenter>().As<ILoginPresenter>();
            ContainerBuilder.RegisterType<MainPresenter>().As<IMainPresenter>();
        }

        public void AddRegistrations(Action<ContainerBuilder> builder)
        {
            builder(this.ContainerBuilder);
        }

        public IContainer Build()
        {
            return ContainerBuilder.Build();
        }
    }
}