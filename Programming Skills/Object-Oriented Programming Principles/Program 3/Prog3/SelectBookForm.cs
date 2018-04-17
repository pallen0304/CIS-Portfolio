using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class SelectBookForm : Form
    {
        private List<LibraryBook> _books; // List of library books

        internal int BookIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected book combo box has been returned
            get
            {
                return bookCbo.SelectedIndex;
            }
        }

        public SelectBookForm(List<LibraryBook> bookList)
        {
            _books = bookList;
            InitializeComponent();
        }

        private void SelectBook_Load(object sender, EventArgs e)
        {
            foreach (LibraryBook book in _books)
                bookCbo.Items.Add(book.Title + ", " + book.CallNumber);
        }


        // Precondition:  Focus is shifting from bookCbo
        // Postcondition: If selection is invalid, focus remains and error provider
        //                highlights the field
        private void bookCbo_Validating(object sender, CancelEventArgs e)
        {
            if (bookCbo.SelectedIndex == -1) // Nothing selected
            {
                e.Cancel = true;
                errorProvider.SetError(bookCbo, "Must select Book");
            }
        }

        // Precondition:  Validating of bookCbo not cancelled, so data OK
        // Postcondition: Error provider cleared and focus allowed to change
        private void bookCbo_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(bookCbo, "");
        }
        
        // Precondition:  User pressed on cancelBtn
        // Postcondition: Form closes and sends Cancel result
        private void cancelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }

        // Precondition:  User clicked on okBtn
        // Postcondition: If invalid field on dialog, keep form open and give first invalid
        //                field the focus. Else return OK and close form.
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) // If all controls validate
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result
        }
    }
}
