using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.DemoQA
{
    internal class DynamicPropertiesScenario : BaseTest
    {
        [Test]
        public void WaitForButtonToBeEnabled()
        {
            bool expectedResult = true;

            DynamicPropertiesPage.Open();
            DynamicPropertiesPage.WaitForButtonToBeEnabled();
            bool actualResult = DynamicPropertiesPage.IsButtonIsEnabled();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void WaitForButtonToChangeColor()
        {
            string expectedButtonTextColor = "rgba(220, 53, 69, 1)";

            DynamicPropertiesPage.Open();
            DynamicPropertiesPage.WaitForButtonColorToBe(expectedButtonTextColor);
            string actualButtonTextColor = DynamicPropertiesPage.GetButtonTextColor();
            
            Assert.AreEqual(actualButtonTextColor, expectedButtonTextColor);
        }

        [Test]
        public void WaitForButtonToBeVisible()
        {
            DynamicPropertiesPage.Open();
            DynamicPropertiesPage.WaitForButtonToBeVisible();

            // Dėl tvarkos vis tiek reikėtų Assert
            // Nors realiai jeigu testas passina tai vadinasi buvo sulaukta tinkamos sąlygos
        }
    }
}
