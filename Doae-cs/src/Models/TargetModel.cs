namespace Doae.Models
{
    public class TargetModel
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public string? Name { get; set; }
        public double TargetValue { get; set; }
        public double CurrentyQuantity { get; set; }
        public int TargetId { get; set; }
        public string? Description { get; set; }
        public DateTime DayLimit { get; set; }
        public Boolean Suspend { get; set; }
        
    }
}