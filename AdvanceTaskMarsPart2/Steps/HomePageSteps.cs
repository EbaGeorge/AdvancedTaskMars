using AdvanceTaskMarsPart2.AssertHelpers;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.HeaderTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Steps
{
    public class HomePageSteps
    {
        HeaderTabComponents header;
        public HomePageSteps()
        {
            header = new HeaderTabComponents();
        }
        public void ValidateLogin() 
        {
            String firstname=header.getFirstName();
            LoginAssertHelpers.AssertValidateLoginSuccessMessage("Hi Eba", firstname);
        }
    }
}
