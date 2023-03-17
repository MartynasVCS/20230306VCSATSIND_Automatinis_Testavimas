using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.DemoQA
{
    internal class SelectScenario : BaseTest
    {
        [Test]
        public void SelectInOldStyleSelectMenu()
        {
            string expectedResult = "Purple";

            SelectMenuPage.Open();
            SelectMenuPage.SelectColorInOldStyleSelectMenu(expectedResult);
            string actualResult = SelectMenuPage.GetSelectedColorInOldStyleSelectMenu();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SelectInSelectOneMenu()
        {
            string expectedResult = "Prof.";

            SelectMenuPage.Open();
            SelectMenuPage.SelectValueInSelectOneMenu(expectedResult);
            string actualResult = SelectMenuPage.GetSelectedValueInSelectOneMenu();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
