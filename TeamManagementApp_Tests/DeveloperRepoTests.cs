using DevTeamRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TeamManagementApp_Tests
{
    [TestClass]
    public class DeveloperRepoTests
    {
        private DeveloperRepo _developerRepo;
        private Developer _developer;
        [TestInitialize]
        public void Arrange()
        {
            _developerRepo = new DeveloperRepo();
            _developer = new Developer("Adam", "Sadler", true);

            _developerRepo.AddDeveloperToList(_developer);
        }

        [TestMethod]
        public void UpdateDeveloperInfo_IsNotNull_ReturnTrue()
        {
            Developer newDeveloper = new Developer("Allyssa", "Perry", false);

            bool wasUpdated = _developerRepo.UpdateDeveloperInfo(1, newDeveloper);

            Assert.IsTrue(wasUpdated);
        }
    }
}
