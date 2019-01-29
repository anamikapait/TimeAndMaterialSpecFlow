using System;
using Industryconnect.Helpers;
using IndustryConnectSpecFlow.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Industryconnect.Pages
{
    public class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {

            ExcelLibHelpers.PopulateInCollection(@"/Users/oiyo/Projects/IndustryconnectSpecFlow/IndustryconnectSpecFlow/TestData.xlsx", "LoginPage");

            //Enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Locate Username textbox and enter the username
            //IWebElement Username = driver.FindElement(By.Id("UserName"));
            //Username.SendKeys(ExcelLibHelpers.ReadData(2, "Username"));
            CustomMethods.TextBox(CommonDriver.driver, "Id", "UserName", ExcelLibHelpers.ReadData(2, "Username"));


            //Locate Password textbox and enter the password
            //IWebElement Password = driver.FindElement(By.Id("Password"));
            //Password.SendKeys(ExcelLibHelpers.ReadData(2, "Password"));
            CustomMethods.TextBox(CommonDriver.driver, "Id", "Password", ExcelLibHelpers.ReadData(2, "Password"));


            //Locate the login button and click on it
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();

            //Check if the home page is displayed 
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That(helloHari.Text, Is.EqualTo("Hello hari!"));
            //if (helloHari.Text == "Hello hari!")
            //{
            //    Console.WriteLine("Logged in successfully, Test passed");
            //}
            //else
            //{
            //    Console.WriteLine("Login page not seen, Test Failed");
            //}
        }

        public void loginSteps(IWebDriver driver, string username, string password)
        {
        
            //Enter the url
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //Locate Username textbox and enter the username
            CommonDriver.driver.FindElement(By.Id("UserName")).SendKeys(username);

            //Locate Password textbox and enter the password
            CommonDriver.driver.FindElement(By.Id("Password")).SendKeys(password);

            //Locate the login button and click on it
            IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            Login.Click();

            //Check if the home page is displayed 
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            Assert.That(helloHari.Text, Is.EqualTo("Hello hari!"));
        }
    }
}
