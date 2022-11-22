using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IDonationRepository
    {
        Task<List<DonationModel>>FindAllDonations();
        Task<DonationModel?>FindDonationForId(int id);
        Task<List<DonationModel>>FindDonationForIdInstitution(int institutionId);
        Task<List<DonationModel>>FindDonationForIdTarget(int targetId);
        Task<DonationModel>CreateDonation(DonationModel donation);
        Task<DonationModel?>UpdateStatusDonation(DonationModel donation, int id);
        Task<bool>DeleteDonation(int id);
    }
}