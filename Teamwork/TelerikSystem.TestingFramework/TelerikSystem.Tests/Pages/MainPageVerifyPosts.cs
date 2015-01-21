using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core.Base;
using TelerikSystem.Core.Pages.MainPage;
// using NUnit.Framework;

namespace TelerikSystem.Tests.Pages
{
    [TestClass]
    public class MainPageVerifyPosts : BaseTest
    {
        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
       // [TestCase(257)]
        public void VerifyFirstPostForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
     //   [TestCase(380)]
        public void VerifySecondPostForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
    //    [TestCase(381)]
        public void VerifyThirdPostForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstForumPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
     //   [TestCase(258)]
        public void VerifyFirstFacebookForum()
        {
            Pages<MainPage>.Instance.Validator.AssertFirstFacebookPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
      //  [TestCase(382)]
        public void VerifySecondFacebookForum()
        {
            Pages<MainPage>.Instance.Validator.AssertSecondFacebookPost();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
       // [TestCase(383)]
        public void VerifyThirdFacebookForum()
        {
            Pages<MainPage>.Instance.Validator.AssertThirdFacebookPost();
        }
    }
}
