using Doae.Repositories.Interfaces;
using Doae.database;
using Doae.Models;
using Microsoft.EntityFrameworkCore;

namespace Doae.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDBContext _dbContext;

        public ProductRepository(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
        public async Task<ProductModel?> FindProductById(int id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id ==id);
        }

        public async Task<List<ProductModel>> FindProductsByIdInstitution(int institutionId)
        {
            return await _dbContext.Products.Where(x => x.InstitutionId == institutionId).ToListAsync();
        }

        public async Task<ProductModel> CreateProduct(ProductModel product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();

            return product;
        }
         public async Task<ProductModel?> UpdateProduct(ProductModel product, int id)
        {
            ProductModel? productById = await FindProductById(id);

            if (productById == null)
            {
                return null;
            }

            productById.Name = product.Name;
            productById.Value = product.Value;

            _dbContext.Products.Update(productById);
            await _dbContext.SaveChangesAsync();

            return productById;
        }

        public async Task<bool?> DeleteProduct(int id)
        {
            ProductModel? productById = await FindProductById(id);

           if(productById == null)
           {
            return null;
           }
           _dbContext.Products.Remove(productById);
           await _dbContext.SaveChangesAsync();

           return true;
        }
    }
}