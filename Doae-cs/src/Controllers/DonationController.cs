using Microsoft.AspNetCore.Mvc;
using Doae.Repositories.Interfaces;
using Doae.Models;

namespace Doae.Controllers
{
    [ApiController]
    [Route("doae/[controller]")]

    public class DonationController: ControllerBase
    {
        private readonly IDonationRepository _donationRepository;

        public DonationController(IDonationRepository donationRepository)
        {
            _donationRepository = donationRepository;
        }

        [HttpGet]

        public async Task<ActionResult<List<DonationModel>>>FindAllDonations()
        {
            List<DonationModel> donations = await _donationRepository.FindAllDonations();
            return Ok(donations);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<DonationModel?>>FindDonationForId(int id)
        {
            DonationModel? donation = await _donationRepository.FindDonationForId(id);
            return Ok(donation);
        }

        [HttpGet("{institutionId}")]
        public async Task<ActionResult<List<DonationModel>>>FindDonationForIdInstitution(int institutionId)
        {
            List<DonationModel> donations = await _donationRepository.FindDonationForIdInstitution(institutionId);
            return Ok(donations);
        }

        [HttpGet("{targetId}")]
        public async Task<ActionResult<List<DonationModel>>>FindDonationForIdTarget(int targetId)
        {
            List<DonationModel> donations = await _donationRepository.FindDonationForIdTarget(targetId);
            return Ok(donations);

        }

        [HttpPost]
        public async Task<ActionResult<DonationModel>>CreateDonation([FromBody] DonationModel donationModel)
        {
            DonationModel donation = await _donationRepository.CreateDonation(donationModel);
            return Ok(donation);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<DonationModel?>> UpdateStatusDonation([FromBody] DonationModel donationModel, int id)
        {
            donationModel.Id = id;
            DonationModel? donation = await _donationRepository.UpdateStatusDonation(donationModel, id);
            return Ok(donation);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DonationModel?>>Delete(int id)
        {
           bool deleted = await _donationRepository.DeleteDonation(id);
           return Ok(deleted);             

        }
    }
}