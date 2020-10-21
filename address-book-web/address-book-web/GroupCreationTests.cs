﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace address_book_web
{
    [TestFixture]
    public class GroupCreationTests: TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GotoHomepage();
            Login(new AccountData("admin", "secret"));
            GotoGroupsPage();
            CreationNewGroup();
            GroupData group = new GroupData("342");
            group.Header = "dsf";
            group.Footer = "32";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            Logout();
        }
    }
}
