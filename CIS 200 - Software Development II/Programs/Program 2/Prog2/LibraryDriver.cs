// Program 2
// CIS 200-01
// Due Date: 03/10/2017 11:59:59PM
// By: D7611

// File: LibraryDriver.cs
// This file creates a Driver class for the Library class. 
// It faciliates the interaction between a user and the members of the Library class object.
namespace LibraryItems
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;
    using View;
    public partial class LibraryDriver : Form
    {
        public LibraryDriver()
        {
            InitializeComponent();
        }

        private Library _library;

        public Library Library
        {
            get
            {
                return _library ?? (Library = new Library());
            }

            set
            {
                this._library = value;
            }
        }

        private void LibraryDriver_Load(object sender, EventArgs e)
        {
            /*
            // Test data - Magic numbers allowed here
            Library.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
                "ZZ25 3G", "Andrew Wright");
            Library.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
                "AB73 ZF", "IP Thief");
            //Library.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            //    "MM33 2D", "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            //    LibraryMovie.MPAARatings.PG);
            //Library.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            //    "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            //Library.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            //    "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            //Library.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            //    "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            //Library.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            //    "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            //Library.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            //    "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            //Library.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            //    "MA53 9A", 16, 7);
            //Library.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            //    "MA53 9B", 16, 8);
            //Library.AddLibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            //    "MA53 9C", 16, 9);
            //Library.AddLibraryMagazine("VB Magazine", "UofL Mags", 2017, 14,
            //    "MA21 5V", 1, 1);

            // Add patrons
            Library.AddPatron("Ima Reader", "12345");
            Library.AddPatron("Kathryn Janeway", "11223");
            Library.AddPatron("John Smith", "54321");
            Library.AddPatron("James T. Kirk", "98765");
            Library.AddPatron("Jean-Luc Picard", "33456");*/
        }

        private void fileAboutMenuItem_Click(object sender, EventArgs e)
        {
            string nl = Environment.NewLine;
            MessageBox.Show($"Grading ID: D7611{nl}Program Number: 2{nl}Due Date: 03/09/2017{nl}Copyright 2017 CIS 200-01-4172", "About");
        }
        private void fileExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertPatronMenuItem_Click(object sender, EventArgs e)
        {
            new InsertPatronForm(Library.AddPatron).Show(this);
        }
        private void insertBookMenuItem_Click(object sender, EventArgs e)
        {
            new InsertBookForm(Library.AddLibraryBook).Show(this);
        }

        private void itemCheckOutMenuItem_Click(object sender, EventArgs e)
        {
            IList<LibraryItem> uncheckedOutItems = Library.GetItemsList().Where(o => !o.IsCheckedOut()).ToList(); //LibraryItems in Library that have not been checked out yet
            IList<LibraryPatron> patrons = Library.GetPatronsList();//All patrons in Library
            bool hasUncheckedOutItems = uncheckedOutItems.Count > 0;
            bool hasPatrons = patrons.Count > 0;
            bool canDoCheckOut = hasUncheckedOutItems && hasPatrons;
            if(!canDoCheckOut)
                MessageBox.Show(hasUncheckedOutItems ? (hasPatrons ? "" : "The Library has no patrons.") : "The Library has no items available for check out." + (hasPatrons ? "" : $"{Environment.NewLine}The Library has no patrons."));
            else
                new CheckOutForm(Library.CheckOut, uncheckedOutItems, patrons).Show(this);
        }
        private void itemReturnMenuItem_Click(object sender, EventArgs e)
        {
            IList<LibraryItem> checkedOutItems = Library.GetItemsList().Where(o => o.IsCheckedOut()).ToList(); //LibraryItems in Library that have not been checked out yet
            bool hasCheckedOutItems = checkedOutItems.Count > 0;
            if(!hasCheckedOutItems)
                MessageBox.Show("The Library has no items checked out.");
            else
                new ReturnForm(Library.ReturnToShelf, checkedOutItems).Show(this);

        }

        private void reportPatronListMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons = Library.GetPatronsList();
            dataGridViewReport.DataSource = patrons.Select(o => $"{o.PatronName}, {o.PatronID}").ToList<object>();
            txtReportItemCount.Text = $"The Library has {patrons.Count()} patron(s).";
            this.Width = 400;
        }
        private void reportItemListMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> libraryItems = Library.GetItemsList();
            dataGridViewReport.DataSource = libraryItems.Select(li =>
            new
            {
                Title = li.Title,
                Publisher = li.Publisher,
                CopyrightYear = li.CopyrightYear,
                CallNumber = li.CallNumber,
                LoanPeriod = li.LoanPeriod,
                CheckedOut = li.IsCheckedOut(),
                Patron = li.Patron?.PatronName,
            }).ToList<object>();
            txtReportItemCount.Text = $"The Library has {libraryItems.Count()} Library Item(s).";
            this.Width = dataGridViewReport.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dataGridViewReport.RowHeadersWidth + dataGridViewReport.Columns.Count * 3;
        }
        private void reportCheckedOutItemsMenuItem_Click(object sender, EventArgs e)
        {
            List<object> checkedOutLibraryItems = Library.GetItemsList().Where(o => o.IsCheckedOut()).Select(li =>
            new
            {
                Title = li.Title,
                Publisher = li.Publisher,
                CopyrightYear = li.CopyrightYear,
                CallNumber = li.CallNumber,
                LoanPeriod = li.LoanPeriod,
                CheckedOut = li.IsCheckedOut(),
                Patron = li.Patron?.PatronName,
            }).ToList<object>();
            dataGridViewReport.DataSource = checkedOutLibraryItems;
            txtReportItemCount.Text = $"The Library has {checkedOutLibraryItems.Count()} Library Item(s) checked out.";
            dataGridViewReport.Refresh();
            this.Width = dataGridViewReport.Columns.GetColumnsWidth(DataGridViewElementStates.None) + dataGridViewReport.RowHeadersWidth + dataGridViewReport.Columns.Count * 3;
        }
    }
}
