using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.ProfileView.Data.Repository;
using Petzey.ProfileView.Domain.Entities;
using Petzey.ProfileView.Domain.IProfileViewRepository;
using Petzey.ProfileView.Service.BusinessService;
using ProfileViewDTO;
using ProfileViewDTO.Business;

namespace Petzey.ProfileView.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileVController : ControllerBase
    {
        IProfileViewService service;
        public ProfileVController()
        {
            service = new ProfileViewService();

        }
        public IProfileViewRepo repo = new ProfileViewRepository();
        [HttpGet]
        public IActionResult GetProfile()
        {
            return Ok(repo.GetProfileView());
        }

        [HttpGet]
        [Route("Id")]
        public IActionResult ViewProfiles(int id)
        {
            try
            {
               
                ViewProfilesDTO viewProfilesDTO = service.ViewProfiless(id);
                return Ok(viewProfilesDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("edit")]
        public IActionResult EditProfile(ViewProfilesDTO profileViews)
        {
            if(profileViews == null)
            {
                return BadRequest();
            }
            var result = service.EditService(profileViews);
            return Ok(result);
        }
    }
}
