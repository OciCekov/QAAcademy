namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage
{
    using System;
    using System.Globalization;
    using System.Linq;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using TestingFramework.Core.Base;

    public class EntranceExamPage : BasePage<EntranceExamPageMap, EntranceExamPageValidator>
    {
        public override string Url
        {
            get { return @"http://test.telerikacademy.com/Administration_SoftwareAcademy/CandidateExams"; }
        }

        public int GetExamCount()
        {
            return this.Map.TableRows.Count();
        }

        public string GetsLastExamStartTime(string formatString)
        {
            string dateFromCell = this.Map.StartTimeCell.InnerText;
            var actualDate = DateTime.Parse(dateFromCell, CultureInfo.InvariantCulture);
            return actualDate.ToString(formatString, CultureInfo.InvariantCulture);
        }

        public void RemoveLatestExam()
        {
            AlertDialog confirmDeletionDialog = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser,
                DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(confirmDeletionDialog);
            Manager.Current.DialogMonitor.Start();
            this.Map.DeleteTopExam.Click();
            confirmDeletionDialog.WaitUntilHandled();
            Manager.Current.DialogMonitor.Stop();
        }
    }
}