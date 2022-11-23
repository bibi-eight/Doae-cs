using Doae.Repositories.Interfaces;
using Doae.database;
using Doae.Models;
using Microsoft.EntityFrameworkCore;

namespace Doae.Repositories
{
    public class InstitutionRepository : IInstitutionRepository
    {

        private readonly ApplicationDBContext _dbContext;

        public InstitutionRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
         public async Task<List<InstitutionModel>> FindAllInstitutions()
        {
           return await _dbContext.Institutions.ToListAsync();
        }

        public async Task<InstitutionModel?> FindInstitutionById(int id)
        {
           return await _dbContext.Institutions.FirstOrDefaultAsync(x => x.Id ==id);
        }
        public async Task<InstitutionModel> CreateInstitution(InstitutionModel institution)
        {
            await _dbContext.Institutions.AddAsync(institution);
            await _dbContext.SaveChangesAsync();

            return institution;
        }
        public async Task<InstitutionModel?> UpdateInstitution(InstitutionModel institution, int id)
        {
           InstitutionModel? institutionById = await FindInstitutionById(id);

           if(institutionById == null)
           {
            return null;
           }
           institutionById.Name = institution.Name;
           institutionById.Description = institution.Description;
           institutionById.Phone = institution.Phone;
           institutionById.Cep = institution.Cep;
           institutionById.Site = institution.Site;
           institutionById.Pix = institution.Pix;
           institutionById.Agency = institution.Agency;
           institutionById.Count = institution.Count;

           _dbContext.Institutions.Update(institutionById);
           await _dbContext.SaveChangesAsync();

           return institutionById;

        }
        public async Task<InstitutionModel?> UpdateCredentialsInstitution(InstitutionModel institution, int id)
        {
           InstitutionModel? institutionById = await FindInstitutionById(id);

           if(institutionById == null)
           {
            return null;
           }

           institutionById.Email = institution.Email;
           institutionById.Password = institution.Password;

           _dbContext.Institutions.Update(institutionById);
           await _dbContext.SaveChangesAsync();

           return institutionById;

        }
         public async Task<bool?> DeleteInstitution(int id)
        {
            InstitutionModel? institutionById = await FindInstitutionById(id);

           if(institutionById == null)
           {
            return null;
           }
           _dbContext.Institutions.Remove(institutionById);
           await _dbContext.SaveChangesAsync();

           return true;
        }
    }
}