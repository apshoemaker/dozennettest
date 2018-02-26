using DozenNetTest.Domain.Utils;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using DozenNetTest.Domain.Contexts;
using DozenNetTest.Domain.Repositories;
using DozenNetTest.Domain.Services;
using DozenNetTest.Domain.Mappings;

[assembly:  OwinStartup(typeof(DozenNetTest.Startup))]
namespace DozenNetTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
            app.UseAutofacWebApi(config);
            this.ConfigureIoc();
        }

        public void ConfigureIoc()
        {
            Ioc.Builder = new ContainerBuilder();

            Ioc.Builder.RegisterType<ApplicationContext>().As<IApplicationContext>().InstancePerLifetimeScope();
            Ioc.Builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            Ioc.Builder.RegisterType<Mapper>().As<IMapper>().InstancePerLifetimeScope();

            Ioc.Builder.RegisterType<SchoolService>().As<ISchoolService>().InstancePerLifetimeScope();

            Ioc.Builder.RegisterApiControllers(System.Reflection.Assembly.GetExecutingAssembly());

            Ioc.Container = Ioc.Builder.Build();
            Ioc.Resolver = new AutofacWebApiDependencyResolver(Ioc.Container);
            GlobalConfiguration.Configuration.DependencyResolver = Ioc.Resolver;
        }
    }
}