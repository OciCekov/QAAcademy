namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.Seasons.CreateNewSeason
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using System.Threading;
    using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages;
    using TestingFramework.Core.Base;

    public class CreateNewSeasonPage : BasePage<CreateNewSeasonPageMap, CreateNewSeasonPageValidator>
    {
        public override string Url
        {
            get
            {
                return null;
            }
        }

        public void CreateNewSeason(string title)
        {
            this.Map.Title.Text = title;
            this.Map.UpdateButton.Click();
            this.Browser.WaitUntilReady();
        }
    }
}