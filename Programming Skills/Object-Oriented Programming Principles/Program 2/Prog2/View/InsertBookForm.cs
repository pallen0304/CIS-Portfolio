// Program 2
// CIS 200-01
// Due Date: 03/10/2017 11:59:59PM
// By: D7611

// File: InsertBookForm.cs
// This file creates a form for entering details for creating a new LibraryBook object.
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace LibraryItems.View
{
    public partial class InsertBookForm : Form
    {
        private Action<string, string, int, int, string, string> InsertBook;
        // Precondition: insertBook is an action accepting the parameters for a LibraryBook constructor.
        public InsertBookForm(Action<string, string, int, int, string, string> insertBook)
        {
            InitializeComponent();
            InsertBook = insertBook;
        }
        
        private void InsertBookForm_Load(object sender, EventArgs e)
        {
            Owner?.Hide();
            this.Show();
        }

        private void InsertBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner?.Show();
        }

        // Precondition:  All required fields have been validated.
        // Postcondition: The action passed in to the constructor of this form has been executed successfully.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())// if all input is valid
            {
                this.Hide(); // hide main window
                InsertBook(txtBookTitle.Text, txtBookPublisher.Text, int.Parse(txtBookCopyrightYear.Text), int.Parse(txtBookLoanPeriod.Text), txtBookCallNumber.Text, txtBookAuthor.Text);
                this.Close(); // exit the application
            } // end else
        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void txtBookTitle_Validated(object sender, EventArgs e)
        {
            InsertBookErrorProvider.SetError(txtBookTitle, string.Empty);
        }

        private void txtBookTitle_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtBookTitle.Text = txtBookTitle.Text.Trim()))//Is not valid?
            {
                InsertBookErrorProvider.SetError(txtBookTitle, "Title must not be empty."); //Set focus to and error message for the control.
                e.Cancel = true;
            }
        }

        private void txtBookPublisher_Validated(object sender, EventArgs e)
        {
            InsertBookErrorProvider.SetError(txtBookPublisher, string.Empty);
        }

        private void txtBookPublisher_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtBookPublisher.Text = txtBookPublisher.Text.Trim()))//Is not valid?
            {
                InsertBookErrorProvider.SetError(txtBookPublisher, "Publisher must not be empty"); //Set focus to and error message for the control.
                e.Cancel = true;
            }
        }

        private void txtBookCopyrightYear_Validated(object sender, EventArgs e)
        {
            InsertBookErrorProvider.SetError(txtBookCopyrightYear, string.Empty);
        }

        private void txtBookCopyrightYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!Regex.IsMatch(txtBookCopyrightYear.Text, @"^[0-9]+$") || (Regex.IsMatch(txtBookCopyrightYear.Text, @"^[0-9]+$") && int.Parse(txtBookCopyrightYear.Text) < 0))//Is not valid?
            {
                InsertBookErrorProvider.SetError(txtBookCopyrightYear, "Copyright Year must be a positive number");//Set focus to and error message for the control.
                e.Cancel = true;
            }
        }

        private void txtBookLoanPeriod_Validated(object sender, EventArgs e)
        {
            InsertBookErrorProvider.SetError(txtBookLoanPeriod, string.Empty);
        }

        private void txtBookLoanPeriod_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!Regex.IsMatch(txtBookLoanPeriod.Text, @"^[0-9]+$") || (Regex.IsMatch(txtBookLoanPeriod.Text, @"^[0-9]+$") && int.Parse(txtBookLoanPeriod.Text) < 0))//Is not valid?
            {
                InsertBookErrorProvider.SetError(txtBookLoanPeriod, "Loan Period must be a positive number");//Set focus to and error message for the control.
                e.Cancel = true;
            }
        }

        private void txtBookCallNumber_Validated(object sender, EventArgs e)
        {
            InsertBookErrorProvider.SetError(txtBookCallNumber, string.Empty);
        }

        private void txtBookCallNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtBookCallNumber.Text = txtBookCallNumber.Text.Trim()))//Is not valid?
            {
                InsertBookErrorProvider.SetError(txtBookCallNumber, "Call Number must not be empty"); //Set focus to and error message for the control.
                e.Cancel = true;
            }
        }

        private void txtBookAuthor_Validated(object sender, EventArgs e)
        {
            InsertBookErrorProvider.SetError(txtBookAuthor, string.Empty);
        }

        private void txtBookAuthor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtBookAuthor.Text = txtBookAuthor.Text.Trim()))//Is not valid?
            {
                InsertBookErrorProvider.SetError(txtBookAuthor, "Author must not be empty"); //Set focus to and error message for the control.
                e.Cancel = true;
            }
        }
    }
}
