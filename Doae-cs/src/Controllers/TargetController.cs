using Microsoft.AspNetCore.Mvc;
using Doae.Repositories.Interfaces;
using Doae.Models;

namespace Doae.Controllers
{
    [ApiController]
    [Route("doae/[controller]")]

    public class TargetController : ControllerBase
    {
        private readonly ITargetRepository _targetRepository;

        public TargetController(ITargetRepository targetRepository)
        {
            _targetRepository = targetRepository;
        }

        [HttpGet]

        public async Task<ActionResult<List<TargetModel>>> FindAllTargets()
        {
            List<TargetModel> targets = await _targetRepository.FindAllTargets();
            return Ok(targets);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<TargetModel?>> FindTargetById(int id)
        {
            TargetModel? target = await _targetRepository.FindTargetById(id);
            return Ok(target);
        }
        [HttpGet("{institutionId}")]
        public async Task<ActionResult<List<TargetModel>>> FindTargetByIdInstitution(int institutionId)
        {
            List<TargetModel> targets = await _targetRepository.FindTargetByIdInstitution(institutionId);
            return Ok(targets);
        }

        [HttpPost]
        public async Task<ActionResult<TargetModel>> CreateTarget([FromBody] TargetModel targetModel)
        {
            TargetModel target = await _targetRepository.CreateTarget(targetModel);
            return Ok(target);
        }

        [HttpPut("atualizar/{id}")]

        public async Task<ActionResult<TargetModel?>> UpdateCurrentQuantity([FromBody] TargetModel targetModel, int id)
        {
            targetModel.Id = id;
            TargetModel? target = await _targetRepository.UpdateCurrentQuantity(targetModel, id);
            if (target == null)
            {
                return NotFound($"Meta por id: {id} não foi encontrado pelo banco de dados");
            }
            return Ok(target);
        }

        [HttpPut("atualizar/{id}")]
        public async Task<ActionResult<TargetModel?>> UpdateTarget([FromBody] TargetModel targetModel, int id)
        {
            targetModel.Id = id;
            TargetModel? target = await _targetRepository.UpdateTarget(targetModel, id);
            if (target == null)
            {
                return NotFound($"Meta por id: {id} não foi encontrado pelo banco de dados");
            }
            return Ok(target);
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult<TargetModel?>>DeleteTarget(int id)
        {
           bool? deleted = await _targetRepository.DeleteTarget(id);
           if(deleted == null )
           {
            return NotFound($"Meta por id: {id} não foi encontrado pelo banco de dados");
           }
           return Ok(deleted);             

        }
    }
}