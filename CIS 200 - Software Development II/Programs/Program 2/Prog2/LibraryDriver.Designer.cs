namespace LibraryItems
{
    partial class LibraryDriver
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
            if (disposing && (components != null))
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
            this.LibraryMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patronListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedOutItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.txtReportItemCount = new System.Windows.Forms.TextBox();
            this.LibraryMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // LibraryMenu
            // 
            this.LibraryMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LibraryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.insertToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.LibraryMenu.Location = new System.Drawing.Point(0, 0);
            this.LibraryMenu.Name = "LibraryMenu";
            this.LibraryMenu.Size = new System.Drawing.Size(511, 28);
            this.LibraryMenu.TabIndex = 1;
            this.LibraryMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.fileAboutMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.fileExitMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronToolStripMenuItem,
            this.bookToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.insertToolStripMenuItem.Text = "&Insert";
            // 
            // patronToolStripMenuItem
            // 
            this.patronToolStripMenuItem.Name = "patronToolStripMenuItem";
            this.patronToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.patronToolStripMenuItem.Text = "&Patron";
            this.patronToolStripMenuItem.Click += new System.EventHandler(this.insertPatronMenuItem_Click);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.bookToolStripMenuItem.Text = "&Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.insertBookMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkOutToolStripMenuItem,
            this.returnToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.itemToolStripMenuItem.Text = "I&tem";
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.checkOutToolStripMenuItem.Text = "&Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.itemCheckOutMenuItem_Click);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.returnToolStripMenuItem.Text = "&Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.itemReturnMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patronListToolStripMenuItem,
            this.itemListToolStripMenuItem,
            this.checkedOutItemsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.reportToolStripMenuItem.Text = "&Report";
            // 
            // patronListToolStripMenuItem
            // 
            this.patronListToolStripMenuItem.Name = "patronListToolStripMenuItem";
            this.patronListToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.patronListToolStripMenuItem.Text = "&Patron List";
            this.patronListToolStripMenuItem.Click += new System.EventHandler(this.reportPatronListMenuItem_Click);
            // 
            // itemListToolStripMenuItem
            // 
            this.itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            this.itemListToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.itemListToolStripMenuItem.Text = "&Item List";
            this.itemListToolStripMenuItem.Click += new System.EventHandler(this.reportItemListMenuItem_Click);
            // 
            // checkedOutItemsToolStripMenuItem
            // 
            this.checkedOutItemsToolStripMenuItem.Name = "checkedOutItemsToolStripMenuItem";
            this.checkedOutItemsToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.checkedOutItemsToolStripMenuItem.Text = "&Checked Out Items";
            this.checkedOutItemsToolStripMenuItem.Click += new System.EventHandler(this.reportCheckedOutItemsMenuItem_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AllowUserToResizeColumns = false;
            this.dataGridViewReport.AllowUserToResizeRows = false;
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReport.Location = new System.Drawing.Point(0, 50);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewReport.RowTemplate.Height = 24;
            this.dataGridViewReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewReport.Size = new System.Drawing.Size(511, 267);
            this.dataGridViewReport.TabIndex = 3;
            // 
            // txtReportItemCount
            // 
            this.txtReportItemCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtReportItemCount.Location = new System.Drawing.Point(0, 28);
            this.txtReportItemCount.Name = "txtReportItemCount";
            this.txtReportItemCount.ReadOnly = true;
            this.txtReportItemCount.Size = new System.Drawing.Size(511, 22);
            this.txtReportItemCount.TabIndex = 4;
            // 
            // LibraryDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 317);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.txtReportItemCount);
            this.Controls.Add(this.LibraryMenu);
            this.MainMenuStrip = this.LibraryMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryDriver";
            this.ShowIcon = false;
            this.Text = "Library";
            this.Load += new System.EventHandler(this.LibraryDriver_Load);
            this.LibraryMenu.ResumeLayout(false);
            this.LibraryMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      #endregion

      private System.Windows.Forms.MenuStrip LibraryMenu;
      private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
      private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem patronToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem patronListToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem itemListToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem checkedOutItemsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.TextBox txtReportItemCount;
    }
}

