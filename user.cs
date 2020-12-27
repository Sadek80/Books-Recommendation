using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books_Recommendation
{
    public class user : Person
    {
        public string password
        {
            get => default;
            set
            {
            }
        }

        public string username
        {
            get => default;
            set
            {
            }
        }

        public string email
        {
            get => default;
            set
            {
            }
        }

        public book book = new book();
        public userDb userDb = new userDb();

        public void recommend()
        {
            book.getBook();
        }

        public void editProfile()
        {
            userDb.updateUser();
        }
    }
}