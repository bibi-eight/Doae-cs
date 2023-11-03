namespace Doae.Models
{
    public class DonationModel
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public string? EmailGiver { get; set; }
        public double Value { get; set; }
        public int TargetId { get; set; }
        public int ProductId { get; set; }
        public Boolean Status { get; set; }
        
    }
}