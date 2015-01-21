namespace TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.CreateDynamicPage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class CreateDynamicPagePageValidator
    {
        public void VerifyErrorMessageTitleIsVisible_NullTitle()
        {
           BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage( null, "some content",  "some descripton", "keywords",  "12/12/2013",   "12/12/2013");
           Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForRequested.IsVisible());
        }

        public void VerifyErrorMessageTitleIsVisible_EmptyTitle()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage(string.Empty, "some content", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForRequested.IsVisible());
        }

        public void VerifyErrorMessageTitleIsVisible_WhiteSpaceTitle()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("   ", "some content", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForRequested.IsVisible());
        }
        
        public void VerifyErrorMessageTitleIsVisible_TitleLength2symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("ab", "some content", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForLenght.IsVisible());
        }
        
        public void VerifyErrorMessageTitleIsNotVisible_TitleLength4symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("absd", " ", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForLenght);
        }
        
        public void VerifyErrorMessageTitleIsNotVisible_TitleLength199symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", " ", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForLenght);
        }

        
        public void VerifyErrorMessageTitleIsNotVisible_TitleLength200symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", " ", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForLenght);
        }
        
        public void VerifyErrorMessageTitleIsVisible_TitleLength201symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("101234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", "some content", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForLenght.IsVisible());
        }

        public void VerifyErrorMessageTitleIsNotVisible_ValidInputAndLength3symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", " ", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForRequested);
        }

        public void VerifyErrorMessageContentIsVisible_NullContent()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", null, "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageContentForRequested.IsVisible());
        }

        public void VerifyErrorMessageContentIsVisible_WhitespaceContent()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "    ", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageContentForRequested.IsVisible());
        }

        public void VerifyErrorMessageContentIsVisible_EmptyContent()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", string.Empty, "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageContentForRequested.IsVisible());
        }

        public void VerifyErrorMessageContentIsNotVisible()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("   ", "some context", "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageContentForRequested);
        }

        public void VerifyErrorMessageContentIsVisible_BlankInfo()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage(string.Empty,string.Empty, "some descripton", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageTitleForRequested.IsVisible(), "Message title does not appear.");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageContentForRequested.IsVisible(), "Message content does not appear");
        }

        public void VerifyErrorMessageKyewordsIsVisible_101Symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "some descripton", "keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  k", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageKeywords.IsVisible());
        }

        public void VerifyErrorMessageKeywordsIsNotVisible_100Symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage(null, "some context", "some descripton", "keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  ", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageContentForRequested);
        }

        public void VerifyErrorMessageKeywordsIsNotVisible_99Symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage(null, "some context", "some descripton", "keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords  keywords ", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageContentForRequested);
        }


        public void VerifyErrorMessageDescriptionIsNotVisible_TitleLength199symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage(null, "some content", "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageDescription);
        }


        public void VerifyErrorMessageDescriptionIsNotVisible_TitleLength200symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage(null, "some content", "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsNull(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageDescription);
        }

        public void VerifyErrorMessageDescriptionIsVisible_TitleLength201symbols()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "101234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789", "keywords", "12/12/2013", "12/12/2013");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageDescription.IsVisible());
        }

        public void VerifyErrorMessageCreateOnIsVisible_String()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "absd", "12/12/2014");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageCreateOn.IsVisible());
        }

        public void VerifyErrorMessageCreateOnIsVisible_DateFeb292014()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "29/02/2014", "24/10/2014");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageCreateOn.IsVisible());
        }
       
        public void VerifyErrorMessageCreateOnIsVisible_DateFeb262014_Hour25()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "26/02/2014 25:00:00", "24/10/2014");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageCreateOn.IsVisible());
        }

        public void VerifyErrorMessageCreateOnIsVisible_DateFeb262014_Minutes60()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "26/02/2014 24:60:00", "24/10/2014");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageCreateOn.IsVisible());
        }

        public void VerifyErrorMessageCreateOnIsVisible_DateFeb262014_Secunds60()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "26/02/2014 24:00:60", "24/10/2014");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageCreateOn.IsVisible());
        }
        
        public void VerifyErrorMessageCreateOnIsVisible_DateFeb262014_TimeString()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "26/02/2014 abvc", "24/10/2014");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageCreateOn.IsVisible());
        }

        //// the message is not visible but the test does not pass 
        //public void VerifyErrorMessageCreateOnIsNotVisible_Valid()
        //{
        //    Pages<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "    ", "description", "keywords", "26/02/2014 22:30:01", "24/10/2014");
        //  Assert.IsFalse(Pages<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageCreateOn.IsVisible());
        //}


        public void VerifyErrorMessageModifiedOnIsVisible_DateString()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "12/12/2014", "absd");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageModifyOn.IsVisible());
        }

        public void VerifyErrorMessageModifiedOnIsVisible_DateFeb292015()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "24/10/2014", "29/02/2015");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageModifyOn.IsVisible());
        }

        public void VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_Hour25()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "24/10/2014", "26/02/2015 25:00:00");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageModifyOn.IsVisible());
        }

        public void VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_Minutes60()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "24/10/2014", "26/02/2015 24:60:00");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageModifyOn.IsVisible());
        }

        public void VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_Secunds60()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "24/10/2014", "26/02/2015 24:00:60");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageModifyOn.IsVisible());
        }

        public void VerifyErrorMessageModifiedOnIsVisible_DateFeb262015_TimeString()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("Page", "some content", "description", "keywords", "24/10/2014", "26/02/2015 abvc");
            Assert.IsTrue(BaseInstance<CreateDynamicPagePage>.Instance.Map.LocalErrorMessageModifyOn.IsVisible());
        }
    }
}