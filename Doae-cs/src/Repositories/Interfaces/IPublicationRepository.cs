using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IPublicationRepository
    {
        Task<PublicationModel?>FindPublicationById(int id);
        Task<List<PublicationModel>>FindPublicationByIdInstitution(int nstitutionId);
        Task<List<PublicationModel>>FindAllPublications();
        Task<PublicationModel> CreatePublication(PublicationModel publication);
        Task<bool?> DeletePublication(int id);

    }
}