namespace TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages
{
    using System.Linq;

    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Controls.HtmlControls;

    using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.CreateDynamicPage;
    using TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages.DeletePage;
    using TestingFramework.Core.Base;

    public class DynamicPagesPageValidator
    {
        public void VerifyDynamicPageIsCreated()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("PageToDelete", "some content", "description", "keywords", "24/10/2014 00:00:00", "26/02/2015 12:34:34");
            HtmlTableCell searchName = FindCreatedPage("AAQ");

            Assert.IsNotNull(searchName);
        }

        public void VerifyDynamicPageIsNotCreated()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("PageNotCreated", "   ", "description", "keywords", "24/10/2014 00:00:00", "26/02/2015 12:34:34");
            HtmlTableCell searchName = FindCreatedPage("PageNotCreated");

            Assert.IsNull(searchName);
        }
      
        public void VerifyDynamicPageIsDeleted()
        {
            BaseInstance<CreateDynamicPagePage>.Instance.CreateDynamicPage("PageToDeleteInsatntly", "some content", "description", "keywords", "24/10/2014 00:00:00", "26/02/2015 12:34:34");
            HtmlTableCell searchName = FindCreatedPage("PageToDeleteInsatntly");
            int lastRowIndex = BaseInstance<DynamicPagesPage>.Instance.Map.TablePagesRows.Count() - 1;

            var lastRow = BaseInstance<DynamicPagesPage>.Instance.Map.TablePagesRows
                                    .Where(r => r.RowIndex == lastRowIndex);
            var lastCol = lastRow.FirstOrDefault()
                                    .Find.AllByTagName<HtmlTableCell>("td")[3];
            var linkDelete = lastCol.Find.AllByAttributes<HtmlAnchor>("href=~/Administration/PagesOld/Delete/").FirstOrDefault();

            linkDelete.Click();

            BaseInstance<DeletePagePage>.Instance.Map.DeleteButton.Click();
            searchName = FindCreatedPage("PageToDeleteInsatntly");
            int lastRowIndexAfterDelete = BaseInstance<DynamicPagesPage>.Instance.Map.TablePagesRows.Count() - 1;

            //// Two ways to assert the test will pass
            Assert.IsNull(searchName);
            Assert.IsTrue(lastRowIndex - 1 == lastRowIndexAfterDelete);
        }

        private HtmlTableCell FindCreatedPage(string namePage)
        {

            return BaseInstance<DynamicPagesPage>.Instance.Map.TitlePagesColumn.Where(c => c.InnerText == namePage).FirstOrDefault();
        }
    }
}

