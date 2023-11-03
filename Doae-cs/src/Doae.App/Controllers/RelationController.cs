using Microsoft.AspNetCore.Mvc;
using Doae.Repositories.Interfaces;
using Doae.Models;

namespace Doae.Controllers
{
    [ApiController]
    [Route("doae/[controller]")]

    public class RelationController: ControllerBase
    {
        private readonly IRelationRepository _relationRepository;

        public RelationController(IRelationRepository relationRepository)
        {
            _relationRepository = relationRepository;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<RelationModel?>>FindRelationById(int id)
        {
            RelationModel? relation = await _relationRepository.FindRelationById(id);
            return Ok(relation);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<List<RelationModel>>>FindRelationByIdProduct(int productId)
        {
            List<RelationModel> relations = await _relationRepository.FindRelationByIdProduct(productId);
            return Ok(relations);
        }

        [HttpGet("{targetId}")]
        public async Task<ActionResult<List<RelationModel>>>FindRelationByIdTarget(int targetId)
        {
            List<RelationModel> relations = await _relationRepository.FindRelationByIdTarget(targetId);
            return Ok(relations);

        }

        [HttpPost]
        public async Task<ActionResult<RelationModel>>CreateRelation([FromBody] RelationModel relationModel)
        {
            RelationModel relation = await _relationRepository.CreateRelation(relationModel);
            return Ok(relation);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<RelationModel?>>DeleteRelation(int id)
        {
           bool? deleted = await _relationRepository.DeleteRelation(id);
           if(deleted == null )
           {
            return NotFound($"Relação por id: {id} não foi encontrado pelo banco de dados");
           }
           return Ok(deleted);             

        }
    }
}
