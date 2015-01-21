using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core.Base;
using TelerikSystem.Core.Pages.MainPage;

namespace TelerikSystem.Tests.Pages
{
    [TestClass]
    public class MainPageVerifyPosts : BaseTest
    {
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifyFirstPostForum()
        {
            BaseInstance<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifySecondPostForum()
        {
            BaseInstance<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifyThirdPostForum()
        {
            BaseInstance<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void VerifyFirstFacebookForum()
        {
            BaseInstance<MainPage>.Instance.Validator.AssertFirstFacebookPost();
        }
    }
}
