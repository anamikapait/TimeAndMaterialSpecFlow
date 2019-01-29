using System;
using Industryconnect.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace IndustryConnectSpecFlow.Helpers
{
    class Wait
    {
        public static void WaitForElementPresentAndEnabled(By locator, int secondsToWait = 30)
        {
            new WebDriverWait(CommonDriver.driver, new TimeSpan(0, 0, secondsToWait))
               .Until(d => d.FindElement(locator).Enabled
                   && d.FindElement(locator).Displayed
                   && d.FindElement(locator).GetAttribute("aria-disabled") == null);
                  }
    }
}
