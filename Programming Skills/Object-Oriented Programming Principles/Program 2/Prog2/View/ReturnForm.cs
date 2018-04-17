// Program 2
// CIS 200-01
// Due Date: 03/10/2017 11:59:59PM
// By: D7611

// File: ReturnForm.cs
// This file creates a form for returning LibraryItems that have been checked out.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LibraryItems.View
{
    public partial class ReturnForm : Form
    {
        private Action<int> ReturnToShelf;
        // Precondition: returnToShelf is an action accepting the index of a LibraryItem, and the index of the original list is synced with the libraryItems object.
        public ReturnForm(Action<int> returnToShelf, IList<LibraryItem> libraryItems)
        {
            InitializeComponent();
            ReturnToShelf = returnToShelf;
            comboBoxLibraryItem.DataSource = libraryItems.Select(o => new
            {
                DisplayText = $"{o.Title}, {o.CallNumber}",
                LibraryItem = o
            }).ToList();
            comboBoxLibraryItem.DisplayMember = "DisplayText";
            comboBoxLibraryItem.ValueMember = "LibraryItem";
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            Owner?.Hide();
            this.Show();
        }

        // Precondition:  A LibraryItem has been selected to be returned to shelf.
        // Postcondition: The selected LibraryItem has been returned.
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren())
            {
                this.Hide();
                ReturnToShelf(comboBoxLibraryItem.SelectedIndex);
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
    }
}
