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
    public class EarnTargetSteps
    {
        AboutMeOverviewComponent aboutMeOverviewComponent;
        UpdateEarnTargetComponents updateEarnTargetComponents;
        public EarnTargetSteps()
        {
            aboutMeOverviewComponent = new AboutMeOverviewComponent();
            updateEarnTargetComponents = new UpdateEarnTargetComponents();
        }

        public void UpdateEarnTarget(EarnTargetModel target)
        {
            aboutMeOverviewComponent.ClickEarnTargetIcon();
            updateEarnTargetComponents.ClickEarnTarget(target);
            Thread.Sleep(3000);
            string msg = updateEarnTargetComponents.GetSuccessMessage();
            AboutMeAssertHelpers.AssertAboutMeSuccess(target.ExpectedMessage, msg);

        }

    }
}
