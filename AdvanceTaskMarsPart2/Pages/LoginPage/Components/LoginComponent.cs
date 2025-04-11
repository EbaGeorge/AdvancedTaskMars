using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.LoginPage.Components
{
    public class LoginComponent : GlobalHelpers
    {
        private IWebElement emailTextbox;
        private IWebElement passwordTextbox;
        private IWebElement loginButton;



        public void renderComponents()
        {
            try
            {
                emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ClickLogin(Login login)
        {
            renderComponents();            
            driver.Manage().Window.Maximize();
            emailTextbox.SendKeys(login.Email);
            passwordTextbox.SendKeys(login.Password);
            loginButton.Click();
        }
    }
}



