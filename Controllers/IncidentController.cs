using SmartIncidentManagement.DbContext;

namespace SmartIncidentManagement.Controllers
{
    public class IncidentController : IIncidentController
    {
        private readonly IDbContext _dbContext;

        public IncidentController(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void GetIncidents()
        {
            _dbContext.Connect();
            Console.WriteLine("Fetching incidents...");
            _dbContext.Disconnect();
        }

        public void CreateIncident(string name)
        {
            _dbContext.Connect();
            Console.WriteLine($"Creating incident: {name}");
            _dbContext.Disconnect();
        }
    }
}
