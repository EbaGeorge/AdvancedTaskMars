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
    public class SkillCategorySteps
    {       
        SearchSkillOverviewComponents searchSkillOverviewComponents;
        SearchCategoryComponents searchCategoryComponents;
        public SkillCategorySteps()
        {        
            searchSkillOverviewComponents = new SearchSkillOverviewComponents();
            searchCategoryComponents = new SearchCategoryComponents();
        }

        public void SearchSkillByCategory(SearchSkillModel skill)
        {
            searchSkillOverviewComponents.ClickSearchLogo();
            searchCategoryComponents.SearchCategories();
            Thread.Sleep(3000);
            string msg = searchCategoryComponents.SuccessSkill();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skill.ExpectedMessage, msg);

        }
        public void SearchSkillBySubCategory(SearchSkillModel skill)
        {
            searchSkillOverviewComponents.ClickSearchLogo();
            searchCategoryComponents.SearchSubCategory();
            Thread.Sleep(3000);
            string msg = searchCategoryComponents.SuccessSkillSubCategory();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skill.ExpectedMessage, msg);

        }
    }
}
