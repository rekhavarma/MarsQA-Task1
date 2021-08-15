using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LanguagesSteps
    {
        [Given(@"Seller has clicked on  languges tab")]
        public void GivenSellerHasClickedOnLangugesTab()
        {
            ExcelLibHelper.PopulateInCollection(@"F:\MarsTask\Mars_QA-main\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");


        }

        [When(@"seller clicks on Add button")]
        public void WhenSellerClicksOnAddButton()
        {
            Languages.AddLanguges();
            
        }

        [Given(@"Seller has clicked on Edit button")]
        public void GivenSellerHasClickedOnEditButton()
        {
            Languages.EditLanguges();
        }
        [When(@"seller clicks on Update button")]
        public void WhenSellerClicksOnUpdateButton()
        {
            
        }
        
        [When(@"seller clicks on Delete button")]
        public void WhenSellerClicksOnDeleteButton()
        {
            Languages.Deletelanguges();
        }
        
        [Then(@"Seller's languages must be saved and visible")]
        public void ThenSellerSLanguagesMustBeSavedAndVisible()
        {
           
        }
        
        [Then(@"Seller's  Updated language must be saved and visible")]
        public void ThenSellerSUpdatedLanguageMustBeSavedAndVisible()
        {
            Languages.Validateeditlanguage();
        }
        
        [Then(@"Seller's languages must be Deleted")]
        public void ThenSellerSLanguagesMustBeDeleted()
        {
            Languages.ValidateDelete();
        }
    }
}
