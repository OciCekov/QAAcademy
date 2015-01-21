using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestStudio_VS_Selenium
{

    public class SilverLightControls : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        //[CodedStep(@"New Coded Step")]
        //public void SilverLightControls_CodedStep()
        //{
            //var hoursToVerify = GetExtractedValue("TimeTextTextblock").ToString();
            //var dateToVerify = GetExtractedValue("OCT032014Textblock").ToString();
            //var dayToVerify = GetExtractedValue("FRIDAYTextblock").ToString();
            
            //var actualDateTime = new DateTime.Now();
            
            
            
            
        //}
    
        //[CodedStep(@"New Coded Step")]
        //public void SilverLightControls_CodedStep()
        //{
            //string takenDate = (string)(System.Convert.ChangeType(Data["todayDate"], typeof(string)));
            //Log.WriteLine(takenDate);
            
        //}
    
        [CodedStep(@"Verify Date ")]
        public void SilverLightControls_CodedStep()
        {
            // If you know what is the pourpose for "Routine" field, can you please share(link will work too)
            var dateFromSite = GetExtractedValue("dateFromSite").ToString();
            string format = "MMM dd" + ", " + "yyyy";
            DateTime today = DateTime.Now;
            var culture = CultureInfo.InvariantCulture;
            var formatForVerification = today.ToString(format, culture).ToUpper();
            
            Assert.AreEqual<string>(formatForVerification, dateFromSite);
        }
    
        //[CodedStep(@"Verify 'ControlNameTextblock' text Same 'Gauge'", RequiresSilverlight=true)]
        //public void SilverLightControls_CodedStep1()
        //{
            //// Verify 'ControlNameTextblock' text Same 'Gauge'
            //Assert.IsFalse((ArtOfTest.Common.CompareUtils.StringCompare(Pages.TelerikGaugeForSilverlight0.SilverlightApp.ControlNameTextblock.Text, "Gauge", ArtOfTest.Common.StringCompareType.Same) == false), string.Format("Verify \'ControlNameTextblock\' text Same \'Gauge\' failed.  Actual value \'{0}\'", Pages.TelerikGaugeForSilverlight0.SilverlightApp.ControlNameTextblock.Text));
            
        //}
    }
}
