using AdvanceTaskMarsPart2.AssertHelpers;
using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Language;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.MenuTabs;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Skill;
using AdvanceTaskMarsPart2.Pages.LoginPage.Components;
using AdvanceTaskMarsPart2.Pages.SplashPage.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Steps
{
    public class SkillSteps
    {
        ProfileMenuTabComponents profileMenuTabComponents;
        SkillOverviewComponents skillOverviewComponents;
        AddUpdateDeleteSkillComponent addUpdateDeleteSkillComponents;


        public SkillSteps()
        {
         
            profileMenuTabComponents = new ProfileMenuTabComponents();
            skillOverviewComponents = new SkillOverviewComponents();
            addUpdateDeleteSkillComponents = new AddUpdateDeleteSkillComponent();
        }

        public void AddNewSkill(AddSkill skill)
        {

            profileMenuTabComponents.ClickSkillButton();
            skillOverviewComponents.ClickAddNewButton();
            addUpdateDeleteSkillComponents.AddSkill(skill);
            string actualMessage = addUpdateDeleteSkillComponents.GetAddSuccessMessage();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skill.Skill + skill.ExpectedMessage, actualMessage);

        }
        public void UpdateSkill(UpdatedSkill skill)
        {

            skillOverviewComponents.ClickUpdateIcon();
            addUpdateDeleteSkillComponents.UpdateSkill(skill);
            string actualMessage = addUpdateDeleteSkillComponents.GetUpdateSuccessMessage();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skill.SkillToBeUpdated + skill.ExpectedMessage, actualMessage);

        }

        public void DeleteSkill(AddSkill skill)
        {

            skillOverviewComponents.ClickDeleteIcon();
            Thread.Sleep(3000);
            addUpdateDeleteSkillComponents.DeleteSkill();
            string actualMessage = addUpdateDeleteSkillComponents.GetDeleteSuccessMessage();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skill.Skill + skill.ExpectedDeleteMessage, actualMessage);

        }

        public void AddNewSkillWithoutLevel(AddSkill skill)
        {

            profileMenuTabComponents.ClickSkillButton();
            skillOverviewComponents.ClickAddNewButton();
            addUpdateDeleteSkillComponents.AddSkillWithoutSkillLevel(skill);
            string actualMessage = addUpdateDeleteSkillComponents.AddSkillWithoutSkillLevelSuccess();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skill.ExpectedMessage, actualMessage);

        }
    }
}
