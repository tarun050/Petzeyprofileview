using Petzey.ProfileView.Domain.Entities;
using ProfileViewDTO;
using ProfileViewDTO.IMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.Service.MappingService
{
    public class ProfileViewMapping : IProfileViewMapping
    {
        public ProfileViews ChangeProfileViewsDtoToProfileViews(ViewProfilesDTO viewProfilesDTO)
        {
            ProfileViews profile = new ProfileViews()
            {
                Id = viewProfilesDTO.Id,
                Name = viewProfilesDTO.Name,
                Mobile = viewProfilesDTO.Mobile,
                Location = viewProfilesDTO.Location,
                URL = viewProfilesDTO.URL,
            };
            return profile;
        }

        public ViewProfilesDTO ViewProfilesChangetoDto(ProfileViews profile)
        {
            //throw new NotImplementedException();
            ViewProfilesDTO view = new ViewProfilesDTO();
            {
                view.Id = profile.Id;
                view.Name = profile.Name;
                view.Mobile = profile.Mobile;
                view.Location = profile.Location;
                view.URL = profile.URL;

            };
            return view;
        }
    }
}
