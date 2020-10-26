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
    public class NewContactCreationTest : AuthTestBase
    {
        [Test]
        public void NewContactCreation()
        {
            ContactData contact = new ContactData("Франчук");
            contact.Address = "г.Москва, ул Савеловская, дом 13а";
            contact.Company = "ООО Мороз";
            contact.Email = "324@gmail.com";
            contact.Homenumber = "+74956234133";
            app.Contacts.Createcontact(contact);

        }


    }
}
