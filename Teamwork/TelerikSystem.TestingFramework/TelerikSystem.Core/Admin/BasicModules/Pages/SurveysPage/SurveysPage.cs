namespace TelerikSystem.Core.Admin.BasicModules.Pages.SurveysPage
{
    using System.Windows.Forms;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class SurveysPage : BasePage<SurveysPageMap, SurveysPageValidator>
    {
        public override string Url
        {
            get 
            { 
                return @"http://test.telerikacademy.com/Administration_Surveys/Surveys/Index";
            }
        }

        public void AddNewSurvey(string name, string startDate, string endDate)
        {
            this.Navigate();
            this.Map.AddSurvey.Click();
            this.Map.NameInput.Text = name;
            this.Map.NameInput.FireChange();

            this.Map.StartDate.MouseClick();
            this.Map.StartDate.Value = "";
            this.Map.StartDate.OwnerBrowser.Desktop.KeyBoard.TypeText(startDate, 1);

            this.Map.StartDate.OwnerBrowser.Desktop.KeyBoard.KeyPress(Keys.Tab);
            this.Map.EndDate.Value = "";
            this.Map.EndDate.OwnerBrowser.Desktop.KeyBoard.TypeText(endDate, 1);
            this.Map.EndDate.OwnerBrowser.Desktop.KeyBoard.KeyPress(Keys.Tab);

            this.Map.Update.FireClick();
        }
    }
}
