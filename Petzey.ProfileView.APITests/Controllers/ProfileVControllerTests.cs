using Microsoft.VisualStudio.TestTools.UnitTesting;
using Petzey.ProfileView.API.Controllers;
using Petzey.ProfileView.Data.Repository;
using Petzey.ProfileView.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.API.Controllers.Tests
{
    [TestClass()]
    public class ProfileVControllerTests
    {
        [TestMethod()]
        public void GetProfileViewIdTest()
        {
            int id = 1;
            int expected = 1;
            ProfileVController profileVController = new ProfileVController();
            int actual = id;
            profileVController.ViewProfiles(id);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void GetProfileView()
        {

            ProfileVController profile = new ProfileVController();
            var result = profile.GetProfile();

        }
        [TestMethod()]
        public void UpdateProfileTest()
        {

                ProfileViews profileViews = new ProfileViews();
                profileViews.Id = 1;
                
                ProfileViews.ReferenceEquals(profileViews, new ProfileViews());
                int expected = 1;
                int actual = profileViews.Id;
                {
                ProfileViews profileViews2 = new ProfileViews();
                    profileViews2.Id = 1;
                    profileViews2.Name = "Tarun";
                    profileViews2.Mobile = "1234567890";
                    profileViews2.Location = "Bangalore";
                    profileViews2.URL = "Image";
                }
            Assert.IsTrue(expected == actual);
            }
    }
}
