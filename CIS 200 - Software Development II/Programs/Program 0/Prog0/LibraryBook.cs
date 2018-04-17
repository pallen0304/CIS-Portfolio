// Program 0
// Starting Point

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class LibraryBook
{
   // public const int DEFAULT_YEAR = 2016; // Default copyright year

   private string _title;          // The book's title
   private string _author;         // The book's author
   private string _publisher;      // The book's publisher
   private int _copyrightYear;     // The book's year of copyright
   private string _callNumber;     // The book's call number in the library
   private bool _checkedOut;       // The book's checked out status
   private LibraryPatron _patron;  //The person who has checked out this book if it is checked out.

   // Precondition:  theCopyrightYear >= 0
   // Postcondition: The library book has been initialized with the specified
   //                values for title, author, publisher, copyright year, and
   //                call number. The book is not checked out.
   public LibraryBook(string theTitle, string theAuthor, string thePublisher,
       int theCopyrightYear, string theCallNumber)
   {
      Title=theTitle;
      Author=theAuthor;
      Publisher=thePublisher;
      CopyrightYear=theCopyrightYear;
      CallNumber=theCallNumber;

      ReturnToShelf(); // Make sure book is not checked out
   }

   public string Title
   {
      // Precondition:  None
      // Postcondition: The title has been returned
      get
      {
         return _title;
      }

      // Precondition:  The value is not null or white space.
      // Postcondition: The title has been set to the specified value
      set
      {
         value=value.Trim();
         if(string.IsNullOrEmpty(value))
            throw new ArgumentOutOfRangeException("value", "Title value is empty.");
         _title=value;
      }
   }

   public string Author
   {
      // Precondition:  None
      // Postcondition: The author has been returned
      get
      {
         return _author;
      }

      // Precondition:  None
      // Postcondition: The author has been set to the specified value
      set
      {
         _author=value;
      }
   }

   public string Publisher
   {
      // Precondition:  None
      // Postcondition: The publisher has been returned
      get
      {
         return _publisher;
      }

      // Precondition:  None
      // Postcondition: The publisher has been set to the specified value
      set
      {
         _publisher=value;
      }
   }

   public int CopyrightYear
   {
      // Precondition:  None
      // Postcondition: The copyright year has been returned
      get
      {
         return _copyrightYear;
      }

      // Precondition:  value >= 0
      // Postcondition: The copyright year has been set to the specified value
      set
      {
         if(value>=0)
            _copyrightYear=value;
         else
            throw new ArgumentOutOfRangeException("value", "Copyright Year must be a positive number.");
         //_copyrightYear = DEFAULT_YEAR;
      }
   }

   public string CallNumber
   {
      // Precondition:  None
      // Postcondition: The call number has been returned
      get
      {
         return _callNumber;
      }

      // Precondition:  Call number value is not null or whitespace
      // Postcondition: The call number has been set to the specified value
      set
      {
         value=value.Trim();
         if(string.IsNullOrEmpty(value))
            throw new ArgumentOutOfRangeException("value", "Call Number value is empty.");
         _callNumber=value;
      }
   }

   // Precondition:  This book is checked out.
   // Postcondition: The patron who has checked out this book has been returned. Null is returned if the book is not checked out.
   public LibraryPatron Patron
   {
      get
      {
         return _checkedOut ? _patron : null;
      }
   }

   // Precondition:  patron is not null.
   // Postcondition: The book is checked out
   public void CheckOut(LibraryPatron patron)
   {
      _patron=patron;
      _checkedOut=true;
   }

   // Precondition:  None
   // Postcondition: The book is not checked out
   public void ReturnToShelf()
   {
      _patron=null;
      _checkedOut=false;
   }

   // Precondition:  None
   // Postcondition: true is returned if the book is checked out,
   //                otherwise false is returned
   public bool IsCheckedOut()
   {
      return _checkedOut;
   }

   // Precondition:  None
   // Postcondition: A string is returned presenting the libary book's data on
   //                separate lines
   public override string ToString()
   {
      return "Title: "+Title+System.Environment.NewLine+
          "Author: "+Author+System.Environment.NewLine+
          "Publisher: "+Publisher+System.Environment.NewLine+
          "Copyright: "+CopyrightYear.ToString("D4")+System.Environment.NewLine+
          (IsCheckedOut() ? $"Checked Out By: {Patron}" : "Not Checked Out");
   }
}