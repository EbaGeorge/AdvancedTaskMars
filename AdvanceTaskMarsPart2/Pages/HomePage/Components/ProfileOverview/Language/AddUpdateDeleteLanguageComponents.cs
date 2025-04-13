using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Language
{
    public class AddUpdateDeleteLanguageComponents:GlobalHelpers
    {
        private IWebElement addLanguageTextbox;
        private IWebElement chooseLanguageLevelDropdown;
        private IWebElement addButton;
        private IWebElement cancelButton;
        private IWebElement successMessage;
        private IWebElement closeIcon;
        private IWebElement languageToBeUpdated;
        private IWebElement languageLevelToBeUpdated;
        private IWebElement updateButton;
        private IWebElement cancelUpdateButton;
       
        public void renderAddComponents()
        {
            addLanguageTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            chooseLanguageLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            cancelButton=driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
            
        }
        public void renderAddSuccesMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            closeIcon = driver.FindElement(By.XPath("/html/body/div[1]/a"));
        }

        public void renderUpdateComponents()
        {
            languageToBeUpdated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
            languageLevelToBeUpdated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
            updateButton= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            cancelUpdateButton= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
        }

        public void renderUpdateSuccessMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            closeIcon = driver.FindElement(By.XPath("/html/body/div[1]/a"));
        }

        public void renderDeleteSuccessMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            closeIcon = driver.FindElement(By.XPath("/html/body/div[1]/a"));

        }
        public void AddLanguage(AddLanguage language)
        {
            renderAddComponents();
            addLanguageTextbox.SendKeys(language.Language);
            chooseLanguageLevelDropdown.SendKeys(language.LanguageLevel);
            addButton.Click();
        }
        public string GetAddSuccessMessage()
        {
            Thread.Sleep(1000);
            renderAddSuccesMessage();            
            string message=successMessage.Text;
            Thread.Sleep(1000);
            closeIcon.Click();
            if(message == "Please enter language and level")
            {
                cancelButton.Click();
            }

            return message;
        }
       
        //Update Language Record
        public void UpdateLanguage(UpdateLanguage language)
        {                   
            renderUpdateComponents();  
            languageToBeUpdated.Clear();
            languageToBeUpdated.SendKeys(language.LanguageToBeUpdated);           
            languageLevelToBeUpdated.SendKeys(language.LanguageLevelToBeUpdated);         
            updateButton.Click();
        }
        public string GetUpdateSuccessMessage()
        {
            Thread.Sleep(1000);
            renderUpdateSuccessMessage();
            Thread.Sleep(1000);
            string message = successMessage.Text;
            Thread.Sleep(1000);
            closeIcon.Click();
            if (message == "Please enter language and level")
            {
                cancelButton.Click();
            }

            return message;
        }

        public string GetDeleteSuccessMessage()
        {
            Thread.Sleep(1000);
            renderUpdateSuccessMessage();
            string message = successMessage.Text;
            Thread.Sleep(1000);
            closeIcon.Click();
            return message;
        }

        public void DeleteLanguage()
        {
            renderDeleteSuccessMessage();
        }

        public void AddLanguageWithoutLevel(AddLanguage language)
        {
            renderAddComponents();
            addLanguageTextbox.SendKeys("");
            chooseLanguageLevelDropdown.SendKeys(language.LanguageLevel);
            addButton.Click();
        }

        public string AddLanguageWithoutlevelSuccess()
        {
            renderAddSuccesMessage();
            string message = successMessage.Text;
            return message;

        }
       
    }
}
