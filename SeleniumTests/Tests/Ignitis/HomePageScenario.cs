using NUnit.Framework;
using SeleniumFramework.Pages.Ignitis;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.Ignitis
{
    internal class HomePageScenario : BaseTestExistingProfile
    {
        [Test]
        public void OpenHomePage()
        {
            string expectedTitle = "Kuriame energetiškai sumanų pasaulį | Ignitis";

            HomePage.Open();
            string actualTitle = HomePage.GetPageTitle();

            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}
