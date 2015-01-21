namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.EntranceExam.MainPage
{
    using System.Collections.Generic;
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Telerik.TestingFramework.Controls.KendoUI;
    using TestingFramework.Core.Base;

    public class EntranceExamPageMap : BaseElementMap
    {
        public HtmlAnchor GetToExams
        {
            get
            {
                return
                    this.Find.AllByTagName<HtmlAnchor>("a")
                        .FirstOrDefault(a => a.InnerText == "Добавяне на нов входен изпит");
            }
        }

        public HtmlAnchor EditExam
        {
            get { return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr[1]/td[12]/a"); }
        }

        public KendoGrid ExamsGrid
        {
            get { return this.Find.ById<KendoGrid>("DataGrid"); }
        }

        public HtmlAnchor RefreshGrid
        {
            get { return this.Find.ByXPath<HtmlAnchor>("//*[@id=\"DataGrid\"]/div[1]/a[1]"); }
        }

        public HtmlTableCell StartTimeCell
        {
            get { return this.Find.ByXPath<HtmlTableCell>("//*[@id='DataGrid']/table/tbody/tr[1]/td[3]"); }
        }

        public HtmlAnchor DeleteTopExam
        {
            get { return this.Find.ByXPath<HtmlAnchor>("//*[@id='DataGrid']/table/tbody/tr[1]/td[13]/a"); }
        }

        public HtmlControl TableBody
        {
            get
            {
                var grid = this.Find.ById<HtmlDiv>("DataGrid")
                .Find.AllByAttributes<HtmlTable>("role=treegrid")
                    .FirstOrDefault()
                .Find.AllByAttributes<HtmlControl>("data-role=tooltip").FirstOrDefault();
                return grid;
            }
        }

        public IEnumerable<HtmlTableRow> TableRows
        {
            get { return this.TableBody.Find.AllByTagName<HtmlTableRow>("tr"); }
        }
    }
}