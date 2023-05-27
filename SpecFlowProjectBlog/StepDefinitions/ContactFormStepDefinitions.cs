using NUnit.Framework;
using OpenQA.Selenium;


namespace SpecFlowProjectBlog.StepDefinitions
{
    [Binding]
    public class ContactFormStepDefinitions
    {
        private IWebDriver driver;
        public ContactFormStepDefinitions()
        {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        [Given(@"I enter to '([^']*)' page")]
        public void GivenIEnterToPage(string name)
        {
            string url = null;
            if (name == "home")
                url = "https://courseofautomationtesting.wordpress.com/";
            driver.Navigate().GoToUrl(url);



        }

        [Given(@"I click on '([^']*)' in menu")]
        public void GivenIClickOnInMenu(string option)
        {

            var menuElements = driver.FindElements(By.CssSelector("#site-navigation .menu-item"));

            switch (option)
            {
                case "Home":
                    menuElements.First(x => x.Text == "Home").Click();
                    break;

                case "About":
                    menuElements.First(x => x.Text == "About").Click();
                    break;

                case "Contact":
                    menuElements.First(x => x.Text == "Contact").Click();
                    Assert.True(driver.Url.Contains("/contact"));
                    break;
            }
        }

        [When(@"I fill contact form")]
        public void WhenIFillContactForm()
        {
         
            var name = driver.FindElement(By.Id("g3-name"));
            var email = driver.FindElement(By.Id("g3-email"));
            var website = driver.FindElement(By.Id("g3-website"));
            var comment = driver.FindElement(By.Id("contact-form-comment-g3-comment"));
            var submitBtn = driver.FindElement(By.XPath("//button[@class='pushbutton-wide']"));



            name.SendKeys("Name" + Keys.PageDown);
            email.SendKeys("test@email.com");
            website.SendKeys("www.mytest.site");
            comment.SendKeys("My test comment");


            submitBtn.Click();
        }

        [Then(@"I expect to see message as '([^']*)'")]
        public void ThenIExpectToSeeMessageAs(string message)
        {
            var expectedText = driver.FindElement(By.Id("contact-form-success-header"));
            Assert.AreEqual(expectedText.Text, message);
        }
    }
}
