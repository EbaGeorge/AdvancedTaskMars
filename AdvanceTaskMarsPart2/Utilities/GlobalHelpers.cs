using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceTaskMarsPart2.Model;
using Newtonsoft.Json;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Support.UI;

namespace AdvanceTaskMarsPart2.Utilities
{
    public class GlobalHelpers
    {
        
        public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentTest test;

        //File path where report is generated
        private static string reportPath = "extentReports.html";
        public void Initialise()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
        }
        // Set up ExtentReports once for the entire suite
        [OneTimeSetUp]
        public static void SetupExtentReport()
        {
            // Initialize the ExtentReports only once(if we want to get testcase report for both education and certification.)
            if (extent == null)
            {
                var htmlReporter = new ExtentSparkReporter(reportPath);
                extent = new ExtentReports();
                // Attach reporter to extent
                extent.AttachReporter(htmlReporter);
            }
        }

        // Finalize the report after all tests
        [OneTimeTearDown]
        public static void TearDownExtentReport()
        {
            extent.Flush();
        }

        

        //Method to deserialize json to C# object
        public static T DeserializeJson<T>(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Could not find JSON file at path: {filePath}");

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void DataCleanup()
        {
            {
                try
                {
                    while (true)
                    {
                        IWebElement deleteButton;
                        try
                        {
                            Thread.Sleep(4000);
                            deleteButton = driver.FindElement(By.XPath("(//td[@class='right aligned']//i[@class='remove icon'])[1]"));
                            deleteButton.Click();
                        }
                        catch (NoSuchElementException e)
                        {
                            Console.WriteLine("All records deleted");
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Delete button is not interactable");
                }

            }
        }
        // Start a test and log details
        public static void StartTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        // Log test success
        public static void LogTestSuccess(string message)
        {
            if (test != null) test.Pass(message);
        }

        // Log test failure
        public static void LogTestFailure(string message)
        {
            if (test != null) test.Fail(message);
        }

        // Log information during the test execution
        public static void LogTestInfo(string message)
        {
            if (test != null) test.Info(message);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}

