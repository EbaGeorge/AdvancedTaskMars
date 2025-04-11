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
    public class HoursTests : GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;
        HoursStep hours;

        public HoursTests()
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
            hours = new HoursStep();
        }
        [SetUp]
        public void SetUp()
        {
            Initialise();
            var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");
            login.DoLogin(loginData);
            homePage.ValidateLogin();
        }

        //Tests to update Hours under About me
        [Test, Order(1)]
        public void UpdateHours()
        {
            try
            {
                GlobalHelpers.StartTest("UpdateHours");
                GlobalHelpers.LogTestInfo("UpdateHours started");
                var hoursData = DeserializeJson<HoursModel>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\hoursData.json");
                hours.UpdateHours(hoursData);
                GlobalHelpers.LogTestSuccess("UpdateHours is passed");

            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("UpdateHours is failed" + ex.Message);
            }
           
        }
    }
}
