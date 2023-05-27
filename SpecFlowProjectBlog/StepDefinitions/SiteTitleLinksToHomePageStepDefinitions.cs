using NUnit.Framework;
using OpenQA.Selenium;




namespace SpecFlowProjectBlog.StepDefinitions
{
    [Binding]
    public class SiteTitleLinksToHomePageStepDefinitions
    {
        private IWebDriver driver;
        public SiteTitleLinksToHomePageStepDefinitions()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }



        [When(@"I click on Site Title")]
        public void WhenIClickOnSiteTitle()
        {
            var siteTitle = driver.FindElement(By.XPath("//a[@rel='home']"));
            siteTitle.Click();
        }

        [Then(@"I ecpect to go back to Home Page")]
        public void ThenIEcpectToGoBackToHomePage()
        {

            String URL = driver.Url;
            Assert.AreEqual(URL, "https://courseofautomationtesting.wordpress.com/");

        }
    }
}
    

