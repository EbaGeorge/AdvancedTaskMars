using AdvanceTaskMarsPart2.AssertHelpers;
using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.AboutMe;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Language;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.MenuTabs;
using AdvanceTaskMarsPart2.Pages.LoginPage.Components;
using AdvanceTaskMarsPart2.Pages.SplashPage.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Steps
{
    public class AvailabillitySteps
    {
        AboutMeOverviewComponent aboutMeOverviewComponent;
        UpdateAvailabilityComponent updateAvailabilityComponent;

        public AvailabillitySteps()
        {
            aboutMeOverviewComponent = new AboutMeOverviewComponent();
            updateAvailabilityComponent = new UpdateAvailabilityComponent();
        }

        public void UpdateAvaillabillty(AvailabillityModel availabillityData)
        {
            aboutMeOverviewComponent.ClickAvailabilltyIcon();
            updateAvailabilityComponent.ClickAvailabilityDropdown(availabillityData);
            Thread.Sleep(3000);
            string msg=updateAvailabilityComponent.GetSuccessMessage();
            AboutMeAssertHelpers.AssertAboutMeSuccess(availabillityData.ExpectedMessage, msg);

        }

    }

    }

