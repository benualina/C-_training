using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace address_book_web
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Сидоров");
            newData.Address = "г.Омск, ул Дежурная, дом 4";
            newData.Company = "ООО Экспо";
            newData.Email = "aaa@gmail.com";
            newData.Homenumber = "+74234324";
            app.Contacts.Modify(1, newData);
        }
    }
}
