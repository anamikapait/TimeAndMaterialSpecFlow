using OpenQA.Selenium;
using System;
namespace IndustryConnectSpecFlow.Helpers
{
    public class CustomMethods
    {
        public static void TextBox(IWebDriver driver, String Locator, String LocatorValue, String TextInput)
        {
            if (Locator == "Id")
            {
                driver.FindElement(By.Id(LocatorValue)).SendKeys(TextInput);
            }
            if (Locator == "XPath")
            {
                driver.FindElement(By.XPath(LocatorValue)).SendKeys(TextInput);
            }
        }
    }
}
