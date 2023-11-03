namespace Doae_api_cs
{
    public class Donations
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public string? EmailGiver { get; set; }
        public double Value { get; set; }
        public int TargetId { get; set; }
        public int ProductId { get; set; }
        public Boolean Status { get; set; }
        public Boolean Suspend { get; set; }
        
    }
}