namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.Seasons.CreateNewSeason
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class CreateNewSeasonPageValidator
    {
        public void VerifyErrorMessageTitleIsVisible_NullTitle()
        {
            Pages<CreateNewSeasonPage>.Instance.CreateNewSeason(null);
           Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
           Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        }

        public void VerifyErrorMessageTitleIsVisible_EmptyTitle()
        {
            Pages<CreateNewSeasonPage>.Instance.CreateNewSeason(string.Empty);
            Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
            Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        }

        public void VerifyErrorMessageTitleIsVisible_WhiteSpaceTitle()
        {
            Pages<CreateNewSeasonPage>.Instance.CreateNewSeason("       ");
            Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
            Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        }
        
        public void VerifyErrorMessageTitleIsVisible_TitleLength2symbols()
        {
            Pages<CreateNewSeasonPage>.Instance.CreateNewSeason("aa");
            Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
            Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        }
        
        //public void VerifyErrorMessageTitleIsNotVisible_TitleLength4symbols()
        //{
        //    Pages<CreateNewSeasonPage>.Instance.CreateNewSeason("есен");
        //    Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
        //    Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        //}
        
        //public void VerifyErrorMessageTitleIsNotVisible_TitleLength199symbols()
        //{
        //    Pages<CreateNewSeasonPage>.Instance.CreateNewSeason("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
        //    Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
        //    Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        //}

        
        //public void VerifyErrorMessageTitleIsNotVisible_TitleLength200symbols()
        //{
        //    Pages<CreateNewSeasonPage>.Instance.CreateNewSeason("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
        //    Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
        //    Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        //}
        
        public void VerifyErrorMessageTitleIsVisible_TitleLength201symbols()
        {
            Pages<CreateNewSeasonPage>.Instance.CreateNewSeason("101234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Assert.IsTrue(Pages<CreateNewSeasonPage>.Instance.Map.ValidationMessageTitle.IsVisible());
            Pages<CreateNewSeasonPage>.Instance.Map.CancelButton.Click();
        }
    }
}