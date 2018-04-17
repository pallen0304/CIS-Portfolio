// Program 1B
// CIS 200-01
// Due: 2/22/2017
// By: D7611

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
public class Program
{
   // Precondition:  None
   // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
   public static void Main(string[] args)
   {
      const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method

      List<LibraryItem> items = new List<LibraryItem>();       // List of library items
      List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

      // Test data - Magic numbers allowed here
      items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
          "ZZ25 3G", "Andrew Wright"));
      items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
          "AB73 ZF", "IP Thief"));
      items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
          "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
          LibraryMovie.MPAARatings.PG));
      items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
          "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
      items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
          "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
      items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
          "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
      items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
          "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
      items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
          "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
      items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
          "MA53 9A", 16, 7));
      items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
          "MA53 9B", 16, 8));
      items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
          "MA53 9C", 16, 9));
      items.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2017, 14,
          "MA21 5V", 1, 1));

      // Add patrons
      patrons.Add(new LibraryPatron("Ima Reader", "12345"));
      patrons.Add(new LibraryPatron("Kathryn Janeway", "11223"));
      patrons.Add(new LibraryPatron("John Smith", "54321"));
      patrons.Add(new LibraryPatron("James T. Kirk", "98765"));
      patrons.Add(new LibraryPatron("Jean-Luc Picard", "33456"));

      Console.WriteLine("List of items at start:\n");
      foreach(LibraryItem item in items)
         Console.WriteLine("{0}\n", item);
      Pause();

      // Check out some items
      items[0].CheckOut(patrons[0]);
      items[2].CheckOut(patrons[2]);
      items[5].CheckOut(patrons[1]);
      items[4].CheckOut(patrons[3]);
      items[7].CheckOut(patrons[4]);

      // Store each item that is checked out and display them. Then display the number of items checked out
      IEnumerable<LibraryItem> checkedOutItems = items.Where(i => i.IsCheckedOut());
      foreach(LibraryItem item in checkedOutItems)
         Console.WriteLine($"{item.ToString()}\n");
      Console.WriteLine($"{checkedOutItems.Count()} item(s) checked out.\n");
      Pause();
      
      // Store each item from checkedOutItems of type LibraryMediaItem and display them.
      IEnumerable<LibraryMediaItem> checkedOutMediaItems = checkedOutItems.OfType<LibraryMediaItem>();
      checkedOutMediaItems.ToList().ForEach(o => Console.WriteLine($"{o.ToString()}\n"));
      Pause();

      // Store items of type LibraryMagazine and display the unique titles.
      IEnumerable<LibraryMagazine> distinctMagazine = items.OfType<LibraryMagazine>();
      distinctMagazine.Select(o => o.Title).Distinct().ToList().ForEach(MTitle => Console.WriteLine(MTitle));   
      Pause();   

      Console.WriteLine($"Calculated late fees after {DAYSLATE} days late:\n");
      Console.WriteLine($"{"Title",42} {"Call Number",11} {"Late Fee",8}");
      Console.WriteLine("------------------------------------------ ----------- --------");

      // Caluclate and display late fees for each item
      foreach(LibraryItem item in items)
         Console.WriteLine($"{item.Title,42} {item.CallNumber,11} {item.CalcLateFee(DAYSLATE),8:C}");
      Pause();

      // Return each item that is checked out
      foreach(LibraryItem item in items)
      {
         if(item.IsCheckedOut())
            item.ReturnToShelf();
      }
      
      Console.WriteLine("After returning all items:\n");
      foreach(LibraryItem item in items)
         Console.WriteLine($"{item}\n");
      Console.WriteLine($"\n{checkedOutItems.Count()} item(s) checked out.\n");
      Pause();

      Console.WriteLine($"{"Title":42}: {"Loan Period":14}\t{"Loan Period after":17}" );
      foreach(LibraryItem item in items)
      {
         Console.Write($"{item.Title:42}: {item.LoanPeriod:14}\t");
         item.LoanPeriod+=7;
         Console.WriteLine($"{item.LoanPeriod:14}\n");
      }
      Pause();

      foreach(LibraryItem item in items)
         Console.WriteLine($"{item}\n");
   }

   // Precondition:  None
   // Postcondition: Pauses program execution until user presses Enter and
   //                then clears the screen
   public static void Pause()
   {
      Console.WriteLine("Press Enter to Continue...");
      Console.ReadLine();

      Console.Clear(); // Clear screen
   }
}