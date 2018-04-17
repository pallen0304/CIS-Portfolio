// Program 4
// CIS 200-01
// Due Date: 4/19/2017
// By: D7611

// File: Program.cs
// This file facilitates the execution of a Console Application using the Library class.
namespace LibraryItems
{
    using System;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            var _lib = new Library(); // Create the library
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

            // Func using an index and LibraryItem for returning a string for console use that can be used to distinctly identify LibraryItems
            // and provides information to show proof that various sorts are working.
            Func<int, LibraryItem, string> LibraryItemToString = new Func<int, LibraryItem, string>((i,li) => {
                return $"\t{i + 1} - Type: \"{li.GetType().Name}\", \n" +
                    $"\t\tCall Number: \"{li.CallNumber}\", \n" +
                    $"\t\tTitle: \"{li.Title}\", \n" +
                    $"\t\tCopyright Year: {li.CopyrightYear} ";
            });

            Console.WriteLine("Displaying Library Items before Sorting:");
            // Display members of each LibraryItem that can be used to distinctify each item
            for (int i = 0; i < _lib.GetItemCount(); i++)
                Console.WriteLine(LibraryItemToString(i, _lib.GetItemsList()[i]));

            Console.WriteLine("Sorting Library Items using their natural order:");
            _lib.GetItemsList().Sort(); //Sort the list by LibraryItem's natural order
            // Display members of each LibraryItem that can be used to distinctify each item and 
            // show proof of sorting in the order they are stored before sorting.
            for (int i = 0; i < _lib.GetItemCount(); i++)
                Console.WriteLine(LibraryItemToString(i, _lib.GetItemsList()[i]));

            Console.WriteLine("Sorting by Copyright Year in descending order:");
            _lib.GetItemsList().Sort(new LibrarySortCopyrightYearDescComparer()); // Sort the list using LibrarySortCopyrightYearDescComparer
            // Display members of each LibraryItem that can be used to distinctify each item and 
            // show proof of sorting in the order they are stored before sorting.
            for (int i = 0; i < _lib.GetItemCount(); i++)
                Console.WriteLine(LibraryItemToString(i, _lib.GetItemsList()[i]));

            Console.WriteLine("Sorting by Type of Library Item and then by Title in ascending order:");
            _lib.GetItemsList().Sort(new LibrarySortTypeTitleComparer()); // Sort the list using LibrarySortTypeTitleComparer
            // Display members of each LibraryItem that can be used to distinctify each item and 
            // show proof of sorting in the order they are stored before sorting.
            for (int i = 0; i < _lib.GetItemCount(); i++)
                Console.WriteLine(LibraryItemToString(i, _lib.GetItemsList()[i]));
        }
    }
}