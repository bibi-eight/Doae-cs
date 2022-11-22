using Doae.Repositories.Interfaces;
using Doae.database;
using Doae.Models;
using Microsoft.EntityFrameworkCore;

namespace Doae.Repositories
{
    public class DonationRepository : IDonationRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public DonationRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
        public async Task<List<DonationModel>> FindAllDonations()
        {
            return await _dbContext.Donations.ToListAsync();
        }

        public async Task<DonationModel?> FindDonationForId(int id)
        {
            return await _dbContext.Donations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<DonationModel>> FindDonationForIdInstitution(int institutionId)
        {
            return await _dbContext.Donations.Where(x => x.InstitutionId == institutionId).ToListAsync();
        }

        public async Task<List<DonationModel>> FindDonationForIdTarget(int targetId)
        {
            return await _dbContext.Donations.Where(x => x.TargetId == targetId).ToListAsync(); 
        }
        public async Task<DonationModel> CreateDonation(DonationModel donation)
        {
            await _dbContext.Donations.AddAsync(donation);
            await _dbContext.SaveChangesAsync();

            return donation;
        }
        public async Task<DonationModel?> UpdateStatusDonation(DonationModel donation, int id)
        {
            DonationModel? donationForId = await FindDonationForId(id);

            if (donationForId == null)
            {
                throw new Exception($"Doação para o ID: {id} não foi encontrado no banco de dados");
            }

            donationForId.Status = donation.Status;

            _dbContext.Donations.Update(donationForId);
            await _dbContext.SaveChangesAsync();

            return donationForId;
        }

        public async Task<bool> DeleteDonation(int id)
        {
            DonationModel? donationForId = await FindDonationForId(id);

            if (donationForId == null)
            {
                throw new Exception($"Doação para o ID:{id} não foi encontrado no banco de dados");
            }

            _dbContext.Donations.Remove(donationForId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}