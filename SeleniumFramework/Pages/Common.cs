using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetPageTitle()
        {
            return Driver.GetDriver().Title;
        }

        internal static void ClickElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static string GetElementAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static void WaitForElementToBeEnabled(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).Enabled == true);
        }

        internal static bool GetElementEnabledStatus(string locator)
        {
            return GetElement(locator).Enabled;
        }

        internal static string GetElementCssPropertyValue(string locator, string propertyName)
        {
            return GetElement(locator).GetCssValue(propertyName);
        }

        internal static void WaitForElementCssPropertyToBe(string locator, string propertyName, string expectedPropertyValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.XPath(locator)).GetCssValue(propertyName) == expectedPropertyValue);
        }

        internal static void WaitForElementToBeVisisble(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }

        internal static void DoubleClickElement(string locator)
        {
            IWebElement element = GetElement(locator);

            Actions actions = new Actions(Driver.GetDriver());
            actions.DoubleClick(element);

            actions.Perform();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static SelectElement GetSelectElement(string locator)
        {
            IWebElement element = GetElement(locator);
            return new SelectElement(element);
        }

        internal static void SelectOptionByText(string locator, string optionText)
        {
            SelectElement selectElement = GetSelectElement(locator);
            selectElement.SelectByText(optionText);
        }

        internal static string GetSelectedOption(string locator)
        {
            SelectElement selectElement = GetSelectElement(locator);
            return selectElement.SelectedOption.Text;
        }

        internal static void AcceptAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Accept();
        }

        internal static void DismissAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Dismiss();
        }

        internal static bool IsAlertPresent()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        internal static void SendKeysToAlert(string keys)
        {
            Driver.GetDriver().SwitchTo().Alert().SendKeys(keys);
        }

        internal static bool IsElementPresent(string locator)
        {
            try
            {
                GetElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
