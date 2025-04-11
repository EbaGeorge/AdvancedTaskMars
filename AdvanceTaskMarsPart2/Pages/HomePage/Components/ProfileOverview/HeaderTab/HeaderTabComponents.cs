using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.HeaderTab
{
    public class HeaderTabComponents:GlobalHelpers

    {
        private IWebElement userNameLabel;
        public void renderComponents()
        {
            Thread.Sleep(3000);
            userNameLabel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            
        }
        public string getFirstName()
        {
            //Return username
            try
            {
                renderComponents();
                return userNameLabel.Text;

            }
            catch (Exception ex)
            {
                driver.Navigate().Refresh();
                return ex.Message;
            }
        }
    }
}
