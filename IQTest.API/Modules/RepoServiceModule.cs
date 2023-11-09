using Autofac;
using IQTest.Core.Repositories;
using IQTest.Core.Services;
using IQTest.Core.UnitOfWorks;
using IQTest.Repository;
using IQTest.Repository.Repositories;
using IQTest.Repository.UnitOfWorks;
using IQTest.Service.Mapping;
using IQTest.Service.Services;
using System.Reflection;
using Module = Autofac.Module;
namespace IQTest.API.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var apiAssembly = Assembly.GetExecutingAssembly();

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


            //InstancePerLifeTimeScope => Scope ye denk geliyor
            // InstancePerDependecy => transient

        }
    }
}
