using OpenQA.Selenium;
using ScenarioOutline.Hook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioOutline.PageObject
{
    internal class RegistrationPage
    {
        public IWebDriver driver;

        public RegistrationPage()
        {
            driver = WebHooks.driver;
        }

        private By FirstName = By.XPath("//*[@id=\"wpforms-18-field_1\"]");
        private By LastName = By.XPath("//*[@id=\"wpforms-18-field_1-last\"]");
        private By EmailAddy = By.XPath("//*[@id=\"wpforms-18-field_3\"]");
        private By Height = By.XPath("//*[@id=\"wpforms-18-field_7\"]");
        private By Hobbies = By.XPath("//*[@id=\"wpforms-18-field_14\"]");
        private By Location = By.XPath("//*[@id=\"wpforms-18-field_5\"]");
        private By BA = By.XPath("//input[@id='wpforms-18-field_31_1']");
        private By SM = By.XPath("//input[@id='wpforms-18-field_31_4']");
        private By QA = By.XPath("//input[@id='wpforms-18-field_31_3']");
        private By Submit = By.XPath("//*[@id=\"wpforms-submit-18\"]");
        
        public void EnterFirstname(string firstname)
        {
            driver.FindElement(FirstName).SendKeys(firstname);
        }
        public void EnterLastname(string lastname)
        {
           driver.FindElement(LastName).SendKeys(lastname);
        }
        public void EnterEmail(string email)
        {
            driver.FindElement(EmailAddy).SendKeys(email);
        }
        public void EnterHeight(string height)
        {
            driver.FindElement(Height).SendKeys(height);
        }
        public void EnterHobbies(string hobbies)
        {
            driver.FindElement(Hobbies).SendKeys(hobbies);
        }
        public void EnterLocation(string address)
        {
            driver.FindElement(Location).SendKeys(address);
        }
        public void SelectCourseChoice(string career)
        {
            driver.FindElement(BA).Click();
            driver.FindElement(SM).Click();
            driver.FindElement(QA).Click();
        }
        public void ClickSubmit()
        {
            driver.FindElement(Submit).Click();
        }
        public bool RegistrationIsSuccessful()
        {
            return driver.Url.Contains("https://developertraining.reteicons.com/Rita/index.php/automation-form/");
        }


    }
}
