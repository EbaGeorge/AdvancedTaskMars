using AdvanceTaskMarsPart2.AssertHelpers;
using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.AboutMe;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.SearchSkills;
using AdvanceTaskMarsPart2.Pages.LoginPage.Components;
using AdvanceTaskMarsPart2.Pages.SplashPage.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Steps
{
    public class SkillFilterSteps
    {
        SearchSkillOverviewComponents searchSkillOverviewComponents;
        SearchSkillFilterComponent searchSkillFilterComponent;

        public SkillFilterSteps()
        {
            searchSkillOverviewComponents = new SearchSkillOverviewComponents();
            searchSkillFilterComponent = new SearchSkillFilterComponent();
        }

        public void SkillFilter(SearchSkillModel skillfilter)
        {
            searchSkillOverviewComponents.ClickSearchLogo();
            searchSkillFilterComponent.ClickOnsite();
            Thread.Sleep(3000);
            string skill = searchSkillFilterComponent.SuccessSkillFilter();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skillfilter.ExpectedMessage, skill);

        }
    }
}
