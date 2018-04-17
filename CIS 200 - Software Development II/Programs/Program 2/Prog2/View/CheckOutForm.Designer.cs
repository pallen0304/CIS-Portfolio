namespace LibraryItems.View
{
   partial class CheckOutForm
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
         if(disposing&&(components!=null))
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
            this.comboBoxLibraryItem = new System.Windows.Forms.ComboBox();
            this.lblLibraryItem = new System.Windows.Forms.Label();
            this.lblPatron = new System.Windows.Forms.Label();
            this.comboBoxPatron = new System.Windows.Forms.ComboBox();
            this.CheckOutErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLibraryItem
            // 
            this.comboBoxLibraryItem.FormattingEnabled = true;
            this.comboBoxLibraryItem.Location = new System.Drawing.Point(16, 33);
            this.comboBoxLibraryItem.Name = "comboBoxLibraryItem";
            this.comboBoxLibraryItem.Size = new System.Drawing.Size(379, 24);
            this.comboBoxLibraryItem.TabIndex = 0;
            this.comboBoxLibraryItem.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxLibraryItem_Validating);
            this.comboBoxLibraryItem.Validated += new System.EventHandler(this.comboBoxLibraryItem_Validated);
            // 
            // lblLibraryItem
            // 
            this.lblLibraryItem.AutoSize = true;
            this.lblLibraryItem.Location = new System.Drawing.Point(13, 13);
            this.lblLibraryItem.Name = "lblLibraryItem";
            this.lblLibraryItem.Size = new System.Drawing.Size(86, 17);
            this.lblLibraryItem.TabIndex = 1;
            this.lblLibraryItem.Text = "Library Item:";
            // 
            // lblPatron
            // 
            this.lblPatron.AutoSize = true;
            this.lblPatron.Location = new System.Drawing.Point(13, 76);
            this.lblPatron.Name = "lblPatron";
            this.lblPatron.Size = new System.Drawing.Size(54, 17);
            this.lblPatron.TabIndex = 3;
            this.lblPatron.Text = "Patron:";
            // 
            // comboBoxPatron
            // 
            this.comboBoxPatron.FormattingEnabled = true;
            this.comboBoxPatron.Location = new System.Drawing.Point(16, 96);
            this.comboBoxPatron.Name = "comboBoxPatron";
            this.comboBoxPatron.Size = new System.Drawing.Size(379, 24);
            this.comboBoxPatron.TabIndex = 1;
            this.comboBoxPatron.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPatron_Validating);
            this.comboBoxPatron.Validated += new System.EventHandler(this.comboBoxPatron_Validated);
            // 
            // CheckOutErrorProvider
            // 
            this.CheckOutErrorProvider.ContainerControl = this;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(320, 140);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 140);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            // 
            // CheckOutForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 187);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPatron);
            this.Controls.Add(this.comboBoxPatron);
            this.Controls.Add(this.lblLibraryItem);
            this.Controls.Add(this.comboBoxLibraryItem);
            this.Name = "CheckOutForm";
            this.Text = "Check Out";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckOutForm_FormClosed);
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox comboBoxLibraryItem;
        private System.Windows.Forms.Label lblLibraryItem;
        private System.Windows.Forms.Label lblPatron;
        private System.Windows.Forms.ComboBox comboBoxPatron;
        private System.Windows.Forms.ErrorProvider CheckOutErrorProvider;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}