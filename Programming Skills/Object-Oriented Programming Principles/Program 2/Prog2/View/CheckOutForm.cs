// Program 2
// CIS 200-01
// Due Date: 03/10/2017 11:59:59PM
// By: D7611

// File: CheckOutForm.cs
// This file creates a form for checking out LibraryItems that have not yet been checked out.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryItems.View
{
    public partial class CheckOutForm : Form
    {
        private Action<int, int> CheckOut;
        // Precondition: checkOut is an action accepting the index of a LibraryItem and index of a LibraryPatron, 
        // and the indices of the original lists are synced with lists associated with the Action passed in.
        // libraryItems must contain at least one LibraryItem. patrons must contain at least one patron.
        public CheckOutForm(Action<int, int> checkOut, IList<LibraryItem> libraryItems, IList<LibraryPatron> patrons)
        {
            InitializeComponent();
            CheckOut = checkOut;

            comboBoxLibraryItem.DataSource = libraryItems.Select(o => new
            {
                DisplayText = $"{o.Title}, {o.CallNumber}",
                LibraryItem = o
            }).ToList();
            comboBoxLibraryItem.DisplayMember = "DisplayText";
            comboBoxLibraryItem.ValueMember = "LibraryItem";

            comboBoxPatron.DataSource = patrons.Select(o => new
            {
                DisplayText = $"{o.PatronName}, {o.PatronID}",
                Patron = o
            }).ToList();
            comboBoxPatron.DisplayMember = "DisplayText";
            comboBoxPatron.ValueMember = "Patron";
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            Owner?.Hide();
            this.Show();
        }

        // Precondition:  A LibraryItem has been selected to be checked out by a LibraryPatron who has also been selected.
        // Postcondition: The selected LibraryItem has been checked out by the selected LibraryPatron.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                this.Hide();
                CheckOut(comboBoxLibraryItem.SelectedIndex, comboBoxPatron.SelectedIndex);
                this.Close();
            }
        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void CheckOutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner?.Show();
        }

        private void comboBoxLibraryItem_Validated(object sender, EventArgs e)
        {
            CheckOutErrorProvider.SetError(comboBoxLibraryItem, string.Empty);
        }

        private void comboBoxLibraryItem_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckOutErrorProvider.SetError(comboBoxLibraryItem, "Must select a library item.");
        }

        private void comboBoxPatron_Validated(object sender, EventArgs e)
        {
            CheckOutErrorProvider.SetError(comboBoxPatron, string.Empty);
        }

        private void comboBoxPatron_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CheckOutErrorProvider.SetError(comboBoxPatron, "Must select a patron.");
        }
    }
}
