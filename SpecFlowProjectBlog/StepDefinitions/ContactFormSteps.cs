using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TechTalk.SpecFlow;

namespace SpecFlowProjectBlog.StepDefinitions
{
    internal class ContactFormSteps
    {
        private IWebDriver driver;
        public ContactFormSteps() {
            driver = (IWebDriver)ScenarioContext.Current["driver"];
        }

        [Given(@"I enter to ""(.*)"" page")]
        public void GivenIEnterToPage(string name)
        {
            string url = null;
            if (name == "home")
                url = "https://courseofautomationtesting.wordpress.com/";
            driver.Navigate().GoToUrl(url);

        }

        [Given(@"I click on ""(.*)"" in menu")]
        public void GivenIClickInInMenu(string option)
        {
            var menuElements = driver.FindElements(By.ClassName("menu-primary-container"));

            switch (option)
            {
                case "Home":
                    menuElements.First(x => x.Text == "Home").Click();
                    break;

                case "About":
                    menuElements.First(x => x.Text == "About").Click(); 
                    break;

                case "Cpntact":
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
            var submitBtn = driver.FindElement(By.ClassName("pushbutton-wide"));
            name.SendKeys("Name");
            email.SendKeys("test@email.com");
            website.SendKeys("www.mytest.site");
            comment.SendKeys("My test comment");
            submitBtn.Click();
        }

        [Then(@"I expect to see message as ""(.*)""")]
        public void ThenIExpectToSeeMessage(string message)
        {
            var expectedText = driver.FindElement(By.Id("contact-form-success-header"));
            Assert.AreEqual(expectedText.Text, message);
        }




    }
}
