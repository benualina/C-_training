using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
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
            ContactData contact = new ContactData("Петрова");
            contact.Lastname = "Елена";
            contact.Address = "г.Москва, ул Савеловская, дом 13а";
            contact.Company = "ООО Мороз";
            contact.Email = "324@gmail.com";
            contact.Homenumber = "+74956234133";

            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.Createcontact(contact);
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);

        }


    }
}
