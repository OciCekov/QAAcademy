namespace TelerikSystem.Core.Admin.SoftwareAcademy.Pages.Seasons.SeasonsMainPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using ArtOfTest.WebAii.Core;
using System.Collections.Generic;

    public class MainPageSeasonPageMap : BaseElementMap
    {
        public HtmlAnchor CreateSeason
        {
            get
            {
                return this.Find.ById<HtmlDiv>("DataGrid")
                           .Find.ByContent<HtmlAnchor>("Създай сезон");
            }
        }

       public IEnumerable<HtmlTableRow> TableRows
        {
            get
            {
                return this.Find.ByAttributes<HtmlTable>("role=grid")
                    .Find.AllByTagName<HtmlTable>("tbody").FirstOrDefault()
                    .Find.AllByTagName<HtmlTableRow>("tr");
            }
        }

        public HtmlTableRow FirstRow
       {
           get
           {
               return this.TableRows.FirstOrDefault();
           }
       }

        public HtmlTableRow LastRow
        {
            get
            {
                return this.TableRows.LastOrDefault();
            }
        }

        public void ClickDelete(int numberRow)
        {
            this.Find.ByAttributes<HtmlTable>("role=grid")
                    .Find.AllByTagName<HtmlTable>("tbody").FirstOrDefault()
                    .Find.AllByTagName<HtmlTableRow>("tr")[numberRow]
                    .Find.AllByTagName<HtmlTableCell>("td")[3].Click();
           
        }

        public void ClickEdit(int numberRow)
        {
            this.Find.ByAttributes<HtmlTable>("role=grid")
                    .Find.AllByTagName<HtmlTable>("tbody").FirstOrDefault()
                    .Find.AllByTagName<HtmlTableRow>("tr")[numberRow]
                    .Find.AllByTagName<HtmlTableCell>("td")[2].Click();

        }
    }
}

