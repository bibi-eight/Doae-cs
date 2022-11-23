using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IRelationRepository
    {
        Task<RelationModel?>FindRelationById(int id);
        Task<List<RelationModel>>FindRelationByIdTarget(int targetId);
        Task<List<RelationModel>>FindRelationByIdProduct(int productId);
        Task<RelationModel> CreateRelation(RelationModel relation);
       
        Task<bool?> DeleteRelation(int id);
    }
}