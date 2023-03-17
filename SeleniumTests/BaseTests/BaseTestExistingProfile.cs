using NUnit.Framework;
using SeleniumFramework;

namespace SeleniumTests.BaseTests
{
    internal class BaseTestExistingProfile
    {
        [SetUp]
        public void SetUp()
        {
            string userDataDir = "C:\\Users\\Martynas\\AppData\\Local\\Google\\Chrome\\User Data";
            string profileDir = "Profile 5";
            Driver.SetupDriver(userDataDir, profileDir);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
