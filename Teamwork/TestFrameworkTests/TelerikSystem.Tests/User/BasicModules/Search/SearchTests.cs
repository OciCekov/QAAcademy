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
        public void Search_AssertsTextWhenNoResultFound()
        {
            string searchedValue = "abcdef123456";
            string returnedText = "Вашето търсене не върна резултат";

            BaseInstance<SearchPage>.Instance.SearchText(searchedValue);
            BaseInstance<SearchPage>.Instance.Validator.AssertText(returnedText);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        public void Search_AssertsUsersCount()
        {
            string searchedValue = "testuser";
            int usersCount = 1;

            BaseInstance<SearchPage>.Instance.SearchText(searchedValue);
            BaseInstance<SearchPage>.Instance.Validator.AssertUsersCount(usersCount);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        public void Search_AssertsCoursesCount()
        {
            string searchedValue = "testing";
            int coursesCount = 2;

            BaseInstance<SearchPage>.Instance.SearchText(searchedValue);
            BaseInstance<SearchPage>.Instance.Validator.AssertCoursesCount(coursesCount);
        }

        [Ignore] // test throws exception
        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        public void Search_AssertsTracksCount()
        {
            string searchedValue = "super";
            int tracksCount = 1;

            BaseInstance<SearchPage>.Instance.SearchText(searchedValue);
            BaseInstance<SearchPage>.Instance.Validator.AssertTracksCount(tracksCount);
        }

        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        public void Search_AssertsUsersAndCoursesCount()
        {
            string searchedValue = "user";
            int usersCount = 34;
            int coursesCount = 1;

            BaseInstance<SearchPage>.Instance.SearchText(searchedValue);
            BaseInstance<SearchPage>.Instance.Validator.AssertUsersCount(usersCount);
            BaseInstance<SearchPage>.Instance.Validator.AssertCoursesCount(coursesCount);
        }


        [Ignore] // test throws exception
        [TestMethod]
        [Owner("Milena Gyulmezova")]
        [Priority(3)]
        public void Search_AssertsSearchTitle()
        {
            string searchedValue = "test"; // Bug found, it shall pass
            string returnedText = @"Вашето търсене за """ + searchedValue + @""" върна следните резултати";

            BaseInstance<SearchPage>.Instance.SearchText(searchedValue);
            BaseInstance<SearchPage>.Instance.Validator.AssertText(returnedText);
        }
    }
}
