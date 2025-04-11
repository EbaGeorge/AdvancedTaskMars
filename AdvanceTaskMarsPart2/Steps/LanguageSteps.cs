using AdvanceTaskMarsPart2.AssertHelpers;
using AdvanceTaskMarsPart2.Model;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.Language;
using AdvanceTaskMarsPart2.Pages.HomePage.Components.ProfileOverview.MenuTabs;
using AdvanceTaskMarsPart2.Pages.LoginPage.Components;
using AdvanceTaskMarsPart2.Pages.SplashPage.Components;
using OpenQA.Selenium.BiDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTaskMarsPart2.Steps
{
    public class LanguageSteps
    {
       
        ProfileMenuTabComponents profileMenuTabComponents;
        LanguageOverviewComponents languageOverviewComponents;
        AddUpdateDeleteLanguageComponents addUpdateDeleteLanguageComponents;
        

        public LanguageSteps()
        {
            profileMenuTabComponents= new ProfileMenuTabComponents();
            languageOverviewComponents = new LanguageOverviewComponents();
            addUpdateDeleteLanguageComponents = new AddUpdateDeleteLanguageComponents();
        }

        public void AddNewLanguage(AddLanguage language)
        {
            
            profileMenuTabComponents.ClickLanguageButton();
            languageOverviewComponents.ClickAddNewButton();
            addUpdateDeleteLanguageComponents.AddLanguage(language);       
            string actualMessage=addUpdateDeleteLanguageComponents.GetAddSuccessMessage();
            LanguageAssertHelpers.AssertValidateLanguageSuccessMessage(language.Language + language.ExpectedMessage, actualMessage);

        }

        public void UpdateLanguage(UpdateLanguage language)
        {

            languageOverviewComponents.ClickUpdateIcon();
            Thread.Sleep(3000);
            addUpdateDeleteLanguageComponents.UpdateLanguage(language);
            string actualMessage = addUpdateDeleteLanguageComponents.GetUpdateSuccessMessage();
            LanguageAssertHelpers.AssertValidateLanguageSuccessMessage(language.LanguageToBeUpdated + language.ExpectedMessage, actualMessage);

        }

        public void DeleteLanguage(AddLanguage language)
        {

            languageOverviewComponents.ClickDeleteIcon();
            Thread.Sleep(3000);
            addUpdateDeleteLanguageComponents.DeleteLanguage();
            string actualMessage = addUpdateDeleteLanguageComponents.GetDeleteSuccessMessage();
            LanguageAssertHelpers.AssertValidateLanguageSuccessMessage(language.Language + language.ExpectedDeleteMessage, actualMessage);

        }
        public void AddLanguageWithoutLevel(AddLanguage language)
        {
            languageOverviewComponents.ClickAddNewButton();
            addUpdateDeleteLanguageComponents.AddLanguageWithoutLevel(language);
            string actualMessage = addUpdateDeleteLanguageComponents.AddLanguageWithoutlevelSuccess();
            LanguageAssertHelpers.AssertValidateLanguageSuccessMessage(language.ExpectedMessage, actualMessage);
        }

    
    }
}
