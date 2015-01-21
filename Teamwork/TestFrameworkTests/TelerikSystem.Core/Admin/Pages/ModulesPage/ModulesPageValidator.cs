namespace TelerikSystem.Core.Admin.Pages.ModulesPage
{
    using ArtOfTest.Common.UnitTesting;

    using TestingFramework.Core.Base;

    public class ModulesPageValidator
    {
        public void AssertSettingsModuleExists()
        {
            Assert.IsTrue(BaseInstance<ModulesPage>.Instance.Map.SettingsModule.IsVisible());
        }
    }
}