using Microsoft.AspNetCore.Mvc;

namespace Doae.Models
{
    public class InstitutionModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public long Cnpj { get; set; }
        public string? Pix { get; set; }
        public int Agency { get; set; } 
        public int  Count { get; set; }
        public int Cep { get; set; }
        public string? Logo { get; set; }
        public string? Site { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public Boolean Suspend { get; set; }
        public string? Description { get; internal set; }
        public int Phone { get; internal set; }

        public static implicit operator InstitutionModel(ActionResult<InstitutionModel> v)
        {
            throw new NotImplementedException();
        }
    }
}