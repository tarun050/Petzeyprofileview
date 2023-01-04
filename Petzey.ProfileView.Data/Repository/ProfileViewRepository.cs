using Microsoft.EntityFrameworkCore;
using Petzey.ProfileView.Data.DataAcess;
using Petzey.ProfileView.Domain.Entities;
using Petzey.ProfileView.Domain.IProfileViewRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.Data.Repository
{

    public class ProfileViewRepository : IProfileViewRepo
    {
        ProfileViewsDbContext db;
        public ProfileViewRepository()
        {
            db = new ProfileViewsDbContext();
        }
        public ProfileViews GetProfileById(int id)
        {
            return db.Profiles.Find(id);
        }

        public bool UpdateProfile(ProfileViews profileViews)
        {
            db.Update(profileViews);
            db.SaveChanges();
            return true;
        }

       public List<ProfileViews> GetProfileView()
        {
            return db.Profiles.ToList();
        }

    }
}
