using System;

namespace LibraryItems.View
{
    partial class InsertBookForm
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
            if(disposing && (components != null))
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
            this.components = new System.ComponentModel.Container();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.lblBookCopyrightYear = new System.Windows.Forms.Label();
            this.txtBookCopyrightYear = new System.Windows.Forms.TextBox();
            this.lblBookLoanPeriod = new System.Windows.Forms.Label();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookCallNumber = new System.Windows.Forms.Label();
            this.txtBookLoanPeriod = new System.Windows.Forms.TextBox();
            this.txtBookCallNumber = new System.Windows.Forms.TextBox();
            this.InsertBookErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InsertBookErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 208);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(27, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(127, 30);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(128, 22);
            this.txtBookTitle.TabIndex = 0;
            this.txtBookTitle.WordWrap = false;
            this.txtBookTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookTitle_Validating);
            this.txtBookTitle.Validated += new System.EventHandler(this.txtBookTitle_Validated);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.Location = new System.Drawing.Point(12, 29);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(109, 22);
            this.lblBookTitle.TabIndex = 3;
            this.lblBookTitle.Text = "Title";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.Location = new System.Drawing.Point(12, 57);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(109, 22);
            this.lblBookPublisher.TabIndex = 5;
            this.lblBookPublisher.Text = "Publisher";
            this.lblBookPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookPublisher
            // 
            this.txtBookPublisher.Location = new System.Drawing.Point(127, 57);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(128, 22);
            this.txtBookPublisher.TabIndex = 1;
            this.txtBookPublisher.WordWrap = false;
            this.txtBookPublisher.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookPublisher_Validating);
            this.txtBookPublisher.Validated += new System.EventHandler(this.txtBookPublisher_Validated);
            // 
            // lblBookCopyrightYear
            // 
            this.lblBookCopyrightYear.Location = new System.Drawing.Point(12, 85);
            this.lblBookCopyrightYear.Name = "lblBookCopyrightYear";
            this.lblBookCopyrightYear.Size = new System.Drawing.Size(109, 22);
            this.lblBookCopyrightYear.TabIndex = 7;
            this.lblBookCopyrightYear.Text = "Copyright Year";
            this.lblBookCopyrightYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookCopyrightYear
            // 
            this.txtBookCopyrightYear.Location = new System.Drawing.Point(127, 86);
            this.txtBookCopyrightYear.Name = "txtBookCopyrightYear";
            this.txtBookCopyrightYear.Size = new System.Drawing.Size(128, 22);
            this.txtBookCopyrightYear.TabIndex = 2;
            this.txtBookCopyrightYear.WordWrap = false;
            this.txtBookCopyrightYear.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookCopyrightYear_Validating);
            this.txtBookCopyrightYear.Validated += new System.EventHandler(this.txtBookCopyrightYear_Validated);
            // 
            // lblBookLoanPeriod
            // 
            this.lblBookLoanPeriod.Location = new System.Drawing.Point(12, 113);
            this.lblBookLoanPeriod.Name = "lblBookLoanPeriod";
            this.lblBookLoanPeriod.Size = new System.Drawing.Size(109, 22);
            this.lblBookLoanPeriod.TabIndex = 9;
            this.lblBookLoanPeriod.Text = "Loan Period";
            this.lblBookLoanPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.Location = new System.Drawing.Point(12, 169);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(109, 22);
            this.lblBookAuthor.TabIndex = 11;
            this.lblBookAuthor.Text = "Author";
            this.lblBookAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(127, 169);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(128, 22);
            this.txtBookAuthor.TabIndex = 5;
            this.txtBookAuthor.WordWrap = false;
            this.txtBookAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookAuthor_Validating);
            this.txtBookAuthor.Validated += new System.EventHandler(this.txtBookAuthor_Validated);
            // 
            // lblBookCallNumber
            // 
            this.lblBookCallNumber.Location = new System.Drawing.Point(12, 141);
            this.lblBookCallNumber.Name = "lblBookCallNumber";
            this.lblBookCallNumber.Size = new System.Drawing.Size(109, 22);
            this.lblBookCallNumber.TabIndex = 14;
            this.lblBookCallNumber.Text = "Call Number";
            this.lblBookCallNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBookLoanPeriod
            // 
            this.txtBookLoanPeriod.Location = new System.Drawing.Point(127, 113);
            this.txtBookLoanPeriod.Name = "txtBookLoanPeriod";
            this.txtBookLoanPeriod.Size = new System.Drawing.Size(128, 22);
            this.txtBookLoanPeriod.TabIndex = 3;
            this.txtBookLoanPeriod.WordWrap = false;
            this.txtBookLoanPeriod.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookLoanPeriod_Validating);
            this.txtBookLoanPeriod.Validated += new System.EventHandler(this.txtBookLoanPeriod_Validated);
            // 
            // txtBookCallNumber
            // 
            this.txtBookCallNumber.Location = new System.Drawing.Point(127, 141);
            this.txtBookCallNumber.Name = "txtBookCallNumber";
            this.txtBookCallNumber.Size = new System.Drawing.Size(128, 22);
            this.txtBookCallNumber.TabIndex = 4;
            this.txtBookCallNumber.WordWrap = false;
            this.txtBookCallNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookCallNumber_Validating);
            this.txtBookCallNumber.Validated += new System.EventHandler(this.txtBookCallNumber_Validated);
            // 
            // InsertBookErrorProvider
            // 
            this.InsertBookErrorProvider.BlinkRate = 150;
            this.InsertBookErrorProvider.ContainerControl = this;
            // 
            // InsertBookForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(299, 248);
            this.ControlBox = false;
            this.Controls.Add(this.txtBookCallNumber);
            this.Controls.Add(this.txtBookLoanPeriod);
            this.Controls.Add(this.lblBookCallNumber);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.lblBookLoanPeriod);
            this.Controls.Add(this.lblBookCopyrightYear);
            this.Controls.Add(this.txtBookCopyrightYear);
            this.Controls.Add(this.lblBookPublisher);
            this.Controls.Add(this.txtBookPublisher);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.txtBookTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "InsertBookForm";
            this.Text = "New Book";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InsertBookForm_FormClosed);
            this.Load += new System.EventHandler(this.InsertBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InsertBookErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.Label lblBookCopyrightYear;
        private System.Windows.Forms.TextBox txtBookCopyrightYear;
        private System.Windows.Forms.Label lblBookLoanPeriod;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookCallNumber;
        private System.Windows.Forms.TextBox txtBookLoanPeriod;
        private System.Windows.Forms.TextBox txtBookCallNumber;
        private System.Windows.Forms.ErrorProvider InsertBookErrorProvider;
    }
}