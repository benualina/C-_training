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
            GotoHomepage();
            Login(new AccountData("admin", "secret"));
            GotoGroupsPage();
            SelectGroup(1);
            DeleteGroup();
            ReturnToGroupPage();
        }

    }
}
