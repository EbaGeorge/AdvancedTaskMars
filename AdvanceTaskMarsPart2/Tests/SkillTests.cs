using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.MenuTabs;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Skill;
using AdvanceTaskMarsPart2.Steps;
using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Tests
{
    public class SkillTests:GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;
        SkillSteps skill;
        ProfileMenuTabComponents profileMenuTabComponents;
        

        public SkillTests()
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
            skill = new SkillSteps();
            profileMenuTabComponents = new ProfileMenuTabComponents();
        }

        [SetUp]
        public void SetUp()
        {
            Initialise();
            var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");
            login.DoLogin(loginData);
            homePage.ValidateLogin();
            profileMenuTabComponents.ClickSkillButton();
            DataCleanup();
        }

      

        //Test to add skill
        [Test, Order(1)]
        public void AddSkill()
        {
            try
            {
                GlobalHelpers.StartTest("AddSkill");
                GlobalHelpers.LogTestInfo("AddSkill is started");
                var skillData = DeserializeJson<AddSkill>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\addSkillData.json");
                skill.AddNewSkill(skillData);
                GlobalHelpers.LogTestSuccess("AddSkill is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("AddSkill is failed" +ex.Message);
            }
            
        }

        //Test to update skill
        [Test, Order(2)]
        public void UpdateSkill()
        {
            try
            {
                GlobalHelpers.StartTest("UpdateSkill");
                GlobalHelpers.LogTestInfo("UpdateSkill is started");
                var updateSkill = DeserializeJson<UpdatedSkill>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\updateSkillData.json");
                AddSkill();
                skill.UpdateSkill(updateSkill);
                GlobalHelpers.LogTestSuccess("UpdateSkill is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("UpdateSkill is failed" +ex.Message);
            }
           
        }

        //Test to delete skill
        [Test, Order(3)]
        public void DeleteSkill()
        {
            try
            {
                GlobalHelpers.StartTest("DeleteSkill");
                GlobalHelpers.LogTestInfo("DeleteSkill is started");
                var deleteSkill = DeserializeJson<AddSkill>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\addSkillData.json");
                AddSkill();
                skill.DeleteSkill(deleteSkill);
                GlobalHelpers.LogTestSuccess("DeleteSkill is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("DeleteSkill is failed" +ex.Message);
            }
        }

        //Test to add skill without skill
        [Test, Order(4)]
        public void AddSkillWithoutLevel()
        {
            try
            {
                GlobalHelpers.StartTest("AddSkillWithoutLevel");
                GlobalHelpers.LogTestInfo("AddSkillWithoutLevel is started");
                var addWithoutSkill = DeserializeJson<AddSkill>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\addSkillWithoutSkill.json");
                skill.AddNewSkillWithoutLevel(addWithoutSkill);
                GlobalHelpers.LogTestSuccess("AddSkillWithoutLevel is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("AddSkillWithoutLevel is failed"+ex.Message);
            }
                 
        }
    }
}
