namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.EditExamPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class EditExamPageMap : BaseElementMap
    {
        public HtmlSpan IqConfigurationId
        {                                           // /html/body/div[12]/div[2]/div/div[2]/span[1]/span/span[1]
            get { return this.Find.ByXPath<HtmlSpan>("/html/body/div[12]/div[2]/div/div[2]/span[1]/span/span[1]"); }
        }

        public HtmlSpan ItConfigurationId
        {
            get { return this.Find.ByXPath<HtmlSpan>("/html/body/div[12]/div[2]/div/div[4]/span[1]/span/span[1]"); }
        }

        public HtmlSpan EnglishTestConfigurationId
        {
            get { return this.Find.ByXPath<HtmlSpan>("/html/body/div[12]/div[2]/div/div[6]/span[1]/span/span[1]"); }
        }

        public HtmlSpan TrainingRoomOption
        {
            get { return this.Find.ByXPath<HtmlSpan>("/html/body/div[12]/div[2]/div/div[12]/span[1]/span/span[1]"); }
        }

        public HtmlInputText AllowedIps
        {
            get { return this.Find.ById<HtmlInputText>("AllowedIp"); }
        }

        public HtmlInputNumber StudentsLimit
        {
            get { return this.Find.ById<HtmlInputNumber>("CandidatesCountLimit"); }
        }

        public HtmlAnchor UpdateButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Update"); }
        }

        public HtmlAnchor CancelButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Cancel"); }
        }

        public HtmlAnchor CloseWindowButton
        {
            get { return this.Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault(a => a.InnerText == "Close"); }
        }

        public HtmlSpan WindowTitle
        {
            get
            {
                return this.Find.AllByTagName<HtmlSpan>("span")
                    .FirstOrDefault(sp => sp.InnerText == "Изпит в софтуерната академия");
            }
        }
    }
}