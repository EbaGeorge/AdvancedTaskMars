using AdvanceTaskMarsPart2.Model;
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
    public class LanguageTests:GlobalHelpers
    {
        LoginSteps login;
        HomePageSteps homePage;
        LanguageSteps language;

        public LanguageTests()
        {
            login = new LoginSteps();
            homePage = new HomePageSteps();
            language = new LanguageSteps();
        }

        [SetUp]
        public void SetUp()
        {
            Initialise();
            var loginData = DeserializeJson<Login>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\loginData.json");    
            login.DoLogin(loginData);          
            homePage.ValidateLogin();
            DataCleanup();
        }

        //Test to add language
        [Test,Order(1)]
        public void AddLanguage()
        {
            try
            {
                GlobalHelpers.StartTest("AddLanguage");
                GlobalHelpers.LogTestInfo("AddLanguage is started");
                var languageData = DeserializeJson<AddLanguage>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\addLanguageData.json");
                language.AddNewLanguage(languageData);
                GlobalHelpers.LogTestSuccess("AddLanguage is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("AddLanguage is failed" + ex.Message);
            }
           
        }

        //Test to update language
        [Test, Order(2)]
        public void UpdateLanguage()
        {
            try
            {
                GlobalHelpers.StartTest("UpdateLanguage");
                GlobalHelpers.LogTestInfo("UpdateLanguage started");
                var updateLanguage = DeserializeJson<UpdateLanguage>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\updateLanguageData.json");
                AddLanguage();
                Thread.Sleep(3000);
                language.UpdateLanguage(updateLanguage);
                GlobalHelpers.LogTestSuccess("UpdateLanguage is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("UpdateLanguage is failed" +ex.Message);
            }
            
        }

        //Test to delete language
        [Test, Order(3)]
        public void DeleteLanguage()
        {
            try
            {
                GlobalHelpers.StartTest("DeleteLanguage");
                GlobalHelpers.LogTestInfo("DeleteLanguage is started");
                var deleteLanguage = DeserializeJson<AddLanguage>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\addLanguageData.json");
                AddLanguage();
                Thread.Sleep(3000);
                language.DeleteLanguage(deleteLanguage);
                GlobalHelpers.LogTestSuccess("DeleteLanguage is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("DeleteLanguage is failed" + ex.Message);
            }
        }

        //Test to add language without language
        [Test, Order(4)]
        public void AddLanguageWithoutLevel()
        {
            try
            {
                GlobalHelpers.StartTest("AddLanguageWithoutLevel");
                GlobalHelpers.LogTestInfo("AddLanguageWithoutLevel started");
                var addWithoutLanguage = DeserializeJson<AddLanguage>("D:\\Eba\\Industry Connect\\WorkSpace\\AdvancedTask\\AdvancedTaskMars\\AdvanceTaskMarsPart2\\TestData\\addLanguageWithoutLevelData.json");
                language.AddLanguageWithoutLevel(addWithoutLanguage);
                GlobalHelpers.LogTestSuccess("AddLanguageWithoutLevel is passed");
            }
            catch (Exception ex)
            {
                GlobalHelpers.LogTestFailure("AddLanguageWithoutLevel is failed" + ex.Message);
            }
        }     
    }
}

