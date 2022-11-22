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
         public async Task<List<InstitutionModel>> FindAll()
        {
           return await _dbContext.Institutions.ToListAsync();
        }

        public async Task<InstitutionModel?> FindForId(int id)
        {
           return await _dbContext.Institutions.FirstOrDefaultAsync(x => x.Id ==id);
        }
        public async Task<InstitutionModel> Add(InstitutionModel institution)
        {
            await _dbContext.Institutions.AddAsync(institution);
            await _dbContext.SaveChangesAsync();

            return institution;
        }
        public async Task<InstitutionModel?> Update(InstitutionModel institution, int id)
        {
           InstitutionModel? institutionForId = await FindForId(id);

           if(institutionForId == null)
           {
            throw new Exception($"Instituição por id: {id} não foi encontrado pelo banco de dados");
           }
           institutionForId.Name = institution.Name;
           institutionForId.Description = institution.Description;
           institutionForId.Phone = institution.Phone;
           institutionForId.Cep = institution.Cep;
           institutionForId.Site = institution.Site;
           institutionForId.Pix = institution.Pix;
           institutionForId.Agency = institution.Agency;
           institutionForId.Count = institution.Count;

           _dbContext.Institutions.Update(institutionForId);
           await _dbContext.SaveChangesAsync();

           return institutionForId;

        }
        public async Task<InstitutionModel?> UpdateCredentials(InstitutionModel institution, int id)
        {
           InstitutionModel? institutionForId = await FindForId(id);

           if(institutionForId == null)
           {
            return null;
           }

           institutionForId.Email = institution.Email;
           institutionForId.Password = institution.Password;

           _dbContext.Institutions.Update(institutionForId);
           await _dbContext.SaveChangesAsync();

           return institutionForId;

        }
         public async Task<bool?> Delete(int id)
        {
            InstitutionModel? institutionForId = await FindForId(id);

           if(institutionForId == null)
           {
            return null;
           }
           _dbContext.Institutions.Remove(institutionForId);
           await _dbContext.SaveChangesAsync();

           return true;
        }
    }
}