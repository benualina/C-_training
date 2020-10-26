using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace address_book_web
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("Переименованная группа");
            newData.Header = null;
            newData.Footer = null;

            app.Groups.Modify(1, newData);
        }

    }
}
