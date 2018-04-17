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
using System.Collections.Generic;
using System.Windows.Forms;
namespace Program4
{
    public partial class Program4 : Form
    {
        private List<LibraryBook> library;
        public Program4()
        {
            InitializeComponent();
            library=new List<LibraryBook>();
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;//Book title
            string author = txtAuthor.Text;//Book's author
            string publisher = txtPublisher.Text;//Book's publisher
            string callNumber = txtCallNumber.Text;//Book's call number
            int copyrightYear; //Book's copyright year
            bool copyrightYearParsedSuccessfully = int.TryParse(txtCopyrightYear.Text, out copyrightYear); //Was the copyright year successfully parsed?

            string errorMessage = string.Empty;//Stores error message to be displayed to user if input validation fails
            if(title.Length==0)
                errorMessage+="Book Title must be supplied."+Environment.NewLine;
            if(author.Length==0)
                errorMessage+="Book Author must be supplied."+Environment.NewLine;
            if(publisher.Length==0)
                errorMessage+="Book Publisher must be supplied."+Environment.NewLine;
            if(!copyrightYearParsedSuccessfully)
                errorMessage+="Copyright Year must be a non-negative integer."+Environment.NewLine;
            if(callNumber.Length==0)
                errorMessage+="Book's Call Number must be supplied."+Environment.NewLine;
            if(errorMessage.Length==0)//All validation succeeded; add book to Library
            {
                LibraryBook libraryBook = //Holds Book information for storing in the Library.
                    new LibraryBook(title, author, publisher, copyrightYear, callNumber);
                library.Add(libraryBook);
                lstboxLibrary.Items.Add(libraryBook.Title);

                //Clear textboxes for a new book to be added.
                txtTitle.Clear();
                txtAuthor.Clear();
                txtPublisher.Clear();
                txtCopyrightYear.Clear();
                txtCallNumber.Clear();
            }
            else
                MessageBox.Show(errorMessage);
        }
        private void btnReturnToShelf_Click(object sender, EventArgs e)
        {
            if(lstboxLibrary.SelectedIndex!=-1)
            {
                library[lstboxLibrary.SelectedIndex].ReturnToShelf();
                MessageBox.Show(library[lstboxLibrary.SelectedIndex].Title+" has been returned to shelf.");
            }
            else
                MessageBox.Show("You must select a book first.");
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(lstboxLibrary.SelectedIndex!=-1)
            {
                library[lstboxLibrary.SelectedIndex].CheckOut();
                MessageBox.Show(library[lstboxLibrary.SelectedIndex].Title+" has been checked out.");
            }
            else
                MessageBox.Show("You must select a book first.");
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            if(lstboxLibrary.SelectedIndex!=-1)
                MessageBox.Show(library[lstboxLibrary.SelectedIndex].ToString());
            else
                MessageBox.Show("You must select a book first.");
        }
    }
}