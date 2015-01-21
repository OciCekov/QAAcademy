namespace TelerikSystem.Core.Pages.FacebookPage
{
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    using TestingFramework.Core.Base;
    using ArtOfTest.WebAii.Core;
    using System.Collections.Generic;

    public class FacebookPageMap : BaseElementMap
    {
        public HtmlSpan FirstFacebookPost
        {
            get
            {
                return this.Find.AllByExpression<HtmlDiv>("id=~tl_unit_")[0]
                           .Find.AllByAttributes<HtmlSpan>("class=userContent")[0];
            }
        }

        public HtmlSpan SecondFacebookPost
        {
            get
            {
                return this.Find.AllByExpression<HtmlDiv>("id=~tl_unit_")[1]
                           .Find.AllByAttributes<HtmlSpan>("class=userContent")[0];
            }
        }

        public HtmlSpan ThirdFacebookPost
        {
            get
            {
                return this.Find.AllByExpression<HtmlDiv>("id=~tl_unit_")[2]
                           .Find.AllByAttributes<HtmlSpan>("class=userContent")[0];
            }
        }
      
    }
}