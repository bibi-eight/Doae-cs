using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IInstitutionRepository
    {
        Task<List<InstitutionModel>>FindAllInstitutions();
        Task<InstitutionModel?>FindInstitutionById(int id);
        Task<InstitutionModel>CreateInstitution(InstitutionModel institution);
        Task<InstitutionModel?>UpdateInstitution(InstitutionModel institution, int id);
        Task<InstitutionModel?>UpdateCredentialsInstitution(InstitutionModel institution, int id);
        Task<bool?>DeleteInstitution(int id);
    }
}