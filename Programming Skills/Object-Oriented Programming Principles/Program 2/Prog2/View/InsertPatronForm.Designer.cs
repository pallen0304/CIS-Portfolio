namespace LibraryItems.View
{
    partial class InsertPatronForm
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
            this.txtPatronName = new System.Windows.Forms.TextBox();
            this.lblPatronName = new System.Windows.Forms.Label();
            this.lblPatronID = new System.Windows.Forms.Label();
            this.txtPatronID = new System.Windows.Forms.TextBox();
            this.insertPatronErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.insertPatronErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 67);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(15, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPatronName
            // 
            this.txtPatronName.Location = new System.Drawing.Point(127, 12);
            this.txtPatronName.Name = "txtPatronName";
            this.txtPatronName.Size = new System.Drawing.Size(128, 22);
            this.txtPatronName.TabIndex = 0;
            this.txtPatronName.WordWrap = false;
            this.txtPatronName.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatronName_Validating);
            this.txtPatronName.Validated += new System.EventHandler(this.txtPatronName_Validated);
            // 
            // lblPatronName
            // 
            this.lblPatronName.Location = new System.Drawing.Point(12, 12);
            this.lblPatronName.Name = "lblPatronName";
            this.lblPatronName.Size = new System.Drawing.Size(75, 22);
            this.lblPatronName.TabIndex = 3;
            this.lblPatronName.Text = "Name";
            this.lblPatronName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPatronID
            // 
            this.lblPatronID.Location = new System.Drawing.Point(12, 40);
            this.lblPatronID.Name = "lblPatronID";
            this.lblPatronID.Size = new System.Drawing.Size(75, 22);
            this.lblPatronID.TabIndex = 5;
            this.lblPatronID.Text = "ID";
            this.lblPatronID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPatronID
            // 
            this.txtPatronID.Location = new System.Drawing.Point(127, 40);
            this.txtPatronID.Name = "txtPatronID";
            this.txtPatronID.Size = new System.Drawing.Size(128, 22);
            this.txtPatronID.TabIndex = 1;
            this.txtPatronID.WordWrap = false;
            this.txtPatronID.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatronID_Validating);
            this.txtPatronID.Validated += new System.EventHandler(this.txtPatronID_Validated);
            // 
            // insertPatronErrorProvider
            // 
            this.insertPatronErrorProvider.BlinkRate = 150;
            this.insertPatronErrorProvider.ContainerControl = this;
            // 
            // InsertPatronForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(289, 107);
            this.ControlBox = false;
            this.Controls.Add(this.lblPatronID);
            this.Controls.Add(this.txtPatronID);
            this.Controls.Add(this.lblPatronName);
            this.Controls.Add(this.txtPatronName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Name = "InsertPatronForm";
            this.Text = "New Patron";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InsertPatronForm_FormClosed);
            this.Load += new System.EventHandler(this.InsertPatronForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insertPatronErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPatronName;
        private System.Windows.Forms.Label lblPatronName;
        private System.Windows.Forms.Label lblPatronID;
        private System.Windows.Forms.TextBox txtPatronID;
        private System.Windows.Forms.ErrorProvider insertPatronErrorProvider;
    }
}