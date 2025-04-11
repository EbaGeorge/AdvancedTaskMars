using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.LoginPage.Components;
using AdvanceTaskMarsPart2.Pages.SplashPage.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AdvanceTaskMarsPart2.Steps
{
    public class LoginSteps
    {
        NavigationComponent signIn;
        LoginComponent loginComponent;

        public LoginSteps()
        {
            signIn = new NavigationComponent();
            loginComponent = new LoginComponent();
        }

        public void DoLogin(Login login)
        {
            
            signIn.clickSignInButton();
            loginComponent.ClickLogin(login);

        }

        
    }
}
