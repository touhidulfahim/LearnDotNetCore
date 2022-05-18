using Autofac;
using MyFirstApp.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class WebModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<SimpleDatabaseService>().As<IDatabaseService>()
            //    .InstancePerLifetimeScope();

            builder.RegisterType<CourseModel>().AsSelf();

            base.Load(builder);
        }
    }
}
