using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Skill
{
    public class AddUpdateDeleteSkillComponent:GlobalHelpers
    {
        private IWebElement addSkill;
        private IWebElement chooseSkillLevelDropdown;
        private IWebElement addBtn;
        private IWebElement cancelBtn;
        private IWebElement successMessage;
        private IWebElement closeIcon;
        private IWebElement skillToBeUpdated;
        private IWebElement skillLevelToBeUpdated;
        private IWebElement updateBtn;
        private IWebElement updateCancelBtn;
        public void renderAddComponents()
        {
            addSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            chooseSkillLevelDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            addBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            cancelBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
        }

        public void renderUpdateComponents()
        {
            skillToBeUpdated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            skillLevelToBeUpdated = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select"));
            updateBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateCancelBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
        }
        public void renderAddSuccesMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            closeIcon = driver.FindElement(By.XPath("/html/body/div[1]/a"));
        }

        public void renderUpdateSuccesMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            closeIcon = driver.FindElement(By.XPath("/html/body/div[1]/a"));
        }
        public void AddSkill(AddSkill skill)
        {
            renderAddComponents();
            addSkill.SendKeys(skill.Skill);
            chooseSkillLevelDropdown.SendKeys(skill.SkillLevel);
            addBtn.Click();
        }
        public string GetAddSuccessMessage()
        {
            Thread.Sleep(1000);
            renderAddSuccesMessage();
            string message = successMessage.Text;
            Thread.Sleep(1000);
            closeIcon.Click();
            if (message == "Please enter skill and experience level")
            {
                cancelBtn.Click();
            }

            return message;
        }

        public void UpdateSkill(UpdatedSkill skill)
        {
            renderUpdateComponents();
            skillToBeUpdated.Clear();
            skillToBeUpdated.SendKeys(skill.SkillToBeUpdated);
            skillLevelToBeUpdated.SendKeys(skill.SkillLevelToBeUpdated);
            updateBtn.Click();
        }
        public string GetUpdateSuccessMessage()
        {
            Thread.Sleep(1000);
            renderAddSuccesMessage();
            string message = successMessage.Text;
            Thread.Sleep(1000);
            closeIcon.Click();
            if (message == "Please enter skill and experience level")
            {
                cancelBtn.Click();
            }

            return message;
        }
        public void renderDeleteSuccessMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            closeIcon = driver.FindElement(By.XPath("/html/body/div[1]/a"));

        }
        public string GetDeleteSuccessMessage()
        {
            Thread.Sleep(1000);
            renderDeleteSuccessMessage();
            string message = successMessage.Text;
            Thread.Sleep(1000);
            closeIcon.Click();
            return message;
        }

        public void DeleteSkill()
        {
            renderDeleteSuccessMessage();
        }

        public void AddSkillWithoutSkillLevel(AddSkill skill)
        {
            renderAddComponents();
            addSkill.SendKeys("");
            chooseSkillLevelDropdown.SendKeys(skill.SkillLevel);
            addBtn.Click();
        }

        public string AddSkillWithoutSkillLevelSuccess()
        {
            Thread.Sleep(1000);
            renderAddSuccesMessage();
            string message = successMessage.Text;
            return message;
        }
    }
}
