using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books_Recommendation
{
    public class admin : Person
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

        public book book = new book();
      

        public void addBook()
        {
            book.addBook();
        }

        public void updateBook()
        {
            book.updateBook();
        }

        public void deleteBook()
        {
            book.deleteBook();
        }
    }
}