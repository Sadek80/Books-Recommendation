using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books_Recommendation
{
    public class book
    {
        public string name
        {
            get => default;
            set
            {
            }
        }

        public int id
        {
            get => default;
            set
            {
            }
        }

        public string author
        {
            get => default;
            set
            {
            }
        }

        public string category
        {
            get => default;
            set
            {
            }
        }

        public string link
        {
            get => default;
            set
            {
            }
        }

        public string picture
        {
            get => default;
            set
            {
            }
        }

        public bookDb bookDb = new bookDb();
       

        public void addBook()
        {
            bookDb.addBook();
        }

        public void deleteBook()
        {
            bookDb.deleteBook();
        }

        public void updateBook()
        {
            bookDb.updateBook();
        }

        public void getBook()
        {
            bookDb.getBook();
        }
    }
}