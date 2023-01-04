using Microsoft.VisualStudio.TestTools.UnitTesting;
using Petzey.ProfileView.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.Data.Repository.Tests
{
    [TestClass()]
    public class ProfileViewRepositoryTests
    {
        [TestMethod()]
        public void GetProfileByIdTest()
        {
            int id = 1;
            int expected = 1;
            ProfileViewRepository repository = new ProfileViewRepository();
            int actual = id;
            repository.GetProfileById(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetProfileView()
        {

            ProfileViewRepository repository = new ProfileViewRepository();
            var result = repository.GetProfileView();


        }

    }
}