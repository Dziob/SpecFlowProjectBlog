using OpenQA.Selenium;
using SpecFlowProjectBlog.Helpers;
using TechTalk.SpecFlow;


namespace SpecFlowProjectBlog.Settings
{
    [Binding]
    public sealed class Hooks1
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
 
            driver = DriverFactory.ReturnDriver(DriverType.Chrome);
            ScenarioContext.Current["driver"]= driver;  
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Dispose();
           
            
        }
    }
}