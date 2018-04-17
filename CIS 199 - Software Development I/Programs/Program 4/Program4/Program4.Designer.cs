namespace Program4
{
    partial class Program4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstboxLibrary = new System.Windows.Forms.ListBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReturnToShelf = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtCopyrightYear = new System.Windows.Forms.TextBox();
            this.lblCopyrightYear = new System.Windows.Forms.Label();
            this.txtCallNumber = new System.Windows.Forms.TextBox();
            this.lblCallNumber = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstboxLibrary
            // 
            this.lstboxLibrary.FormattingEnabled = true;
            this.lstboxLibrary.ItemHeight = 16;
            this.lstboxLibrary.Location = new System.Drawing.Point(254, 8);
            this.lstboxLibrary.Name = "lstboxLibrary";
            this.lstboxLibrary.Size = new System.Drawing.Size(167, 148);
            this.lstboxLibrary.TabIndex = 6;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(427, 8);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(117, 40);
            this.btnDetails.TabIndex = 7;
            this.btnDetails.Text = "&Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(427, 58);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(117, 40);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "&Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnReturnToShelf
            // 
            this.btnReturnToShelf.Location = new System.Drawing.Point(427, 105);
            this.btnReturnToShelf.Name = "btnReturnToShelf";
            this.btnReturnToShelf.Size = new System.Drawing.Size(117, 40);
            this.btnReturnToShelf.TabIndex = 9;
            this.btnReturnToShelf.Text = "&Return to Shelf";
            this.btnReturnToShelf.UseVisualStyleBackColor = true;
            this.btnReturnToShelf.Click += new System.EventHandler(this.btnReturnToShelf_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(13, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(125, 8);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(123, 22);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(125, 31);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(123, 22);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(13, 30);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(106, 23);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(125, 54);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(123, 22);
            this.txtPublisher.TabIndex = 2;
            // 
            // lblPublisher
            // 
            this.lblPublisher.Location = new System.Drawing.Point(12, 53);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(106, 23);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "Publisher";
            this.lblPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCopyrightYear
            // 
            this.txtCopyrightYear.Location = new System.Drawing.Point(125, 77);
            this.txtCopyrightYear.Name = "txtCopyrightYear";
            this.txtCopyrightYear.Size = new System.Drawing.Size(123, 22);
            this.txtCopyrightYear.TabIndex = 3;
            // 
            // lblCopyrightYear
            // 
            this.lblCopyrightYear.Location = new System.Drawing.Point(13, 76);
            this.lblCopyrightYear.Name = "lblCopyrightYear";
            this.lblCopyrightYear.Size = new System.Drawing.Size(106, 23);
            this.lblCopyrightYear.TabIndex = 10;
            this.lblCopyrightYear.Text = "Copyright Year";
            this.lblCopyrightYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCallNumber
            // 
            this.txtCallNumber.Location = new System.Drawing.Point(125, 100);
            this.txtCallNumber.Name = "txtCallNumber";
            this.txtCallNumber.Size = new System.Drawing.Size(123, 22);
            this.txtCallNumber.TabIndex = 4;
            // 
            // lblCallNumber
            // 
            this.lblCallNumber.Location = new System.Drawing.Point(13, 99);
            this.lblCallNumber.Name = "lblCallNumber";
            this.lblCallNumber.Size = new System.Drawing.Size(106, 23);
            this.lblCallNumber.TabIndex = 12;
            this.lblCallNumber.Text = "Call Number";
            this.lblCallNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(124, 128);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(123, 30);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "&Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // LibraryBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 163);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.txtCallNumber);
            this.Controls.Add(this.lblCallNumber);
            this.Controls.Add(this.txtCopyrightYear);
            this.Controls.Add(this.lblCopyrightYear);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturnToShelf);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lstboxLibrary);
            this.Name = "LibraryBookForm";
            this.Text = "Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxLibrary;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReturnToShelf;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtCopyrightYear;
        private System.Windows.Forms.Label lblCopyrightYear;
        private System.Windows.Forms.TextBox txtCallNumber;
        private System.Windows.Forms.Label lblCallNumber;
        private System.Windows.Forms.Button btnAddBook;
    }
}

