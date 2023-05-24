using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace SpecFlowProjectBlog.Settings
{
    [Binding]
    public sealed class Hooks1
    {
        private IWebDriver driver;

        [BeforeScenario("@tag1")]
        public void BeforeScenario()
        {
 
            driver = DriverFactory
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}