namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage
{
    using System.Linq;
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class EntranceExamPageValidator
    {
        public void AssertExamIsAdded(int examsCount)
        {
            int actual = Pages<EntranceExamPage>.Instance.Map.TableRows.Count();
            Assert.AreEqual(examsCount + 1, actual);
        }

        public void AssertStartDatesMatch(string currentlyCreated, string actual)
        {
            Assert.AreEqual(currentlyCreated, actual);
        }

        public void AssetExamIsRemoved(int examsCountAfterDelete)
        {
            int actual = Pages<EntranceExamPage>.Instance.Map.TableRows.Count();
            Assert.AreEqual(examsCountAfterDelete - 1, actual);
        }
    }
}