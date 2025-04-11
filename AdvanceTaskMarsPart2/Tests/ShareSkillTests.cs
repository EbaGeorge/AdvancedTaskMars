using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Steps;
using AdvanceTaskMarsPart2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Tests
{
    public class ShareSkillTests:GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;
        ShareSkillSteps shareSkill;
        public ShareSkillTests()
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
            shareSkill = new ShareSkillSteps();
        }

        [SetUp]
        public void SetUp()
        {
            Initialise();
            var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");
            login.DoLogin(loginData);
            homePage.ValidateLogin();
        }

        //Test to add new share skill
        [Test, Order(1)]
        public void AddNewShareSkill()
        {
            try
            {
                GlobalHelpers.StartTest("AddNewShareSkill");
                GlobalHelpers.LogTestInfo("AddNewShareSkill is started");
                var shareSkillData = DeserializeJson<ShareSkillModel>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\shareSkillData.json");
                shareSkill.AddNewShareSkill(shareSkillData);
                GlobalHelpers.LogTestSuccess("AddNewShareSkill is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("AddNewShareSkill is failed");
            }
            
        }
    }
}
