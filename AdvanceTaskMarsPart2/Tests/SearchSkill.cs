using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Steps;
using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium.DevTools.V132.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Tests
{
    public class SearchSkill:GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;
        ShareSkillSteps shareSkill;
        SkillCategorySteps skillCategorySteps;
        SkillFilterSteps skillFilterSteps;
        ShareSkillTests shareSkillTests;
        public SearchSkill()
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
            skillCategorySteps = new SkillCategorySteps();
            shareSkill = new ShareSkillSteps();
            skillFilterSteps = new SkillFilterSteps();
        }
       
        [SetUp]
        public void SetUp()
        {
            Initialise();
            var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");
            login.DoLogin(loginData);
            homePage.ValidateLogin();
        }

        public ShareSkillModel GetShareSkillData()
        {
            var share = DeserializeJson<ShareSkillModel>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\shareSkillData.json");
            return share;
        }
        public SearchSkillModel GetSkillData()
        {
            var search=DeserializeJson<SearchSkillModel>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\searchSkill.json");
            return search;
        }

        //Test to search skill by category
        [Test, Order(1)]
        public void SearchSkillCategory()
        {
            try
            {
                GlobalHelpers.StartTest("SearchSkillCategory");
                GlobalHelpers.LogTestInfo("SearchSkillCategory started");
                var share = GetShareSkillData();
                var search = GetSkillData();
                shareSkill.AddNewShareSkill(share);
                skillCategorySteps.SearchSkillByCategory(search);
                GlobalHelpers.LogTestSuccess("SearchSkillCategory is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("SearchSkillCategory is failed");
            }
        }

        //Test to search skill by subcategory
        [Test, Order(2)]
        public void SearchSkillSubCategory()
        {
            try
            {
                GlobalHelpers.StartTest("SearchSkillSubCategory");
                GlobalHelpers.LogTestInfo("SearchSkillSubCategory is started");
                var share = GetShareSkillData();
                var search = GetSkillData();
                shareSkill.AddNewShareSkill(share);
                skillCategorySteps.SearchSkillBySubCategory(search);
                GlobalHelpers.LogTestSuccess("SearchSkillSubCategory is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("SearchSkillSubCategory is failed");
            }
        }

        //Test to filter skill 
        [Test, Order(3)]
        public void SearchSkillFilter()
        {
            try
            {
                GlobalHelpers.StartTest("SearchSkillFilter");
                GlobalHelpers.LogTestInfo("SearchSkillFilter is started");
                var share = GetShareSkillData();
                var search = GetSkillData();
                shareSkill.AddNewShareSkill(share);
                skillFilterSteps.SkillFilter(search);
                GlobalHelpers.LogTestSuccess("SearchSkillFilter is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("SearchSkillFilter is failed");
            }
        }
    }
}
