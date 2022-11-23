using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IDonationRepository
    {
        Task<List<DonationModel>>FindAllDonations();
        Task<DonationModel?>FindDonationById(int id);
        Task<List<DonationModel>>FindDonationByIdInstitution(int institutionId);
        Task<List<DonationModel>>FindDonationByIdTarget(int targetId);
        Task<DonationModel>CreateDonation(DonationModel donation);
        Task<DonationModel?>UpdateStatusDonation(DonationModel donation, int id);
        Task<bool>DeleteDonation(int id);
    }
}