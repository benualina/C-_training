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
    public class NewContactCreationTest : TestBase
    {
        [Test]
        public void NewContactCreation()
        {
            app.Navigator.GotoHomepage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Groups.ContactCreation();
            ContactData contact = new ContactData("Аксенова");
            contact.Address = "г.Москва, ул Арбат, дом 12";
            contact.Company = "ООО Компания";
            contact.Email = "aksol@gmail.com";
            contact.Homenumber = "+74956723399";
            contact.Email = "aksol@gmail.com";
            app.Groups.FillContactForm(contact);
            app.Groups.SubmitContactCreation();
            app.Groups.ReturtToHomepage();
            app.Groups.Logout();
        }

        
    }
}
