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
    public class AvailabillityTests:GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;
        AvailabillitySteps availabillity;

        public AvailabillityTests()
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
            availabillity = new AvailabillitySteps();
        }

        [SetUp]
        public void SetUp()
        {
            Initialise();
            var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");
            login.DoLogin(loginData);
            homePage.ValidateLogin();
        }
        
        //Test to update Availabillity under About me
        [Test, Order(1)]
        public void UpdateAvailiabillity()
        {
            try
            {
                GlobalHelpers.StartTest("UpdateAvailiabillity");
                GlobalHelpers.LogTestInfo("UpdateAvailiabillity started.");
                var availabillityData = DeserializeJson<AvailabillityModel>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\availabillityDatajson.json");
                availabillity.UpdateAvaillabillty(availabillityData);
                GlobalHelpers.LogTestSuccess("UpdateAvailiabillity passed.");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("UpdateAvailiabillity is failed. " + ex.Message);
            }
        }
    }
}
