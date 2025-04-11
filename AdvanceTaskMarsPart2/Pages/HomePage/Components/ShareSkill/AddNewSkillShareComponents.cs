using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ShareSkill
{
    public class AddNewSkillShareComponents : GlobalHelpers
    {
        private IWebElement titleTextbox;
        private IWebElement descriptionTextbox;
        private IWebElement categoryDropdown;
        private IWebElement tags;
        private IWebElement serviceType;
        private IWebElement locationType;
        private IWebElement availableDays;
        private IWebElement skillTrade;
        private IWebElement skillExchange;
        private IWebElement workSample;
        private IWebElement active;
        private IWebElement saveBtn;
        private IWebElement cancelBtn;
        private IWebElement subCategory;
        private IWebElement newlyAddedShareSkill;
       
        public void renderComponents()
        {
            titleTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            descriptionTextbox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            categoryDropdown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
            tags = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            serviceType = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            locationType = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input"));
            availableDays = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[1]/div/input"));
            skillTrade = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input"));
            skillExchange = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input"));
            workSample = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            active = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input"));
            saveBtn = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            cancelBtn = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[2]"));
            
        }
        public void renderSubcategory()
        {
            subCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
        }
        public void AddNewShareSkill(ShareSkillModel skill)
        {
            Thread.Sleep(1000);
            renderComponents();
            titleTextbox.SendKeys(skill.Title);
            descriptionTextbox.SendKeys(skill.Description);
            categoryDropdown.SendKeys(skill.Category);
            renderSubcategory();
            subCategory.SendKeys(skill.SubCategory);
            tags.SendKeys(skill.tags);
            tags.SendKeys(Keys.Enter);
            serviceType.Click();
            locationType.Click();
            availableDays.Click();
            skillTrade.Click();
            skillExchange.SendKeys(skill.skillExchange);
            skillExchange.SendKeys(Keys.Enter);
            active.Click();
            saveBtn.Click();           
        }
        public void renderSuccessComponents()
        {
            newlyAddedShareSkill = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
        }

        public string VerifySuccess()
        {
            renderSuccessComponents();
            string msg=newlyAddedShareSkill.Text;
            return msg;

        }
    }
}
