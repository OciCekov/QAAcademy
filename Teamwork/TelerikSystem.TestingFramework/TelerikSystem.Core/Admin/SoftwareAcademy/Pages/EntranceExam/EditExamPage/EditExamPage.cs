namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.EditExamPage
{
    using System;
    using TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage;
    using TestingFramework.Core.Base;

    public class EditExamPage : BasePage<EditExamPageMap, EditExamPageValidator>
    {
        public override string Url
        {
            get { return @"http://test.telerikacademy.com/Administration_SoftwareAcademy/CandidateExams"; }
        }

        public override void Navigate()
        {
            base.Navigate();
            Pages<EntranceExamPage>.Instance.Map.EditExam.Click();
        }

        public string GetIqConfiguration()
        {
            return this.Map.IqConfigurationId.InnerText;
        }

        public string GetItConfiguration()
        {
            return this.Map.ItConfigurationId.InnerText;
        }

        public string GetEnglishConfiguration()
        {
            return this.Map.EnglishTestConfigurationId.InnerText;
        }

        public string GetSelectedHallOption()
        {
            return this.Map.TrainingRoomOption.InnerText;
        }

        public string GetSelectedStudentsLimit()
        {
            return this.Map.StudentsLimit.Value;
        }
    }
}