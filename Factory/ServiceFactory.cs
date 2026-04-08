using SmartIncidentManagement.DbContext;

namespace SmartIncidentManagement.Factory
{
    public class ServiceFactory : IServiceFactory
    {
        public T CreateService<T>() where T : class
        {
            var type = typeof(T);

            if (type == typeof(IDbContext))
            {
                return (T)(object)new ApplicationDbContext();
            }

            throw new InvalidOperationException($"Service type {type.Name} is not registered");
        }
    }
}
