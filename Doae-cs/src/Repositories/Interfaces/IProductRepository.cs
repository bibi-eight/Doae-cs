using Doae.Models;

namespace Doae.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductModel?>FindProductById(int id);
        Task<List<ProductModel>>FindProductsByIdInstitution(int institutionId);
        Task<ProductModel> CreateProduct(ProductModel product);
        Task<ProductModel?> UpdateProduct(ProductModel product, int id);
        Task<bool?> DeleteProduct(int id);
    }
}