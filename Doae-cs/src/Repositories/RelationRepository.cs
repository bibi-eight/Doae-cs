using Doae.Repositories.Interfaces;
using Doae.database;
using Doae.Models;
using Microsoft.EntityFrameworkCore;

namespace Doae.Repositories
{
    public class RelationRepository : IRelationRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public RelationRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }

        public async Task<RelationModel?> FindRelationById(int id)
        {
            return await _dbContext.Relations.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<RelationModel>> FindRelationByIdProduct(int productId)
        {
            return await _dbContext.Relations.Where(x => x.ProductId == productId).ToListAsync();
        }

        public async Task<List<RelationModel>> FindRelationByIdTarget(int targetId)
        {
            return await _dbContext.Relations.Where(x => x.TargetId == targetId).ToListAsync();
        }
        public async Task<RelationModel> CreateRelation(RelationModel relation)
        {
            await _dbContext.Relations.AddAsync(relation);
            await _dbContext.SaveChangesAsync();

            return relation;
        }

        public async Task<bool?> DeleteRelation(int id)
        {
            RelationModel? relationById = await FindRelationById(id);

           if(relationById == null)
           {
            return null;
           }
           _dbContext.Relations.Remove(relationById);
           await _dbContext.SaveChangesAsync();

           return true;
        }

    }
}