using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace address_book_web
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.Remove(1);
        }

    }
}
