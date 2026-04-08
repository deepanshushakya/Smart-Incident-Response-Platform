namespace SmartIncidentManagement.DbContext
{
    public interface IDbContext
    {
        void Connect();
        void Disconnect();
    }
}
