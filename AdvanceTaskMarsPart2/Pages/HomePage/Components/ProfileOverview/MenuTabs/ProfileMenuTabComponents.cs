using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.MenuTabs
{
    public class ProfileMenuTabComponents:GlobalHelpers
    {

        private IWebElement languageButton;
        private IWebElement educationButton;
        private IWebElement skillButton;
        private IWebElement certificationButton;
        public void renderComponents()
        {
            try
            {

                languageButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
                educationButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
                skillButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                certificationButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void ClickLanguageButton()
        {
            renderComponents();
            languageButton.Click();
        }
        public void ClickSkillButton()
        {
            renderComponents();
            skillButton.Click();
        }
        public void ClickCertificationButton()
        {
            renderComponents();
            certificationButton.Click();
        }
        public void ClickEducationButton()
        {
            renderComponents();
            educationButton.Click();
        }
    }
}
