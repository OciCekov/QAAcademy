using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.EditExamPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.CreateNewExamPage;
    using TestingFramework.Core.Base;

    public class EditExamPageValidator
    {
        public void AssertTitleIsVisible()
        {
            var editPage = Pages<NewExamPage>.Instance;
            Assert.IsTrue(editPage.Map.WindowTitle.IsVisible());
        }

        public void AssertIqConfiguration(string iqConfiguration)
        {
            string setValue = Pages<EditExamPage>.Instance.GetIqConfiguration();
            Assert.AreEqual(iqConfiguration, setValue);
        }

        public void AssertItConfiguration(string itConfiguration)
        {
            string currentValue = Pages<EditExamPage>.Instance.GetItConfiguration();
            Assert.AreEqual(itConfiguration, currentValue);
        }

        public void AssertEnglishConfiguration(string englishConfiguration)
        {
            string currentValue = Pages<EditExamPage>.Instance.GetEnglishConfiguration();
            Assert.AreEqual(englishConfiguration, currentValue);
        }

        public void AssertStudentsCount(string studentsCount)
        {
            string currentValue = Pages<EditExamPage>.Instance.GetSelectedStudentsLimit();
            Assert.AreEqual(studentsCount, currentValue);
        }

        public void AssertHallOption(string hallOption)
        {
            string currentValue = Pages<EditExamPage>.Instance.GetSelectedHallOption();
            Assert.AreEqual(hallOption, currentValue);
        }
    }
}
