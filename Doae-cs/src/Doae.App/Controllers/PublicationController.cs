using Microsoft.AspNetCore.Mvc;
using Doae.Repositories.Interfaces;
using Doae.Models;

namespace Doae.Controllers
{
    [ApiController]
    [Route("doae/[controller]")]

    public class PublicationController: ControllerBase
    {
        private readonly IPublicationRepository _publicationRepository;

        public PublicationController(IPublicationRepository publicationRepository)
        {
            _publicationRepository = publicationRepository;
        }

        [HttpGet]

        public async Task<ActionResult<List<PublicationModel>>>FindAllPublication()
        {
            List<PublicationModel> publications = await _publicationRepository.FindAllPublications();
            return Ok(publications);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<PublicationModel?>>FindPublicationById(int id)
        {
            PublicationModel? publication = await _publicationRepository.FindPublicationById(id);
            return Ok(publication);
        }

        [HttpGet("{institutionId}")]
        public async Task<ActionResult<List<PublicationModel>>>FindPublicationByIdInstitution(int institutionId)
        {
            List<PublicationModel> publications = await _publicationRepository.FindPublicationByIdInstitution(institutionId);
            return Ok(publications);
        }

        [HttpPost]
        public async Task<ActionResult<PublicationModel>>CreatePublication([FromBody] PublicationModel publicationModel)
        {
            PublicationModel publication = await _publicationRepository.CreatePublication(publicationModel);
            return Ok(publication);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<PublicationModel?>> UpdatePublication([FromBody] PublicationModel publicationModel, int id)
        {
            publicationModel.Id = id;
            PublicationModel? publication = await _publicationRepository.UpdatePublication(publicationModel, id);
            return Ok(publication);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PublicationModel?>>DeletePublication(int id)
        {
           bool? deleted = await _publicationRepository.DeletePublication(id);
           return Ok(deleted);             

        }
    }
}