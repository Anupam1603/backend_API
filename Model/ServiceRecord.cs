namespace backend_API.Model
{
    public class ServiceRecord
    {
        public int Id { get; set; }  // EF will handle the primary key generation
        public required  int VehicleId { get; set; }
        public required int ServiceAdvisorId { get; set; }
        public required DateTime ServiceDate { get; set; }

        // Navigation properties
        public Vehicle Vehicle { get; set; }
        public ServiceAdvisor ServiceAdvisor { get; set; }
    }
}
