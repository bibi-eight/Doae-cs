using Microsoft.AspNetCore.Mvc;
using Doae.Repositories.Interfaces;
using Doae.Models;

namespace Doae.Controllers
{
    [ApiController]
    [Route("doae/[controller]")]
    
    public class ProductController  : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

       [HttpGet("{id}")]

        public async Task<ActionResult<ProductModel?>> FindProductById(int id)
        {
            ProductModel? product = await _productRepository.FindProductById(id);
            return Ok(product);
        }
        [HttpGet("{institutionId}")]
        public async Task<ActionResult<List<ProductModel>>> FindProductsByIdInstitution(int institutionId)
        {
            List<ProductModel> products = await _productRepository.FindProductsByIdInstitution(institutionId);
            return Ok(products);
        }

        [HttpPost]
        public async Task<ActionResult<ProductModel>> CreateProduct([FromBody] ProductModel productModel)
        {
            ProductModel product = await _productRepository.CreateProduct(productModel);
            return Ok(product);
        }

        [HttpPut("atualizar/{id}")]

        public async Task<ActionResult<ProductModel?>> UpdateProduct([FromBody] ProductModel productModel, int id)
        {
            productModel.Id = id;
            ProductModel? product = await _productRepository.UpdateProduct(productModel, id);
            if (product == null)
            {
                return NotFound($"Produto por id: {id} não foi encontrado pelo banco de dados");
            }
            return Ok(product);
        }
        
        [HttpDelete("{id}")]
         public async Task<ActionResult<ProductModel>> DeleteProduct(int id)
        {
           bool? deleted = await _productRepository.DeleteProduct(id);
           if (deleted == null)
            {
                return NotFound($"Produto por id: {id} não foi encontrado pelo banco de dados");
            }
           return Ok(deleted);
        }
    }
}