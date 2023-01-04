using Petzey.ProfileView.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.Domain.IProfileViewRepository
{
    public interface IProfileViewRepo
    {
       ProfileViews GetProfileById(int id);
        List<ProfileViews> GetProfileView();

        public bool UpdateProfile(ProfileViews profileViews);
    }
}
