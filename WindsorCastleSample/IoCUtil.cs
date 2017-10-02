using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Windsor.Project.Interfaces;
using Windsor.Project.MessageSenders;
using Windsor.Project.Loggers;
using Castle.Windsor.Configuration.Interpreters;
using Castle.Core.Resource;

namespace Windsor.Project
{
    public static class IoCUtil
    {
        private static IWindsorContainer _container = null;
        private static IWindsorContainer Container 
        { 
            get
            {
                if (_container == null)
                {
                    _container = BootstrapContainer();
                }
                return _container;
            }
        }

        private static IWindsorContainer BootstrapContainer()
        {
            //config dosyasından tanımlamalar için bu kod açık olmalı.
            //return new WindsorContainer(new XmlInterpreter(new ConfigResource("castle")));

            //Kod tarafından tanımlama için aşağıdaki kod açık olmalı.
            return new WindsorContainer().Register(
                    Component.For<Interceptor>().LifeStyle.Transient,
                    Component.For<IMessageSender>().ImplementedBy<MailSender>().Interceptors<Interceptor>(),
                    Component.For<ILogger>().ImplementedBy<DBLogger>().Interceptors<Interceptor>()
            );
        }
        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
