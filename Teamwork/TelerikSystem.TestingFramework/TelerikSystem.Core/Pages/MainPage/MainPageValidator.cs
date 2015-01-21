namespace TelerikSystem.Core.Pages.MainPage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;
    using TelerikSystem.Core.Pages.FacebookPage;
    using TelerikSystem.Core.Pages.ForumPage;
    using ArtOfTest.WebAii.Core;

    public class MainPageValidator
    {
        public void AssertCourseButtonPresent(string courseName, int courseId)
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsTrue(Pages<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));
        }

        public void AssertCourseButtonNotPresent(string courseName, int courseId)
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsFalse(Pages<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));
        }

        public void AssertAdminIsVisible()
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsTrue(Pages<MainPage>.Instance.Map.Admin.IsVisible());
        }

        public void AssertFirstForumPost()
        {
            Pages<MainPage>.Instance.Navigate();
            var firstPostAcademyPageAll = Pages<MainPage>.Instance.Map.FirstForumPost.InnerText;
            string firstPostAcademyPage = firstPostAcademyPageAll.Substring(0, firstPostAcademyPageAll.Length - 3);

            Pages<ForumPage>.Instance.Navigate();
            var firstPostForumPage = Pages<ForumPage>.Instance.Map.FirstForumPost.InnerText;

            Assert.IsTrue(firstPostForumPage.Contains(firstPostAcademyPage));
        }

        public void AssertSecondForumPost()
        {
            Pages<MainPage>.Instance.Navigate();
            var secondPostAcademyPage = Pages<MainPage>.Instance.Map.SecondForumPost.InnerText;

            Pages<ForumPage>.Instance.Navigate();
            var secondPostForumPage = Pages<ForumPage>.Instance.Map.SecondForumPost.InnerText;

            Assert.AreEqual<string>(secondPostForumPage, secondPostAcademyPage);
        }

        public void AssertThirdForumPost()
        {
            Pages<MainPage>.Instance.Navigate();
            var thirdPostAcademyPage = Pages<MainPage>.Instance.Map.ThirdForumPost.InnerText;

            Pages<ForumPage>.Instance.Navigate();
            var thirdPostForumPage = Pages<ForumPage>.Instance.Map.ThirdForumPost.InnerText;

            Assert.AreEqual<string>(thirdPostForumPage, thirdPostAcademyPage);
        }

        public void AssertFirstFacebookPost()
        {
            Pages<MainPage>.Instance.Navigate();
            string firstPostAcademyPage = Pages<MainPage>.Instance.Map.FirstFacebookPost.InnerText;
            Pages<FacebookPage>.Instance.Navigate();
            Pages<FacebookPage>.Instance.Browser.WaitForAjax(1000);

            string firstPostFacebookPage = Pages<FacebookPage>.Instance.Map.FirstFacebookPost.InnerText;
            Assert.IsTrue(firstPostFacebookPage.Contains(firstPostAcademyPage));
        }

        public void AssertSecondFacebookPost()
        {
            Pages<MainPage>.Instance.Navigate();
            string secondPostAcademyPage = Pages<MainPage>.Instance.Map.SecondFacebookPost.InnerText;
            Pages<FacebookPage>.Instance.Navigate();
            Pages<FacebookPage>.Instance.Browser.WaitUntilReady();
            string secondPostFacebookPage = Pages<FacebookPage>.Instance.Map.SecondFacebookPost.InnerText;
            Assert.IsTrue(secondPostFacebookPage.Contains(secondPostAcademyPage));
        }

        public void AssertThirdFacebookPost()
        {
            Pages<MainPage>.Instance.Navigate();
            string thirdPostAcademyPage = Pages<MainPage>.Instance.Map.ThirdFacebookPost.InnerText;
            Pages<FacebookPage>.Instance.Navigate();
            Pages<FacebookPage>.Instance.Browser.WaitForAjax(1000);

            string thirdPostFacebookPage = Pages<FacebookPage>.Instance.Map.ThirdFacebookPost.InnerText;
            Assert.IsTrue(thirdPostFacebookPage.Contains(thirdPostAcademyPage));
        }
    }
}