using CSharpAppwithFSharpDataLayer.Models;
using CSharpAppwithFSharpDataLayer.Repository;
using FSharpDataLayer;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CSharpAppwithFSharpDatalayer
{
    public class Bootstrapper
    {
        public static void Run()
        {
            SetLightInjectContainer();
        }

        private static void SetLightInjectContainer()
        {
            var container = new ServiceContainer();
            container.RegisterControllers(Assembly.GetExecutingAssembly());
            Func<IServiceFactory, IDatabaseFactory> dbFactory = x => { using (x.BeginScope()) { return new DatabaseFactory(new ApplicationDbContext()); } };
            container.Register(dbFactory, new PerScopeLifetime());

            container.Register<IUnitOfWork, UnitOfWork>();
            container.Register(typeof(IRepository<>), typeof(Repository<>));
            container.Register<ITable_1Repository, Table_1Repository>();
            container.EnableMvc();
        }
    }
}