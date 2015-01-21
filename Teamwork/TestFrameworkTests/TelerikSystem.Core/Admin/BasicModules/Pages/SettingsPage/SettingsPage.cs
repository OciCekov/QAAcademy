namespace TelerikSystem.Core.Admin.BasicModules.Pages.SettingsPage
{
    using System.Collections.Generic;
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class SettingsPage : BasePage<SettingsPageMap, SettingsPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration/Settings";
            }
        }

        public void CreateNewSetting(string name, string value, string discription = null)
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            this.Map.NewSetting.Click();
            this.Map.NewSettingName.Text = name;
            this.Map.NewSettingName.FireChange();
            this.Map.NewSettingValue.Text = value;
            this.Map.NewSettingValue.FireChange();
            this.Map.Update.FireClick();
        }

        public void ModifySetting(string name, string newName = null, string newValue = null)
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            int settingsCount = BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems.Count;
            int settingRowIndex = 0;
            for (int i = 0; i < settingsCount; i++)
            {
                bool correctRow = BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems[i][1].TextContent == name;
                if (correctRow)
                {
                    settingRowIndex = i;
                    break;
                }
            }

            HtmlAnchor editButton = BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems[settingRowIndex][5]
            .Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault();
            editButton.Click();
            if (newName != null)
            {
                BaseInstance<SettingsPage>.Instance.Map.NewSettingName.Text = newName;
                BaseInstance<SettingsPage>.Instance.Map.NewSettingName.FireChange();
            }

            if (newValue != null)
            {
                BaseInstance<SettingsPage>.Instance.Map.NewSettingValue.Text = newValue;
                BaseInstance<SettingsPage>.Instance.Map.NewSettingValue.FireChange();
            }

            BaseInstance<SettingsPage>.Instance.Map.Update.Click();
        }

        public void DeleteSetting(string name)
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            int settingsCount = BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems.Count;
            int newSettingRowIndex = 0;
            for (int i = 0; i < settingsCount; i++)
            {
                bool correctRow = BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems[i][1].TextContent == name;
                if (correctRow)
                {
                    newSettingRowIndex = i;
                    break;
                }
            }

            HtmlAnchor deleteButton = BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems[newSettingRowIndex][6]
            .Find.AllByTagName<HtmlAnchor>("a").FirstOrDefault();
            AlertDialog confirmDeletionDialog = AlertDialog.CreateAlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(confirmDeletionDialog);
            Manager.Current.DialogMonitor.Start();
            deleteButton.Click();
            confirmDeletionDialog.WaitUntilHandled();
            Manager.Current.DialogMonitor.Stop();
        }

        public bool IsSettingPresent(string name, string value = null)
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            int settingsCount = BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems.Count;
            var settingNames = new List<string>();
            for (int i = 0; i < settingsCount; i++)
            {
                settingNames.Add(BaseInstance<SettingsPage>.Instance.Map.SettingsGrid.DataItems[i][1].TextContent);
            }

            return settingNames.Contains(name);
        }
    }
}