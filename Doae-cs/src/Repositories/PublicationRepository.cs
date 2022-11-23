using Doae.Repositories.Interfaces;
using Doae.database;
using Doae.Models;
using Microsoft.EntityFrameworkCore;

namespace Doae.Repositories
{
    public class PublicationRepository : IPublicationRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public PublicationRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

        public async Task<List<PublicationModel>> FindAllPublications()
        {
            return await _dbContext.Publications.ToListAsync();
        }

        public async Task<PublicationModel?> FindPublicationById(int id)
        {
            return await _dbContext.Publications.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<PublicationModel>> FindPublicationByIdInstitution(int institutionId)
        {
            return await _dbContext.Publications.Where(x => x.InstitutionId == institutionId).ToListAsync();
        }

        public async Task<PublicationModel> CreatePublication(PublicationModel publication)
        {
            await _dbContext.Publications.AddAsync(publication);
            await _dbContext.SaveChangesAsync();

            return publication;
        }

        public async Task<PublicationModel?> UpdatePublication(PublicationModel publication, int id)
        {
            PublicationModel? publicationById = await FindPublicationById(id);

            if (publicationById == null)
            {
                throw new Exception($"Doação para o ID: {id} não foi encontrado no banco de dados");
            }

            publicationById.Description = publication.Description;

            _dbContext.Publications.Update(publicationById);
            await _dbContext.SaveChangesAsync();

            return publicationById;
        }

        public async Task<bool?> DeletePublication(int id)
        {
            PublicationModel? publicationById = await FindPublicationById(id);

            if (publicationById == null)
            {
                throw new Exception($"Publicação para o ID:{id} não foi encontrado no banco de dados");
            }

            _dbContext.Publications.Remove(publicationById);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}