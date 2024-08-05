using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Library
{
    public class Library
    {
        private string _bookName;
        private string _authorName;
        private string _authorSurname;
        private string _publisher;
        private int _page;
        private DateTime _date;

        public string bookName  // Property for accessing and modifying the _bookName field.
        { 
            get
            {
                return _bookName;
            }
            set
            {
                _bookName = value;
            }
        }
        public string authorName // Property for accessing and modifying the _authorName field.
        {
            get
            {
                return _authorName;
            }
            set
            {
                _authorName = value;
            }
        }
        public string authorSurname // Property for accessing and modifying the _authorSurname field.
        {
            get
            {
                return _authorSurname;
            }
            set
            {
                _authorSurname = value;
            }
        }
        public string publisher // Property for accessing and modifying the _publisher field.
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }
        public int page // Property for accessing and modifying the _page field.
        {
            get
            {
                return _page;
            }
            set
            {
                _page = value;
            }
        }
        public DateTime date // Property for accessing and modifying the _date field.
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }


        public Library()  // Default Constructor , initializes a new instance of the Library class and sets the registration date to the current date and time.
        {
            SaveDate();
        }


        public Library(string bookName, string authorName,string authorSurname, int page, string publisher) // Initializes a new instance of the Library class with specified values and sets the registration date to the current date and time.
        {
            _bookName = bookName;
            _authorName = authorName;
            _publisher = publisher;
            _page = page;
            SaveDate();
        }

        public void SaveDate() // Method that sets the _date field to the current date and time when called.
        {
            _date = DateTime.Now;
        }

        public void DisplayProduct() // Method that displays the book's information, including its name, author, page count, publisher, and the date it was recorded.
        {
            Console.WriteLine($"Book Name: {_bookName}\nAuthor Name: {_authorName} {_authorSurname}\nPage Count: {_page}\nPublisher: {_publisher}\nRecord Date: {_date}\n");
        }

    }
}
