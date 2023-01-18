using Autofac;
using MiniBlog.Business.Abstractions;
using MiniBlog.Business.Concretes;
using MiniBlog.DataAccess.Abstractions;
using MiniBlog.DataAccess.Concretes;
using MiniBlog.DataAccess.Concretes.EntityFramework;
using MiniBlog.DataAccess.Concretes.EntityFramework.Contexts;
using System.Linq;
using System.Reflection;
using Module = Autofac.Module;

namespace MiniBlog.MVC.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(EfGenericRepositoryDal<>)).As(typeof(IGenericRepositoryDal<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();
            builder.RegisterType<MiniBlogContext>().InstancePerLifetimeScope();

            var repoAssembly = Assembly.GetAssembly(typeof(MiniBlogContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(Service<>));

            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(i => i.Name.EndsWith("Dal"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(repoAssembly, serviceAssembly).Where(i => i.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}