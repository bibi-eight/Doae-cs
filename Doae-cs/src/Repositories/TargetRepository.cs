using Doae.Repositories.Interfaces;
using Doae.database;
using Doae.Models;
using Microsoft.EntityFrameworkCore;

namespace Doae.Repositories
{
    public class TargetRepository : ITargetRepository
    {
        private readonly ApplicationDBContext _dbContext;
        public TargetRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
         public async Task<List<TargetModel>> FindAllTargets()
        {
            return await _dbContext.Targets.ToListAsync();
        }

        public async Task<TargetModel?> FindTargetById(int id)
        {
            return await _dbContext.Targets.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<TargetModel>> FindTargetByIdInstitution(int institutionId)
        {
            return await _dbContext.Targets.Where(x => x.InstitutionId == institutionId).ToListAsync();

        }
        public async Task<TargetModel> CreateTarget(TargetModel target)
        {
            await _dbContext.Targets.AddAsync(target);
            await _dbContext.SaveChangesAsync();

            return target;
        }

        public async Task<TargetModel?> UpdateCurrentQuantity(TargetModel target, int id)
        {
            TargetModel? targetById = await FindTargetById(id);

            if (targetById == null)
            {
                throw new Exception($"Doação para o ID: {id} não foi encontrado no banco de dados");
            }

            targetById.CurrentyQuantity = target.CurrentyQuantity;

            _dbContext.Targets.Update(targetById);
            await _dbContext.SaveChangesAsync();

            return targetById;
        }

        public async Task<TargetModel?> UpdateTarget(TargetModel target, int id)
        {
            TargetModel? targetById = await FindTargetById(id);

            if (targetById == null)
            {
                throw new Exception($"Doação para o ID: {id} não foi encontrado no banco de dados");
            }

            targetById.Name = target.Name;
            targetById.TargetValue = target.TargetValue;

            _dbContext.Targets.Update(targetById);
            await _dbContext.SaveChangesAsync();

            return targetById;
        }
        public async Task<bool?> DeleteTarget(int id)
        {
            TargetModel? targetById = await FindTargetById(id);

            if (targetById == null)
            {
                throw new Exception($"Doação para o ID:{id} não foi encontrado no banco de dados");
            }

            _dbContext.Targets.Remove(targetById);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}    