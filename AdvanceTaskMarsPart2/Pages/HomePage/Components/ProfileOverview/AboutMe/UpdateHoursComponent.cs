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
    public class UpdateHoursComponent:GlobalHelpers
    {
        private IWebElement hoursDropdown;
        private IWebElement closeIcon;
        private IWebElement successMessage;
        public void renderComponents()
        {
            hoursDropdown = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select"));
            closeIcon = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
        }
        public void renderSucessMessage()
        {
            successMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
        }
        public void ClickHoursDropdown(HoursModel hours)
        {
            renderComponents();
            hoursDropdown.SendKeys(hours.Hours);
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

