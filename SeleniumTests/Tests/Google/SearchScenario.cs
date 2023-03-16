using NUnit.Framework;
using SeleniumFramework.Pages.Google;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.Google
{
    internal class SearchScenario : BaseTest
    {
        [Test]
        public void BasicSearch()
        {
            string phrase = "Hello world!";
            string expectedResult = $"{phrase} - „Google“ paieška";

            HomePage.Open();
            HomePage.RejectAllCookies();
            HomePage.EnterSearchPhrase(phrase);
            HomePage.ClickSearchButton();
            string actualResult = SearchPage.GetPageTitle();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
