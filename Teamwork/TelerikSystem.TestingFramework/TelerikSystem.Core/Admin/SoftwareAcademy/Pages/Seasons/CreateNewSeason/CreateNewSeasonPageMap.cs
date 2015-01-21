namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.Seasons.CreateNewSeason
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using ArtOfTest.WebAii.Core;

    public class CreateNewSeasonPageMap : BaseElementMap
    {
        public HtmlInputText Title
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {                                                    
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor CancelButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }

       public HtmlDiv ValidationMessageTitle
        {
            get
            {
                return this.Find.ById<HtmlDiv>("Name_validationMessage"); 
            }
        }
    }
}

