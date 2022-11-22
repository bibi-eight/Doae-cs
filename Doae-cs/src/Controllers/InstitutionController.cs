using Microsoft.AspNetCore.Mvc;
using Doae.Repositories.Interfaces;
using Doae.Models;

namespace Doae.Controllers
{
    [ApiController]
    [Route("doae/[controller]")]
    public class InstitutionController  : ControllerBase
    {
        private readonly IInstitutionRepository _institutionRepository;

        public InstitutionController(IInstitutionRepository institutionRepository)
        {
            _institutionRepository = institutionRepository;
        }
        
        [HttpGet]

        public async Task<ActionResult<List<InstitutionModel>>>FindAll()
        {
            List<InstitutionModel> institutions = await _institutionRepository.FindAll();
            return Ok(institutions);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<InstitutionModel?>>FindForId(int id)
        {
            InstitutionModel? institution = await _institutionRepository.FindForId(id);
            return Ok(institution);
        }

        [HttpPost]
        public async Task<ActionResult<InstitutionModel>>Add([FromBody] InstitutionModel institutionModel)
        {
            InstitutionModel institution = await _institutionRepository.Add(institutionModel);
            return Ok(institution);
        }

        [HttpPut("atualizar/{id}")]

        public async Task<ActionResult<InstitutionModel?>> Update([FromBody] InstitutionModel institutionModel, int id)
        {
            institutionModel.Id = id;
            InstitutionModel? institution = await _institutionRepository.Update(institutionModel, id);
            if(institution==null)
            {
                return NotFound($"Instituição por id: {id} não foi encontrado pelo banco de dados");
            }
            return Ok(institution);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<InstitutionModel?>> UpdateCredentials([FromBody] InstitutionModel institutionModel, int id)
        {
            institutionModel.Id = id;
            InstitutionModel? institution = await _institutionRepository.UpdateCredentials(institutionModel, id);
            
            if(institution==null)
            {
                return NotFound($"Instituição por id: {id} não foi encontrado pelo banco de dados");
            }
            return Ok(institution);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<InstitutionModel?>>Delete(int id)
        {
           bool? deleted = await _institutionRepository.Delete(id);
           if(deleted == null )
           {
            return NotFound($"Instituição por id: {id} não foi encontrado pelo banco de dados");
           }
           return Ok(deleted);             

        }
    }

}