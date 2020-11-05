using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace address_book_web
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigator;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook";
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);

        }
       ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
            }
        }

        public static ApplicationManager GetInstanse()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigator.GotoHomepage();
                app.Value = newInstance;
                
            }
            return app.Value;
        }
        public IWebDriver Driver 
        { 
        get
            {
                return driver;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigator;
            }
        }
        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }

        }
        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }

        }
        public ContactHelper Contacts
        {
            get
            {
                return contactHelper;
            }

        }
    }
}

