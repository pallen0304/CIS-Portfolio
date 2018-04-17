// Program 3
// CIS 200-01
// Due: 4/03/2017
// By: D7611

// File: Prog3Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.

// Extra Credit - Check Out and Return only show relevant items

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class Prog3Form : Form
    {
        private Library _lib; // The library

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog3Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library
            /*
            // Insert test data - Magic numbers allowed here
            _lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14, "ZZ25 3G", "Andrew Wright");
            _lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21, "AB73 ZF", "IP Thief");
            _lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
                "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
                LibraryMovie.MPAARatings.PG);
            _lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
                "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            _lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
                "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            _lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
                "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            _lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
                "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            _lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
                "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9A", 16, 7);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9B", 16, 8);
            _lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14, "MA53 9C", 16, 9);
            _lib.AddLibraryMagazine("VB Magazine", "UofL Mags", 2017, 14, "MA21 5V", 1, 1);

            // Add 5 Patrons
            _lib.AddPatron("Ima Reader", "12345");
            _lib.AddPatron("Jane Doe", "11223");
            _lib.AddPatron("John Smith", "54321");
            _lib.AddPatron("James T. Kirk", "98765");
            _lib.AddPatron("Jean-Luc Picard", "33456");
            */
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 3{NL}By: D7611{NL}CIS 200-01{NL}Spring 2017",
                "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryPatron> patrons;                // List of patrons
            string NL = Environment.NewLine;            // NewLine shortcut

            patrons = _lib.GetPatronsList();

            result.Append($"Patron List - {patrons.Count} patrons{NL}{NL}");

            foreach (LibraryPatron p in patrons)
                result.Append($"{p}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            result.Append($"Item List - {items.Count} items{NL}{NL}");

            foreach (LibraryItem item in items)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder(); // Holds text as report being built
                                                        // StringBuilder more efficient than String
            List<LibraryItem> items;                    // List of library items
            string NL = Environment.NewLine;            // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            result.Append($"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}");

            foreach (LibraryItem item in checkedOutItems)
                result.Append($"{item}{NL}{NL}");

            reportTxt.Text = result.ToString();

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that aren't already checked out

            List<LibraryItem> notCheckedOutList; // List of items not checked out
            List<int> notCheckedOutIndices;      // List of index values of items not checked out
            List<LibraryItem> items;             // List of library items
            List<LibraryPatron> patrons;         // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();
            notCheckedOutList = new List<LibraryItem>();
            notCheckedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (!items[i].IsCheckedOut()) // Not checked out
                {
                    notCheckedOutList.Add(items[i]);
                    notCheckedOutIndices.Add(i);
                }

            if ((notCheckedOutList.Count() == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(notCheckedOutList, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = notCheckedOutIndices[checkoutForm.ItemIndex]; // Look up index from full list
                        _lib.CheckOut(itemIndex, checkoutForm.PatronIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Check Out Index!", "Check Out Error");
                    }
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Extra Credit - Only display items that are already checked out

            List<LibraryItem> checkedOutList; // List of items checked out
            List<int> checkedOutIndices;      // List of index values of items checked out
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();
            checkedOutList = new List<LibraryItem>();
            checkedOutIndices = new List<int>();

            for (int i = 0; i < items.Count(); ++i)
                if (items[i].IsCheckedOut()) // Checked out
                {
                    checkedOutList.Add(items[i]);
                    checkedOutIndices.Add(i);
                }

            if ((checkedOutList.Count() == 0)) // Must have checked out items
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(checkedOutList); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        int itemIndex; // Index of item from full list of items

                        itemIndex = checkedOutIndices[returnForm.ItemIndex]; // Look up index from full list
                        _lib.ReturnToShelf(itemIndex);
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Return Index!", "Return Error");
                    }
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Edit, Patron menu item activated
        // Postcondition: The Patron Selection dialog box is displayed. The PatronEdit 
        //                dialog box is displayed with the selected LibraryPatron. If data entered
        //                are OK, the LibraryPatron is updated and saved to the library
        private void patronEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons;     // List of library patrons
            int patronIndex = -1; // Index of book from full list of items
            List<int> libraryPatronIndices = new List<int>();

            patrons = _lib.GetPatronsList();
            libraryPatronIndices.AddRange(Enumerable.Range(0, patrons.Count));

            if ((patrons.Count() == 0)) // Must have checked out items
                MessageBox.Show("Must have patrons to edit!", "Patron Edit Error");
            else
            {
                SelectPatronForm selectPatronForm = new SelectPatronForm(patrons); // The select patron dialog box form

                DialogResult selectionResult = selectPatronForm.ShowDialog(); // Show form as dialog and store result

                if (selectionResult == DialogResult.OK) // Only open edit if OK
                {
                    try
                    {
                        patronIndex = libraryPatronIndices[selectPatronForm.PatronIndex]; // Look up index from full list
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Patron Index!", "Edit Error");
                    }
                }

                selectPatronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }

            if (patronIndex != -1) // A patron is selected
            {
                LibraryPatron patron = patrons[patronIndex];
                PatronForm patronForm = new PatronForm() // The book dialog box form
                {
                    PatronID = patron.PatronID,
                    PatronName = patron.PatronName
                };
                DialogResult patronResult = patronForm.ShowDialog(); // Show form as dialog and store result

                if (patronResult == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        // Use form's properties to get patron info to send to library
                        _lib._patrons[patronIndex].PatronID = patronForm.PatronID;
                        _lib._patrons[patronIndex].PatronName = patronForm.PatronName;
                    }

                    catch (FormatException) // This should never happen if form validation works!
                    {
                        MessageBox.Show("Problem with Patron Validation!", "Validation Error");
                    }
                }

                patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Edit, Book menu item activated
        // Postcondition: The Book Selection dialog box is displayed. The BookEdit 
        //                dialog box is displayed with the selected LibraryBook. If data entered
        //                are OK, the LibraryBook is updated and saved to the library
        private void bookEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            List<LibraryBook> libraryBookList; // List of books to edit
            List<int> libraryBookIndices;      // List of index values of books
            int itemIndex = -1; // Index of book from full list of items

            items = _lib.GetItemsList();
            libraryBookList = new List<LibraryBook>();
            libraryBookIndices = new List<int>();
            for (int i = 0; i < items.Count(); ++i)
                if (items[i] is LibraryBook) // books
                {
                    libraryBookList.Add(items[i] as LibraryBook);
                    libraryBookIndices.Add(i);
                }

            if ((libraryBookList.Count() == 0)) // Must have books to edit
                MessageBox.Show("Must have books to edit!", "Return Error");
            else
            {
                SelectBookForm selectBookForm = new SelectBookForm(libraryBookList); // The select book dialog box form

                DialogResult selectionResult = selectBookForm.ShowDialog(); // Show form as dialog and store result

                if (selectionResult == DialogResult.OK) // Only open edit if OK
                {
                    try
                    {
                        itemIndex = libraryBookIndices[selectBookForm.BookIndex]; // Look up index from full list
                    }
                    catch (ArgumentOutOfRangeException) // This should never happen
                    {
                        MessageBox.Show("Problem with Book Index!", "Edit Error");
                    }
                }

                selectBookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }

            if (itemIndex != -1) // A book is selected
            {
                LibraryBook book = items[itemIndex] as LibraryBook;
                BookForm bookForm = new BookForm() // The book dialog box form
                {
                    ItemTitle = book.Title,
                    ItemCallNumber = book.CallNumber,
                    ItemCopyrightYear = book.CopyrightYear.ToString(),
                    ItemLoanPeriod = book.LoanPeriod.ToString(),
                    ItemPublisher = book.Publisher,
                    BookAuthor = book.Author
                };
                DialogResult bookResult = bookForm.ShowDialog(); // Show form as dialog and store result

                if (bookResult == DialogResult.OK) // Only add if OK
                {
                    try
                    {
                        // Use form's properties to get book info to send to library
                        _lib._items[itemIndex].Title = bookForm.ItemTitle;
                        _lib._items[itemIndex].Publisher = bookForm.ItemPublisher;
                        _lib._items[itemIndex].CopyrightYear = int.Parse(bookForm.ItemCopyrightYear);
                        _lib._items[itemIndex].LoanPeriod = int.Parse(bookForm.ItemLoanPeriod);
                        _lib._items[itemIndex].CallNumber = bookForm.ItemCallNumber;
                        (_lib._items[itemIndex] as LibraryBook).Author = bookForm.BookAuthor;
                    }

                    catch (FormatException) // This should never happen if form validation works!
                    {
                        MessageBox.Show("Problem with Book Validation!", "Validation Error");
                    }
                }

                bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  File, Open Library menu item activated
        // Postcondition: File Prog3Library.dat in the application's working directory is opened,
        //                deserialized, and stored in _lib
        private void openLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fs = new FileStream("./Prog3Library.dat", FileMode.OpenOrCreate);
                _lib = binaryFormatter.Deserialize(fs) as Library ?? new Library();
                fs.Close();
                fs.Dispose();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"{ex.FileName} not found.");
            }
            catch (SerializationException ex)
            {
                MessageBox.Show($"Prog3Library.dat could not be deserialized.");
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Application does not have permission to access Prog3Library.dat in the application's working directory.");
            }
            catch
            {
                MessageBox.Show("An error occurred while trying to open the library.");
            }
        }

        // Precondition: File, Save Library menu item activated
        // Postcondition: Prog3Library.Dat file is created/overwritten in application's working directory
        //                and contains a serialized Library class object
        private void saveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fs = new FileStream("./Prog3Library.dat", FileMode.Create);
                binaryFormatter.Serialize(fs, _lib);
                fs.Close();
                fs.Dispose();
            }
            catch (SerializationException ex)
            {
                MessageBox.Show($"Prog3Library.dat could not be serialized.");
            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Application does not have permission to access Prog3Library.dat in the application's working directory.");
            }
            catch
            {
                MessageBox.Show("An error occurred while trying to save the library.");
            }
        }
    }
}
