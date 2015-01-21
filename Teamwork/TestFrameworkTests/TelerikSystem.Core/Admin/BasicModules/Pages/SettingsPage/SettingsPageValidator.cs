namespace TelerikSystem.Core.Admin.BasicModules.Pages.SettingsPage
{
    using System.Linq;
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class SettingsPageValidator
    {
        public void AssertSettingPresent(string settingName)
        {
            Assert.IsTrue(BaseInstance<SettingsPage>.Instance.IsSettingPresent(settingName));
        }

        public void AssertNewSettingFieldsAreRequired()
        {
            BaseInstance<SettingsPage>.Instance.Map.NewSetting.Click();
            BaseInstance<SettingsPage>.Instance.Map.Update.Click();
            Assert.IsTrue(BaseInstance<SettingsPage>.Instance.Map.NameValidationMessage.IsVisible());
            Assert.IsTrue(BaseInstance<SettingsPage>.Instance.Map.ValueValidationMessage.IsVisible());

            BaseInstance<SettingsPage>.Instance.Map.NewSettingName.Text = "ValidName";
            BaseInstance<SettingsPage>.Instance.Map.NewSettingName.FireChange();
            BaseInstance<SettingsPage>.Instance.Map.Update.Click();
            Assert.IsTrue(BaseInstance<SettingsPage>.Instance.Map.ValueValidationMessage.IsVisible());

            BaseInstance<SettingsPage>.Instance.Map.NewSettingName.Text = string.Empty;
            BaseInstance<SettingsPage>.Instance.Map.NewSettingName.FireChange();
            BaseInstance<SettingsPage>.Instance.Map.NewSettingValue.Text = "ValidValue";
            BaseInstance<SettingsPage>.Instance.Map.NewSettingValue.FireChange();
            BaseInstance<SettingsPage>.Instance.Map.Update.Click();
            Assert.IsTrue(BaseInstance<SettingsPage>.Instance.Map.NameValidationMessage.IsVisible());
        }

        public void AssertCanDeleteSetting(string name)
        {
            BaseInstance<SettingsPage>.Instance.DeleteSetting(name);
            Assert.IsFalse(BaseInstance<SettingsPage>.Instance.IsSettingPresent(name));            
        }

        public void AssertNewSettingButtonIsVisible()
        {
            Assert.IsTrue(BaseInstance<SettingsPage>.Instance.Map.NewSetting.IsVisible());
        }
    }
}