using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Language
{
    public class LanguageOverviewComponents:GlobalHelpers
    {
        private IWebElement languageHeading;
        private IWebElement newLanguageAddedCell;
        private IWebElement newLanguageLevelAddedCell;
        private IWebElement addNewButton;
        private IWebElement updateIcon;
        private IWebElement deleteIcon;
        public void renderComponents()
        {
            languageHeading = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[1]/h3"));
            addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        }
        public void renderUpdateDeleteComponents()
        {
            updateIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            deleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
        }
    
        public void ClickAddNewButton()
        {
            renderComponents();
            addNewButton.Click(); 
        }
        public void ClickUpdateIcon()
        {
            renderUpdateDeleteComponents();
            Thread.Sleep(3000);
            updateIcon.Click();
        }
        public void ClickDeleteIcon()
        {
            renderUpdateDeleteComponents();
            deleteIcon.Click();
        }

    }
}
