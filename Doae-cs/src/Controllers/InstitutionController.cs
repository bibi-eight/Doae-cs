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

        public async Task<ActionResult<List<InstitutionModel>>>FindAllInstitutions()
        {
            List<InstitutionModel> institutions = await _institutionRepository.FindAllInstitutions();
            return Ok(institutions);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<InstitutionModel?>>FindInstitutionById(int id)
        {
            InstitutionModel? institution = await _institutionRepository.FindInstitutionById(id);
            return Ok(institution);
        }

        [HttpPost]
        public async Task<ActionResult<InstitutionModel>>CreateInstitution([FromBody] InstitutionModel institutionModel)
        {
            InstitutionModel institution = await _institutionRepository.CreateInstitution(institutionModel);
            return Ok(institution);
        }

        [HttpPut("atualizar/{id}")]

        public async Task<ActionResult<InstitutionModel?>> UpdateInstitution([FromBody] InstitutionModel institutionModel, int id)
        {
            institutionModel.Id = id;
            InstitutionModel? institution = await _institutionRepository.UpdateInstitution(institutionModel, id);
            if(institution==null)
            {
                return NotFound($"Instituição por id: {id} não foi encontrado pelo banco de dados");
            }
            return Ok(institution);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<InstitutionModel?>> UpdateCredentialsInstitution([FromBody] InstitutionModel institutionModel, int id)
        {
            institutionModel.Id = id;
            InstitutionModel? institution = await _institutionRepository.UpdateCredentialsInstitution(institutionModel, id);
            
            if(institution==null)
            {
                return NotFound($"Instituição por id: {id} não foi encontrado pelo banco de dados");
            }
            return Ok(institution);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<InstitutionModel?>>DeleteInstitution(int id)
        {
           bool? deleted = await _institutionRepository.DeleteInstitution(id);
           if(deleted == null )
           {
            return NotFound($"Instituição por id: {id} não foi encontrado pelo banco de dados");
           }
           return Ok(deleted);             

        }
    }

}