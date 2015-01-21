namespace TelerikSystem.Core.Pages.MainPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Core;

    public class MainPageMap : BaseElementMap
    {
        public HtmlAnchor LogoutButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("ExitMI");
            }
        }

        public HtmlDiv HomePageButtonsContainer
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=homePageButtons");
            }
        }

        public HtmlAnchor Admin
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                           .Where(a => a.InnerText.Contains("Админ"))
                           .FirstOrDefault();
            }
        }

        public HtmlAnchor FirstForumPost
        {
            get
            {
                return this.Find.ById<HtmlListItem>("forum-posts-widget")
                               .Find.AllByAttributes<HtmlAnchor>("class=forumPostQuote")[0];
            }
        }

        public HtmlAnchor SecondForumPost
        {
            get
            {
                return this.Find.ById<HtmlListItem>("forum-posts-widget")
                           .Find.AllByAttributes<HtmlAnchor>("class=forumPostQuote")[1];
            }
        }

        public HtmlAnchor ThirdForumPost
        {
            get
            {
                return this.Find.ById<HtmlListItem>("forum-posts-widget")
                           .Find.AllByAttributes<HtmlAnchor>("class=forumPostQuote")[2];
            }
        }

        public HtmlContainerControl FirstFacebookPost
        {
            get
            {
                var body = Manager.Current.ActiveBrowser.Frames[2].Find.ByAttributes<HtmlControl>("dir=ltr");
                var div = body.Find.AllByExpression<HtmlDiv>("class=_4-u2 mbm _5jmm _5pat _5v3q _5x16")[0];
                var result = div.Find.AllByTagName<HtmlContainerControl>("p").FirstOrDefault();

                return result;
            }
        }

        public HtmlContainerControl SecondFacebookPost
        {
            get
            {
                var body = Manager.Current.ActiveBrowser.Frames[2].Find.ByAttributes<HtmlControl>("dir=ltr");
                var div = body.Find.AllByExpression<HtmlDiv>("class=_4-u2 mbm _5jmm _5pat _5v3q _5x16")[1];
                var result = div.Find.AllByTagName<HtmlContainerControl>("p").FirstOrDefault();

                return result;
            }
        }

        public HtmlContainerControl ThirdFacebookPost
        {
            get
            {
                var body = Manager.Current.ActiveBrowser.Frames[2].Find.ByAttributes<HtmlControl>("dir=ltr");
                var div = body.Find.AllByExpression<HtmlDiv>("class=_4-u2 mbm _5jmm _5pat _5v3q _5x16")[2];
                var result = div.Find.AllByTagName<HtmlContainerControl>("p").FirstOrDefault();

                return result;
            }
        }
    }
}