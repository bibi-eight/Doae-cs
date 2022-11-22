using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IInstitutionRepository
    {
        Task<List<InstitutionModel>>FindAll();
        Task<InstitutionModel?>FindForId(int id);
        Task<InstitutionModel>Add(InstitutionModel institution);
        Task<InstitutionModel?>Update(InstitutionModel institution, int id);
        Task<InstitutionModel?>UpdateCredentials(InstitutionModel institution, int id);
        Task<bool?>Delete(int id);
    }
}