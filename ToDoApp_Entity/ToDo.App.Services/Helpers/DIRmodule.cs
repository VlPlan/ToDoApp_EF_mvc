using Microsoft.Extensions.DependencyInjection;
using ToDo.App.DataAccess;
using ToDo.App.DataAccess.Repositories;
using ToDo.App.DataAccess.Repositories.EntityRepositories;
using ToDo.App.Domain;




namespace ToDo.App.Services.Helpers
{
    public static class DIRmodule
    {
        public static IServiceCollection RegisterRepositories(IServiceCollection services)
        {

            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<_Task_>, TaskRepository>();

            return services;
        }
    }

}
