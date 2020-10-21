using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace address_book_web
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TheUntitledTestCaseTest()
        {
            app.Navigator.GotoHomepage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GotoGroupsPage();
            app.Groups.SelectGroup(1);
            app.Groups.DeleteGroup();
            app.Groups.ReturnToGroupPage();
        }

    }
}
