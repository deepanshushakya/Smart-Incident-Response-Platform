namespace SmartIncidentManagement.Controllers
{
    public interface IIncidentController
    {
        void GetIncidents();
        void CreateIncident(string name);
    }
}
