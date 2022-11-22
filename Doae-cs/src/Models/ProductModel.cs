namespace Doae.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Value { get; set; }
        public int InstitutionId { get; set; }
        public Boolean Suspend { get; set; }
    }
}