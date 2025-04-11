using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.SearchSkills
{
    public class SearchSkillOverviewComponents:GlobalHelpers
    {
        private IWebElement searchLogo;
        public void renderComponents()
        {
            searchLogo = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[1]/div[1]/i"));
        }
        public void ClickSearchLogo()
        {
            renderComponents();
            searchLogo.Click();
            Thread.Sleep(3000);
        }
    }
}
