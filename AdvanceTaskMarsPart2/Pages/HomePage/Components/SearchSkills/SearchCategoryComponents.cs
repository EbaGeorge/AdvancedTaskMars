using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.HomePage.Components.SearchSkills
{
    public class SearchCategoryComponents:GlobalHelpers
    {
        private IWebElement allCategories;
        private IWebElement graphicsDesign;
        private IWebElement pageNumber;
        private IWebElement skill;
        private IWebElement subCategories;
        public void renderComponents()
        {
            allCategories = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[1]/div/a[1]/b"));
            graphicsDesign = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[1]/div/a[2]"));
           
        }
        public void renderPageNumber()
        {
            pageNumber = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[3]/div[2]/div/button[9]"));
        }
        public void renderSuccess()
        {
            
            skill = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[2]/div/div[2]/div/div/div/div[1]/a[2]"));         

        }
        public void renderSubCategoriesComponents()
        {
            subCategories = driver.FindElement(By.XPath("//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[1]/div/a[3]"));
        }
        public void SearchCategories()
        {
            Thread.Sleep(1000);
            renderComponents();
            Thread.Sleep(1000);
            graphicsDesign.Click();
        }
        public string SuccessSkill()
        {
            Thread.Sleep(3000);
            renderPageNumber();
            pageNumber.Click();
            Thread.Sleep(3000);
            renderSuccess();
            Thread.Sleep(2000);
            string title=skill.Text;
            Console.WriteLine(title);
            return title;
        }

        public void SearchSubCategory()
        {
            SearchCategories();
            renderSubCategoriesComponents();
            subCategories.Click();
        }

        public string SuccessSkillSubCategory()
        {
            Thread.Sleep(3000);
            renderPageNumber();
            pageNumber.Click();
            Thread.Sleep(3000);
            renderSuccess();
            Thread.Sleep(2000);
            string title = skill.Text;
            Console.WriteLine(title);
            return title;
        }

    }
}
