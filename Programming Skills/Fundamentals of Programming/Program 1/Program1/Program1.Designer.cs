namespace Program1
{
    partial class Program1
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
            this.textboxSquareFeet = new System.Windows.Forms.TextBox();
            this.textboxCoats = new System.Windows.Forms.TextBox();
            this.textboxPricePerGallon = new System.Windows.Forms.TextBox();
            this.labelSquareFeet = new System.Windows.Forms.Label();
            this.labelCoats = new System.Windows.Forms.Label();
            this.labelPricePerGallon = new System.Windows.Forms.Label();
            this.textboxResults = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxSquareFeet
            // 
            this.textboxSquareFeet.Location = new System.Drawing.Point(126, 7);
            this.textboxSquareFeet.MaxLength = 9;
            this.textboxSquareFeet.Name = "textboxSquareFeet";
            this.textboxSquareFeet.ShortcutsEnabled = false;
            this.textboxSquareFeet.Size = new System.Drawing.Size(144, 22);
            this.textboxSquareFeet.TabIndex = 0;
            this.textboxSquareFeet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textboxSquareFeet.WordWrap = false;
            this.textboxSquareFeet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAsFloatingPoint_KeyPress);
            // 
            // textboxCoats
            // 
            this.textboxCoats.Location = new System.Drawing.Point(126, 36);
            this.textboxCoats.MaxLength = 2;
            this.textboxCoats.Name = "textboxCoats";
            this.textboxCoats.ShortcutsEnabled = false;
            this.textboxCoats.Size = new System.Drawing.Size(144, 22);
            this.textboxCoats.TabIndex = 1;
            this.textboxCoats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textboxCoats.WordWrap = false;
            this.textboxCoats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAsNumeric_KeyPress);
            // 
            // textboxPricePerGallon
            // 
            this.textboxPricePerGallon.Location = new System.Drawing.Point(126, 64);
            this.textboxPricePerGallon.MaxLength = 6;
            this.textboxPricePerGallon.Name = "textboxPricePerGallon";
            this.textboxPricePerGallon.ShortcutsEnabled = false;
            this.textboxPricePerGallon.Size = new System.Drawing.Size(144, 22);
            this.textboxPricePerGallon.TabIndex = 2;
            this.textboxPricePerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textboxPricePerGallon.WordWrap = false;
            this.textboxPricePerGallon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputAsFloatingPoint_KeyPress);
            // 
            // labelSquareFeet
            // 
            this.labelSquareFeet.Location = new System.Drawing.Point(3, 10);
            this.labelSquareFeet.Name = "labelSquareFeet";
            this.labelSquareFeet.Size = new System.Drawing.Size(119, 17);
            this.labelSquareFeet.TabIndex = 3;
            this.labelSquareFeet.Text = "Square Feet:";
            this.labelSquareFeet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCoats
            // 
            this.labelCoats.Location = new System.Drawing.Point(3, 39);
            this.labelCoats.Name = "labelCoats";
            this.labelCoats.Size = new System.Drawing.Size(119, 17);
            this.labelCoats.TabIndex = 4;
            this.labelCoats.Text = "Coats of Paint:";
            this.labelCoats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPricePerGallon
            // 
            this.labelPricePerGallon.Location = new System.Drawing.Point(3, 67);
            this.labelPricePerGallon.Name = "labelPricePerGallon";
            this.labelPricePerGallon.Size = new System.Drawing.Size(119, 17);
            this.labelPricePerGallon.TabIndex = 5;
            this.labelPricePerGallon.Text = "Price per Gallon:";
            this.labelPricePerGallon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxResults
            // 
            this.textboxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxResults.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.textboxResults.Enabled = false;
            this.textboxResults.Location = new System.Drawing.Point(276, 3);
            this.textboxResults.MinimumSize = new System.Drawing.Size(212, 115);
            this.textboxResults.Multiline = true;
            this.textboxResults.Name = "textboxResults";
            this.textboxResults.ReadOnly = true;
            this.textboxResults.ShortcutsEnabled = false;
            this.textboxResults.Size = new System.Drawing.Size(212, 115);
            this.textboxResults.TabIndex = 6;
            this.textboxResults.TabStop = false;
            this.textboxResults.WordWrap = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(126, 92);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(144, 27);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Estimate Paint Job";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Program1
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 123);
            this.Controls.Add(this.textboxResults);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelPricePerGallon);
            this.Controls.Add(this.labelCoats);
            this.Controls.Add(this.labelSquareFeet);
            this.Controls.Add(this.textboxPricePerGallon);
            this.Controls.Add(this.textboxCoats);
            this.Controls.Add(this.textboxSquareFeet);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(506, 170);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(506, 170);
            this.Name = "Program1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxSquareFeet;
        private System.Windows.Forms.TextBox textboxCoats;
        private System.Windows.Forms.TextBox textboxPricePerGallon;
        private System.Windows.Forms.Label labelSquareFeet;
        private System.Windows.Forms.Label labelCoats;
        private System.Windows.Forms.Label labelPricePerGallon;
        private System.Windows.Forms.TextBox textboxResults;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

