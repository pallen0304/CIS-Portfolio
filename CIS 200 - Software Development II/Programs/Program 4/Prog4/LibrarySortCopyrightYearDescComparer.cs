// Program 4
// CIS 200-01
// Due Date: 4/19/2017
// By: D7611

// File: LibrarySortCopyrightYearDescComparer.cs
// This class is used as a Comparer for LibraryItem objects. It returns whether 
// the first parameter passed in should appear before or after the second parameter 
// or if the order should not be changed by comparing the copyright year in descending order.
namespace LibraryItems
{
    using System.Collections.Generic;
    public class LibrarySortCopyrightYearDescComparer : IComparer<LibraryItem>
    {
        public int Compare(LibraryItem x, LibraryItem y)
        {
            return x == null && y == null ? 0 :
                -(x == null ? -1 :
                y == null ? 1 :
                x.CopyrightYear.CompareTo(y.CopyrightYear));
        }
    }
}
