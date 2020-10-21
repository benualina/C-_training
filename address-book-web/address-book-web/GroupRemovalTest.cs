using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace address_book_web
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TheUntitledTestCaseTest()
        {
            navigator.GotoHomepage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GotoGroupsPage();
            groupHelper.SelectGroup(1);
            groupHelper.DeleteGroup();
            groupHelper.ReturnToGroupPage();
        }

    }
}
