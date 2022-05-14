using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using MyFirstApp.Areas.Admin.Models;
using MyFirstApp.Services;

namespace MyFirstApp.Models
{
    public class WebModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleDbService>().As<IDbService>().InstancePerLifetimeScope();
            builder.RegisterType<CourseModel>().AsSelf();
            //builder.RegisterType<Cour>().AsSelf();
            //builder.RegisterType<CourseBatchModel>().AsSelf();
            //builder.RegisterType<ReferralModel>().AsSelf();

            //builder.RegisterType<DataTablesAjaxRequestModel>().As < IDataTablesAjaxReq
            //tModel > ()
            //    .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
