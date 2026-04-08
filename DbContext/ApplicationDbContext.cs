namespace SmartIncidentManagement.DbContext
{
    public class ApplicationDbContext : IDbContext
    {
        public void Connect()
        {
            Console.WriteLine("Connected to database");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from database");
        }
    }
}
