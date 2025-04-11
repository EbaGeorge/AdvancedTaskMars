using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.SearchSkills
{
    public class SearchSkillFilterComponent:GlobalHelpers
    {
        private IWebElement filterHeading;
        private IWebElement online;
        private IWebElement onsite;
        private IWebElement showAll;
        private IWebElement pageNumber;
        private IWebElement skill;
        public void renderComponents()
        {
            filterHeading = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[4]"));
            online = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[1]"));
            onsite= driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[2]"));
            showAll= driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[5]/button[3]"));
            
        }
        public void ClickOnline()
        {
            renderComponents();
            online.Click();
        }
        public void ClickOnsite()
        {
            renderComponents();
            onsite.Click(); 
        }
        public void ClickShowall()
        {
            renderComponents();
            showAll.Click();
        }
        public string SuccessSkillFilter()
        {
          
            renderPageNumber();
            Thread.Sleep(3000);
            pageNumber.Click();
            Thread.Sleep(3000);
           
            renderSuccess();
            Thread.Sleep(2000);
            string title = skill.Text;
            Console.WriteLine(title);
            return title;
        }

        public void renderPageNumber()
        {

            pageNumber = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[9]"));
        }
        public void renderSuccess()
        {

            skill = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div[4]/div[1]/a[2]/p"));

        }
    }
}
