using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface ITargetRepository
    {
        Task<List<TargetModel>> FindAllTargets();
        Task<List<TargetModel>> FindTargetByIdInstitution(int institutionId);
        Task<TargetModel> FindTargetById(int id);
        Task<TargetModel> CreateTarget(TargetModel target);
        Task<TargetModel> UpdateCurrentQuantity(TargetModel target, int id);
        Task<TargetModel> UpdateTarget(TargetModel target, int id);
        Task<bool> DeleteTarget(int id);

    }
}