namespace SmartIncidentManagement.Factory
{
    public interface IServiceFactory
    {
        T CreateService<T>() where T : class;
    }
}
