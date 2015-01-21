namespace TelerikSystem.Core.Admin.BasicModules.Pages.SurveysPage
{
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Telerik.TestingFramework.Controls.KendoUI;
    using TestingFramework.Core.Base;

    public class SurveysPageMap : BaseElementMap
    {
        public KendoGrid SurveysGrid
        {
            get
            {
                return this.Find.ById<KendoGrid>("DataGrid");
            }
        }

        public HtmlAnchor AddSurvey 
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Contains("Добавяне на нова анкета"))
                    .FirstOrDefault();
            }
        }

        public HtmlInputText NameInput
        { 
            get
            {
                return this.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlInputText StartDate
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ActiveFrom");
            }
        }

        public HtmlInputText EndDate 
        { 
            get
            {
                return this.Find.ById<HtmlInputText>("ActiveTo");
            }
        }

        public HtmlAnchor Update 
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                    .Where(a => a.InnerText.Contains("Update"))
                    .FirstOrDefault();
            }
        }

        public HtmlTable SurveysTable
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=treegrid");
            }
        }
    }
}
