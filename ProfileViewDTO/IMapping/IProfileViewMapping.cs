using Petzey.ProfileView.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileViewDTO.IMapping
{
    public interface IProfileViewMapping
    {
        public ViewProfilesDTO ViewProfilesChangetoDto(ProfileViews profile);
        public ProfileViews ChangeProfileViewsDtoToProfileViews(ViewProfilesDTO viewProfilesDTO);
    }
}
