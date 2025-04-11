using AdvanceTaskMarsPart2.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Pages.SplashPage.Components
{
    public class NavigationComponent:GlobalHelpers
    {
        private IWebElement signInButton;
        public void renderComponents()
        {
            try
            {
                
                signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void clickSignInButton()
        {
            renderComponents();
            signInButton.Click();
        }
    }
}
