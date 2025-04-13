using AdvanceTaskMarsPart2.AssertHelpers;
using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.AboutMe;
using AdvanceTaskMarsPart2.Pages.LoginPage.Components;
using AdvanceTaskMarsPart2.Pages.SplashPage.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Steps
{
    public class HoursStep
    {
        AboutMeOverviewComponent aboutMeOverviewComponent;
        UpdateHoursComponent updateHoursComponent;

        public HoursStep()
        {
            aboutMeOverviewComponent = new AboutMeOverviewComponent();
            updateHoursComponent = new UpdateHoursComponent();
        }

        public void UpdateHours(HoursModel hours)
        {
            aboutMeOverviewComponent.ClickHoursIcon();
            updateHoursComponent.ClickHoursDropdown(hours);
            Thread.Sleep(3000);
            string msg = updateHoursComponent.GetSuccessMessage();
            AboutMeAssertHelpers.AssertAboutMeSuccess(hours.ExpectedMessage, msg);

        }
    }
}
