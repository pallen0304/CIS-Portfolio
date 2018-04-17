// Program 2
// CIS 200-01
// Due Date: 03/10/2017 11:59:59PM
// By: D7611

// File: InsertPatronForm.cs
// This file creates a form for entering details to create a new LibraryPatron object.
using System;
using System.Windows.Forms;

namespace LibraryItems.View
{
    public partial class InsertPatronForm : Form
    {
        private Action<string, string> InsertPatron;

        // Precondition: insertPatron is an action accepting the parameters for a LibraryPatron constructor.
        public InsertPatronForm(Action<string, string> insertPatron)
        {
            InitializeComponent();
            InsertPatron = insertPatron;
        }


        // Precondition:  All required fields have been validated.
        // Postcondition: The action passed in to the constructor of this form has been executed successfully.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())// if all input is valid
            {
                this.Hide(); // hide main window
                InsertPatron(txtPatronName.Text, txtPatronID.Text);
                this.Close(); // exit the application
            } // end else   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InsertPatronForm_Load(object sender, EventArgs e)
        {
            Owner?.Hide();
            this.Show();
        }

        private void InsertPatronForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner?.Show();
        }

        private void txtPatronName_Validated(object sender, EventArgs e)
        {
            insertPatronErrorProvider.SetError(txtPatronName, string.Empty);
        }

        private void txtPatronName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPatronName.Text = txtPatronName.Text.Trim()))//Is not valid?
            {
                insertPatronErrorProvider.SetError(txtPatronName, "Patron Name must not be empty"); //Set focus to and error message for the control.
                e.Cancel = true;
            }
        }

        private void txtPatronID_Validated(object sender, EventArgs e)
        {
            insertPatronErrorProvider.SetError(txtPatronID, string.Empty);
        }

        private void txtPatronID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPatronID.Text = txtPatronID.Text.Trim()))//Is not valid?
            {
                insertPatronErrorProvider.SetError(txtPatronID, "Patron ID must not be empty"); //Set focus to and error message for the control.
                e.Cancel = true;
            }
        }

    }
}
