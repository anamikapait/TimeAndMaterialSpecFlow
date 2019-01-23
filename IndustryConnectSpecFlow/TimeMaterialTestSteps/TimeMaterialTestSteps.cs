using System;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using Industryconnect.Helpers;
using Industryconnect.Pages;

namespace IndustryConnectSpecFlow.TimeMaterialTestSteps
{
    [Binding]
    public class TimeMaterialTestSteps
    {
        [Given("I have logged into the portal")]
        public void GivenIhaveloggedintotheportal()
        {
            CommonDriver.driver = new ChromeDriver(@"/Users/oiyo/Projects/IndustryconnectSpecFlow/IndustryconnectSpecFlow/");

            LoginPage LoginObject = new LoginPage();
            LoginObject.loginSteps(CommonDriver.driver);

        }

        [When("I have navigated to the Time and Material Page")]
        public void ThenIhavenavigatedtotheTimeandMaterialPage()
        {
            HomePage HomeObject = new HomePage();
            HomeObject.navigateToTM(CommonDriver.driver);
        }

        [Then("I have added new Time and Material successfully")]
        public void ThenIhaveaddednewTimeandMaterialsuccessfully()
        {
            TimeMaterialPage TMObject = new TimeMaterialPage();
            TMObject.addTM(CommonDriver.driver);
            CommonDriver.driver.Close();
        }

        [Then(@"I have edited the first Time and Material Successfully")]
        public void ThenIHaveEditedTheFirstTimeAndMaterialSuccessfully()
        {
            TimeMaterialPage TMObject = new TimeMaterialPage();
            TMObject.editTM(CommonDriver.driver);
            CommonDriver.driver.Close();
        }

        [Then(@"I have deleted one Time and Material successfully")]
        public void ThenIHaveDeletedOneTimeAndMaterialSuccessfully()
        {

            TimeMaterialPage TMObject = new TimeMaterialPage();
            TMObject.deleteTM(CommonDriver.driver);
            CommonDriver.driver.Close();
        }


    }
}
