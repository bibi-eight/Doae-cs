using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IPublicationRepository
    {
        Task<PublicationModel?>FindPublicationById(int id);
        Task<List<PublicationModel>>FindPublicationByIdInstitution(int institutionId);
        Task<List<PublicationModel>>FindAllPublications();
        Task<PublicationModel> CreatePublication(PublicationModel publication);
        Task<PublicationModel?> UpdatePublication(PublicationModel publication, int id);
        Task<bool?> DeletePublication(int id);

    }
}