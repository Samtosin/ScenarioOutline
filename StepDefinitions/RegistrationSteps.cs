using NUnit.Framework;
using OpenQA.Selenium;
using ScenarioOutline.Hook;
using ScenarioOutline.PageObject;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace ScenarioOutline.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        public IWebDriver driver = WebHooks.driver;
        RegistrationPage registrationPage = new RegistrationPage();

        [Given(@"i navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            driver.Navigate().GoToUrl("https://developertraining.reteicons.com/Rita/index.php/automation-form/");
        }

        [Given(@"i enter firstname ""([^""]*)""")]
        public void GivenIEnterFirstname(string firstname)
        {
            Thread.Sleep(1000);
            registrationPage.EnterFirstname(firstname);
        }

        [Given(@"i enter lastname ""([^""]*)""")]
        public void GivenIEnterLastname(string lastname)
        {
            Thread.Sleep(1000);
            registrationPage.EnterLastname(lastname);
        }

        [Given(@"i enter email ""([^""]*)""")]
        public void GivenIEnterEmail(string email)
        {
            Thread.Sleep(1000);
            registrationPage.EnterEmail(email);
        }

        [Given(@"i enter the height ""([^""]*)""")]
        public void GivenIEnterTheHeight(string height)
        {
            Thread.Sleep(1000);
            registrationPage.EnterHeight(height);
        }

        [Given(@"i entered location ""([^""]*)""")]
        public void GivenIEnteredLocation(string location)
        {
            Thread.Sleep(1000);
            registrationPage.EnterLocation(location);
        }

        [Given(@"i enter hobbies ""([^""]*)""")]
        public void GivenIEnerHobbies(string hobbies)
        {
            Thread.Sleep(1000);
            registrationPage.EnterHobbies(hobbies);
        }

        [Given(@"i select career progression ""([^""]*)""")]
        public void GivenISelectCourseChoice(string career)
        {
            Thread.Sleep(1000); 
            registrationPage.SelectCourseChoice(career);
        }

        [When(@"i click submit")]
        public void WhenIClickSubmit()
        {
            Thread.Sleep(1000);
            registrationPage.ClickSubmit();
        }

        [Then(@"i should be register successfully")]
        public void ThenIShouldBeRegisterSuccessfully()
        {
            Assert.IsTrue(registrationPage.RegistrationIsSuccessful());
        }
    }
}
