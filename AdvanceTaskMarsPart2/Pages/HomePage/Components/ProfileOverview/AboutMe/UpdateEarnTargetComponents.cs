using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.AboutMe
{
    public class UpdateEarnTargetComponents:GlobalHelpers
    {
        private IWebElement earnTargetDropdown;
        private IWebElement closeIcon;
        private IWebElement successMessage;
        public void renderComponents()
        {
            earnTargetDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select"));
            closeIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i"));
        }
        public void renderSucessMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
        }
        public void ClickEarnTarget(EarnTargetModel target)
        {
            renderComponents();
            earnTargetDropdown.SendKeys(target.EarnTarget);
        }
        public string GetSuccessMessage()
        {
            Thread.Sleep(1000);
            renderSucessMessage();
            string message = successMessage.Text;
            Thread.Sleep(1000);
            closeIcon.Click();
            Console.WriteLine(message);
            return message;
        }  
    }
}
