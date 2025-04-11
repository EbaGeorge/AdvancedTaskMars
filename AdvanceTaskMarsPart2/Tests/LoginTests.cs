using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Steps;
using AdvanceTaskMarsPart2.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvanceTaskMarsPart2.Tests
{
    public class LoginTests:GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;

        public LoginTests() 
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
        }
        [SetUp]
        public void SetUp()
        {
            Initialise();
        }
       
        //Test to do login
        [Test]
        public void Login()
        {
            try
            {
                GlobalHelpers.StartTest("Login");
                GlobalHelpers.LogTestInfo("Login started.");
                var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");
                login.DoLogin(loginData);
                homePage.ValidateLogin();
                GlobalHelpers.LogTestSuccess("Login passed.");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("Login is failed. " + ex.Message);
            }
        }
    }
}
