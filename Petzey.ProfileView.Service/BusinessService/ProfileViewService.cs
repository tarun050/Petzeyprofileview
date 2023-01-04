using Petzey.ProfileView.Data.Repository;
using Petzey.ProfileView.Domain.Entities;
using Petzey.ProfileView.Domain.IProfileViewRepository;
using Petzey.ProfileView.Service.MappingService;
using ProfileViewDTO;
using ProfileViewDTO.Business;
using ProfileViewDTO.IMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.Service.BusinessService
{
    public class ProfileViewService : IProfileViewService
    {
        IProfileViewMapping mapping;
        IProfileViewRepo repo;
        //Constructor
        public ProfileViewService()
        {
            mapping = new ProfileViewMapping();
            repo = new ProfileViewRepository();
        }

        public bool EditService(ViewProfilesDTO viewProfilesDTO)
        {
            ProfileViews profileViews = mapping.ChangeProfileViewsDtoToProfileViews(viewProfilesDTO);
            var result = repo.UpdateProfile(profileViews);
            return result;
        }

        public ViewProfilesDTO ViewProfiless(int ProfileId)
        {
            // throw new NotImplementedException();
            ProfileViews profileViews = repo.GetProfileById(ProfileId);
            ViewProfilesDTO viewProfilesDto = mapping.ViewProfilesChangetoDto(profileViews);
            return viewProfilesDto;

        }
    }
}
