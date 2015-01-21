namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.Seasons.SeasonsMainPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using System.Threading;
    using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages;
    using TestingFramework.Core.Base;

    public class MainPageSeasonPage : BasePage<MainPageSeasonPageMap, MainPageSeasonPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration_SoftwareAcademy/Seasons"; 
            }
        }

        
    }
}