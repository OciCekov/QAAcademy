namespace TelerikSystem.Tests.User.BasicModules.Search
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.User.BasicModules.Pages.SearchPage;
    using TestingFramework.Core.Base;

    [TestClass]
    public class SearchTests : BaseTest
    {
        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        //[TestCase(290)]
        public void Search_AssertsTitleWhenNoResultFound()
        {
            string searchedValue = "abcdef123456";
            string returnedText = "Вашето търсене не върна резултат";

            Pages<SearchPage>.Instance.SearchText(searchedValue);
            Pages<SearchPage>.Instance.Validator.AssertText(returnedText);
        }

        [Microsoft.VisualStudio.TestTools.UnitTesting.Ignore] // Bug found, it shall pass
        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        //[TestCase(291)]
        //[Bug(2288)]
        public void Search_AssertsTitleWhenResultFound()
        {
            string searchedValue = "test";
            string returnedText = @"Вашето търсене за """ + searchedValue + @""" върна следните резултати";

            Pages<SearchPage>.Instance.SearchText(searchedValue);
            Pages<SearchPage>.Instance.Validator.AssertText(returnedText);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        //[TestCase(292)]
        public void Search_AssertsCoursesCount()
        {
            string searchedValue = "testing";
            int coursesCount = 2;

            Pages<SearchPage>.Instance.SearchText(searchedValue);
            Pages<SearchPage>.Instance.Validator.AssertCoursesCount(coursesCount);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        //[TestCase(410)]
        public void Search_AssertsTracksCount()
        {
            string searchedValue = "super";
            int tracksCount = 1;

            Pages<SearchPage>.Instance.SearchText(searchedValue);
            Pages<SearchPage>.Instance.Validator.AssertTracksCount(tracksCount);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        //[TestCase(411)]
        public void Search_AssertsUsersCount()
        {
            string searchedValue = "testuser";
            int usersCount = 2;

            Pages<SearchPage>.Instance.SearchText(searchedValue);
            Pages<SearchPage>.Instance.Validator.AssertUsersCount(usersCount);
        }
               
        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        //[TestCase(412)]
        public void Search_AssertsUsersAndCoursesCount()
        {
            string searchedValue = "user";
            int usersCount = 35;
            int coursesCount = 1;

            Pages<SearchPage>.Instance.SearchText(searchedValue);
            Pages<SearchPage>.Instance.Validator.AssertUsersCount(usersCount);
            Pages<SearchPage>.Instance.Validator.AssertCoursesCount(coursesCount);
        }
    }
}
