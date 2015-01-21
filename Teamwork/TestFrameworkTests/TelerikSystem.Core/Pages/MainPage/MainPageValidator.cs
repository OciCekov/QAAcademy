namespace TelerikSystem.Core.Pages.MainPage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;
    using TelerikSystem.Core.Pages.FacebookPage;
    using TelerikSystem.Core.Pages.ForumPage;

    public class MainPageValidator
    {
        public void AssertCourseButtonPresent(string courseName, int courseId)
        {
            BaseInstance<MainPage>.Instance.Navigate();
            Assert.IsTrue(BaseInstance<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));            
        }

        public void AssertCourseButtonNotPresent(string courseName, int courseId)
        {
            BaseInstance<MainPage>.Instance.Navigate();
            Assert.IsFalse(BaseInstance<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));
        }

        public void AssertAdminIsVisible()
        {
            BaseInstance<MainPage>.Instance.Navigate();
            Assert.IsTrue(BaseInstance<MainPage>.Instance.Map.Admin.IsVisible());
        }

        public void AssertFirstForumPost()
        {
            BaseInstance<MainPage>.Instance.Navigate();
            var firstPostAcademyPage = BaseInstance<MainPage>.Instance.Map.FirstForumPost.InnerText;

            BaseInstance<ForumPage>.Instance.Navigate();
            var firstPostForumPage = BaseInstance<ForumPage>.Instance.Map.FirstForumPost.InnerText;

            Assert.AreEqual<string>(firstPostForumPage, firstPostAcademyPage);
        }

        public void AssertSecondForumPost()
        {
            BaseInstance<MainPage>.Instance.Navigate();
            var secondPostAcademyPage = BaseInstance<MainPage>.Instance.Map.SecondForumPost.InnerText;

            BaseInstance<ForumPage>.Instance.Navigate();
            var secondPostForumPage = BaseInstance<ForumPage>.Instance.Map.SecondForumPost.InnerText;

            Assert.AreEqual<string>(secondPostForumPage, secondPostAcademyPage);
        }

        public void AssertThirdForumPost()
        {
            BaseInstance<MainPage>.Instance.Navigate();
            var thirdPostAcademyPage = BaseInstance<MainPage>.Instance.Map.ThirdForumPost.InnerText;

            BaseInstance<ForumPage>.Instance.Navigate();
            var thirdPostForumPage = BaseInstance<ForumPage>.Instance.Map.ThirdForumPost.InnerText;

            Assert.AreEqual<string>(thirdPostForumPage, thirdPostAcademyPage);
        }

        public void AssertFirstFacebookPost()
        {
            BaseInstance<MainPage>.Instance.Navigate();
            var firstPostAcademyPage = BaseInstance<MainPage>.Instance.Map.FirstFacebookPost;
            BaseInstance<FacebookPage>.Instance.Navigate();
            var firstPostFacebookPage = BaseInstance<FacebookPage>.Instance.Map.FirstFacebookPost.InnerText;
           // Assert.AreEqual<string>(firstPostFacebookPage, firstPostAcademyPage);
        }
    }
}