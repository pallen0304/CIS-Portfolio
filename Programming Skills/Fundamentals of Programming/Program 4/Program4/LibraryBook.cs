/* 
* Grading ID: B6722
* Assignment Due Date: December 06, 2016 11:59:00 PM
* CIS 199-75
* Program 4
*/
/// <summary>
/// This application uses a LibraryBook class object to store book information for reuse.
/// User may add books to the 'Library' by providing valid data in all textboxes and pressing Add Book.
/// If the copyright year is negative, it is set to 2016.
/// User may check out, return, and get details for books in the library.
/// </summary>
using System;
namespace Program4
{
    class LibraryBook
    {
        private string title;//LibraryBook's Title;
        private string author;//LibraryBook's Author
        private string publisher;//LibraryBook's Publisher
        private int copyrightYear;//LibraryBook's Copyright Year
        private string callNumber;//LibraryBook's Call Number
        private bool isCheckedOut;//Is the Library Book checked out?

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Publisher { get { return publisher; } set { publisher = value; } }
        public string CallNumber { get { return callNumber; } set { callNumber = value; } }
        public int CopyrightYear
        {
            get { return copyrightYear; }
            set
            {
                if ( value >= 0 )
                    copyrightYear = value;
                else
                    copyrightYear = 2016;
            }
        }

        public LibraryBook(string title , string author , string publisher , int copyrightYear , string callNumber) : base()
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyrightYear;
            CallNumber = callNumber;
        }
        public void CheckOut()
        {
            isCheckedOut = true;
        }
        public void ReturnToShelf()
        {
            isCheckedOut = false;
        }
        public bool IsCheckedOut()
        {
            return isCheckedOut;
        }
        public override string ToString()
        {
            return string.Format("Title: {1}{0}Author: {2}{0}Publisher: {3}{0}Copyright Year: {4}{0}Call Number: {5}{0}Checked Out: {6}" , 
                Environment.NewLine, Title, Author, Publisher, CopyrightYear, CallNumber, IsCheckedOut());
        }
    }
}
