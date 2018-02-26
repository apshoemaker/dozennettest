using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http.Dependencies;
using Autofac;

namespace DozenNetTest.Domain.Utils
{
    public class Ioc
    {
        public static ContainerBuilder Builder
        {
            get; set;
        }

        public static IContainer Container
        {
            get; set;
        }

        public static IDependencyResolver Resolver
        {
            get; set;
        }
    }
}
