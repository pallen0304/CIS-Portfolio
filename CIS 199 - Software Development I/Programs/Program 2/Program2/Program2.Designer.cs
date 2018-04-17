using System;

namespace Program2
{
    partial class Program2
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelEarliestTimeOfRegistration = new System.Windows.Forms.Label();
            this.lblCreditHours = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textboxLastName = new System.Windows.Forms.TextBox();
            this.textboxCreditHours = new System.Windows.Forms.TextBox();
            this.panelLabels = new System.Windows.Forms.Panel();
            this.panelTextboxes = new System.Windows.Forms.Panel();
            this.panelLabels.SuspendLayout();
            this.panelTextboxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(0, 75);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(778, 28);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelEarliestTimeOfRegistration
            // 
            this.labelEarliestTimeOfRegistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelEarliestTimeOfRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarliestTimeOfRegistration.Location = new System.Drawing.Point(0, 52);
            this.labelEarliestTimeOfRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.labelEarliestTimeOfRegistration.Name = "labelEarliestTimeOfRegistration";
            this.labelEarliestTimeOfRegistration.Size = new System.Drawing.Size(778, 23);
            this.labelEarliestTimeOfRegistration.TabIndex = 1;
            // 
            // lblCreditHours
            // 
            this.lblCreditHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreditHours.Location = new System.Drawing.Point(0, 25);
            this.lblCreditHours.Margin = new System.Windows.Forms.Padding(4);
            this.lblCreditHours.Name = "lblCreditHours";
            this.lblCreditHours.Size = new System.Drawing.Size(105, 25);
            this.lblCreditHours.TabIndex = 2;
            this.lblCreditHours.Text = "Credit Hours: ";
            this.lblCreditHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastName.Location = new System.Drawing.Point(0, 0);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(105, 25);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name: ";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textboxLastName
            // 
            this.textboxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxLastName.Location = new System.Drawing.Point(0, 0);
            this.textboxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxLastName.Name = "textboxLastName";
            this.textboxLastName.ShortcutsEnabled = false;
            this.textboxLastName.Size = new System.Drawing.Size(673, 25);
            this.textboxLastName.TabIndex = 4;
            this.textboxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxLastName_KeyPress);
            // 
            // textboxCreditHours
            // 
            this.textboxCreditHours.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textboxCreditHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxCreditHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxCreditHours.Location = new System.Drawing.Point(0, 25);
            this.textboxCreditHours.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCreditHours.Name = "textboxCreditHours";
            this.textboxCreditHours.ShortcutsEnabled = false;
            this.textboxCreditHours.Size = new System.Drawing.Size(673, 25);
            this.textboxCreditHours.TabIndex = 5;
            this.textboxCreditHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxCreditHours_KeyPress);
            // 
            // panelLabels
            // 
            this.panelLabels.Controls.Add(this.lblCreditHours);
            this.panelLabels.Controls.Add(this.lblLastName);
            this.panelLabels.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLabels.Location = new System.Drawing.Point(0, 0);
            this.panelLabels.Name = "panelLabels";
            this.panelLabels.Size = new System.Drawing.Size(105, 52);
            this.panelLabels.TabIndex = 6;
            // 
            // panelTextboxes
            // 
            this.panelTextboxes.Controls.Add(this.textboxCreditHours);
            this.panelTextboxes.Controls.Add(this.textboxLastName);
            this.panelTextboxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTextboxes.Location = new System.Drawing.Point(105, 0);
            this.panelTextboxes.Name = "panelTextboxes";
            this.panelTextboxes.Size = new System.Drawing.Size(673, 52);
            this.panelTextboxes.TabIndex = 7;
            // 
            // Program2
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 103);
            this.Controls.Add(this.panelTextboxes);
            this.Controls.Add(this.panelLabels);
            this.Controls.Add(this.labelEarliestTimeOfRegistration);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(780, 150);
            this.Name = "Program2";
            this.Text = "Program 2";
            this.panelLabels.ResumeLayout(false);
            this.panelTextboxes.ResumeLayout(false);
            this.panelTextboxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelEarliestTimeOfRegistration;
        private System.Windows.Forms.Label lblCreditHours;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textboxLastName;
        private System.Windows.Forms.TextBox textboxCreditHours;
        private System.Windows.Forms.Panel panelLabels;
        private System.Windows.Forms.Panel panelTextboxes;
    }
}

