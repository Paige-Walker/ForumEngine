namespace Service
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    using Data.Repository.Implementation;
    using Data.Repository.Interface;

    public static class ServiceStart
    {
        public static void RegisterDependencies(this IServiceCollection collection)
        {
            collection.Add(new ServiceDescriptor(typeof(IRepository<>), typeof(RepositoryBase<>), ServiceLifetime.Transient));
        }
    }
}