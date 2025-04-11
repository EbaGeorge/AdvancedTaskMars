using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.ShareSkill
{
    public class ShareSkillComponents:GlobalHelpers
    {
        private IWebElement shareSkillBtn;
        public void renderComponents()
        {
            shareSkillBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
        }
        public void ClickShareSkillButton()
        {
            renderComponents();
            shareSkillBtn.Click(); 
        }
    }
}
