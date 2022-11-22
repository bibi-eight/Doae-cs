namespace Doae_api_cs
{
    public class Publication
    {
        public int Id { get; set; }
        public int InstitutionId { get; set; }
        public string? Midia { get; set; }
        public string? Description { get; set; }
        public Boolean Suspend { get; set; }
        
    }
}