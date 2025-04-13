using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.AboutMe
{
    public class AboutMeOverviewComponent:GlobalHelpers
    {
        private IWebElement userName;
        private IWebElement availabillityIcon;
        private IWebElement hoursIcon;
        private IWebElement earnTargetIcon;

        public void renderComponents()
        {
            userName = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]"));
            availabillityIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            hoursIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            earnTargetIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        }

        public void ClickAvailabilltyIcon()
        {
            renderComponents();
            availabillityIcon.Click();
        }
        public void ClickHoursIcon()
        {
            renderComponents();
            hoursIcon.Click();
        }
        public void ClickEarnTargetIcon()
        {
            renderComponents();
            earnTargetIcon.Click();
        }
    }
}
