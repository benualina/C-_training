using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace address_book_web
{
    public class GroupHelper : HelperBase
    {

        public GroupHelper(ApplicationManager manager) : base(manager)
        {

        }

        public GroupHelper Remove(int v)
        {
            manager.Navigator.GotoGroupsPage();
            GroupExistanceCheck(v);
            SelectGroup(v);
            DeleteGroup();
            ReturnToGroupPage();
            return this;

        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.GotoGroupsPage();
            GroupExistanceCheck(v);
            SelectGroup(v);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupPage();
            return this;

        }
        //Метод создания группы контактов
        public GroupHelper Create(GroupData group)
        {
            //менеджер просит навигатор перейти на другую страницу
            manager.Navigator.GotoGroupsPage();
            CreationNewGroup();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupPage();
            return this;
        }

        public GroupHelper ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }

        public GroupHelper DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }


        public GroupHelper CreationNewGroup()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }


        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Header);
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper GroupExistanceCheck(int index)
        {
            if (IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + index + "]")))
            {
                return this;
            }
            else
            {
                ApplicationManager app = ApplicationManager.GetInstanse();
                GroupData group = new GroupData("342");
                group.Header = "dsf";
                group.Footer = "32";
                app.Groups.Create(group);
            }
            return this;
        }
    }
}
