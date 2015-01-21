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
            Pages<CreateDynamicPagePage>.Instance.CreateDynamicPage("AAQ", "some content", "description", "keywords", "24/10/2014 00:00:00", "26/02/2015 12:34:34");
            string searchNameLastCreated = FindLastCreatedPageName();

            Assert.AreEqual<string>("AAQ", searchNameLastCreated);
        }

        public void VerifyDynamicPageIsNotCreated()
        {
            Pages<CreateDynamicPagePage>.Instance.CreateDynamicPage("PageNotCreated", "        ", "description", "keywords", "24/10/2014 00:00:00", "26/02/2015 12:34:34");

            Pages<DynamicPagesPage>.Instance.Navigate();
            string searchNameLastCreated = FindLastCreatedPageName();

            Assert.AreNotEqual<string>("PageNotCreated", searchNameLastCreated);
        }
      
        public void VerifyDynamicPageIsDeleted()
        {
            Pages<CreateDynamicPagePage>.Instance.CreateDynamicPage("PageToDeleteInsatntly", "some content", "description", "keywords", "24/10/2014 00:00:00", "26/02/2015 12:34:34");
            string searchNameLastCreated = FindLastCreatedPageName();
            int lastRowIndex = Pages<DynamicPagesPage>.Instance.Map.TablePagesRows.Count() - 1;

            var lastRow = Pages<DynamicPagesPage>.Instance.Map.TablePagesRows
                                    .Where(r => r.RowIndex == lastRowIndex);
            var lastCol = lastRow.FirstOrDefault()
                                    .Find.AllByTagName<HtmlTableCell>("td")[3];
            var linkDelete = lastCol.Find.AllByAttributes<HtmlAnchor>("href=~/Administration/PagesOld/Delete/").FirstOrDefault();

            linkDelete.Click();

            Pages<DeletePagePage>.Instance.Map.DeleteButton.Click();
            searchNameLastCreated = FindLastCreatedPageName();
            int lastRowIndexAfterDelete = Pages<DynamicPagesPage>.Instance.Map.TablePagesRows.Count() - 1;

            //// Two ways to assert the test will pass
            Assert.AreNotEqual<string>("PageToDeleteInsatntly", searchNameLastCreated);
            Assert.IsTrue(lastRowIndex - 1 == lastRowIndexAfterDelete);
        }

        private string FindLastCreatedPageName()
        {
            return Pages<DynamicPagesPage>.Instance.Map.TablePagesRows.LastOrDefault()
                                                       .Find.AllByTagName<HtmlTableCell>("td")
                                                       .Where(t => t.CellIndex == 0).FirstOrDefault().InnerText;

        }
    }
}

