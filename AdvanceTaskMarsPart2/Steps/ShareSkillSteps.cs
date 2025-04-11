using AdvanceTaskMarsPart2.AssertHelpers;
using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.AboutMe;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ShareSkill;
using AdvanceTaskMarsPart2.Pages.LoginPage.Components;
using AdvanceTaskMarsPart2.Pages.SplashPage.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Steps
{
    public class ShareSkillSteps
    {
        ShareSkillComponents shareSkillComponents;
        AddNewSkillShareComponents addNewSkillComponents;

        public ShareSkillSteps()
        {
            shareSkillComponents = new ShareSkillComponents();
            addNewSkillComponents = new AddNewSkillShareComponents();
        }

        public void AddNewShareSkill(ShareSkillModel skill)
        {
            shareSkillComponents.ClickShareSkillButton();
            addNewSkillComponents.AddNewShareSkill(skill);
            Thread.Sleep(3000);
            string msg = addNewSkillComponents.VerifySuccess();
            SkillAssertHelpers.AssertValidateSkillSuccessMessage(skill.ExpectedMessage, msg);

        }

    }
}
