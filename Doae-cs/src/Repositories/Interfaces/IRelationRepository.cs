using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IRelationRepository
    {
        Task<ProductModel?>FindRelationById(int id);
        Task<List<ProductModel>>FindRelationByIdTarget(int targetId);
        Task<List<ProductModel>>FindRelationByIdProduct(int productId);
        Task<ProductModel> CreateRelation(ProductModel product);
        Task<ProductModel?> UpdateRelation(ProductModel product, int id);
        Task<bool?> DeleteRelation(int id);
    }
}