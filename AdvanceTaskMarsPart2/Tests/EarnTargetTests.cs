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
    public class EarnTargetTests:GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;
        EarnTargetSteps earntarget;

        public EarnTargetTests()
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
            earntarget = new EarnTargetSteps();
        }

        [SetUp]
        public void SetUp()
        {
            Initialise();
            var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");
            login.DoLogin(loginData);
            homePage.ValidateLogin();
        }

        //Tests to update Earn Target under About me
        [Test, Order(1)]
        public void UpdateEarnTarget()
        {
            try
            {
                GlobalHelpers.StartTest("UpdateEarnTarget");
                GlobalHelpers.LogTestInfo("UpdateEarnTarget started");
                var target = DeserializeJson<EarnTargetModel>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\earnTargetData.json");
                earntarget.UpdateEarnTarget(target);
                GlobalHelpers.LogTestSuccess("UpdateEarnTarget passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("UpdateEarnTarget is failed" + ex.Message);
            }
        }
    }
}
