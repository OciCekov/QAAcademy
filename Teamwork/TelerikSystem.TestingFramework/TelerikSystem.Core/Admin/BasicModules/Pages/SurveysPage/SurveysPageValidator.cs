namespace TelerikSystem.Core.Admin.BasicModules.Pages.SurveysPage
{
    using System.Collections.Generic;
    using TestingFramework.Core.Base;

    public class SurveysPageValidator
    {
        public void AssertSurveyExists(string name)
        {
            var surveysGrid = Pages<SurveysPage>.Instance.Map.SurveysGrid;
            var surveysNames = new HashSet<string>();
            Pages<SurveysPage>.Instance.Navigate();
            var lel = Pages<SurveysPage>.Instance.Map.SurveysGrid.DataItems;
            bool lol = Pages<SurveysPage>.Instance.Map.SurveysTable.InnerText.Contains("NAMEMEME");
            System.Console.WriteLine();
            /*foreach (var item in surveysGrid.DataItems)
            {
                surveysNames.Add(item)
            }*/
        }
    }
}
