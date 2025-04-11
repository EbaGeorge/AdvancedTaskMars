using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Skill
{
    public class SkillOverviewComponents:GlobalHelpers
    {

        private IWebElement skillsHeading;
        private IWebElement newSkillAddedCell;
        private IWebElement newSkillLevelAddedCell;
        private IWebElement addNewButton;
        private IWebElement updateIcon;
        private IWebElement deleteIcon;
        public void renderComponents()
        {
            skillsHeading = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[1]/h3"));
            addNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            
        }
        public void renderIconComponents()
        {
            updateIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i"));
            deleteIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
        }
        public void ClickAddNewButton()
        {
            renderComponents();
            addNewButton.Click();
        }
        public void ClickUpdateIcon()
        {
            renderIconComponents();
            updateIcon.Click();
        }
        public void ClickDeleteIcon()
        {
            renderIconComponents();
            deleteIcon.Click();
        }

    }

}
