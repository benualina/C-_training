using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace address_book_web
{
    class ContactData
    {
        private string firstname;
        private string lastname = "";
        private string nickname = "";
        private string company = "";
        private string address = "";
        private string homenumber = "";
        private string email = "";


        public ContactData(string firstname)
        {
            this.firstname = firstname;
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Homenumber
        {
            get
            {
                return homenumber;
            }

            set
            {
                homenumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
