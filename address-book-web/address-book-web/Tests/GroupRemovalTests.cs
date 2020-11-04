using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace address_book_web
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            // читаем из браузера старый список
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.GroupExistanceCheck(1);
            app.Groups.Remove(0);

           //читаем из браузера новый список
            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);

            //сравниваются списки
            Assert.AreEqual(oldGroups, newGroups);

        }

    }
}
