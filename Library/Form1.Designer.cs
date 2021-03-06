﻿namespace Library
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.addBook = new System.Windows.Forms.Button();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
			this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Copies = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Take = new System.Windows.Forms.DataGridViewButtonColumn();
			this.New = new System.Windows.Forms.DataGridViewButtonColumn();
			this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.searchBook = new System.Windows.Forms.Button();
			this.bookInput = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Taken = new System.Windows.Forms.DataGridViewButtonColumn();
			this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.readerInput = new System.Windows.Forms.TextBox();
			this.addReader = new System.Windows.Forms.Button();
			this.searchReaders = new System.Windows.Forms.Button();
			this.tabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// addBook
			// 
			this.addBook.Location = new System.Drawing.Point(268, 24);
			this.addBook.Name = "addBook";
			this.addBook.Size = new System.Drawing.Size(98, 23);
			this.addBook.TabIndex = 2;
			this.addBook.Text = "Add new book";
			this.addBook.UseVisualStyleBackColor = true;
			this.addBook.Click += new System.EventHandler(this.addBook_Click);
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabPage1);
			this.tabs.Controls.Add(this.tabPage2);
			this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabs.Location = new System.Drawing.Point(0, -3);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(606, 235);
			this.tabs.TabIndex = 1;
			this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.dataGridViewBooks);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.searchBook);
			this.tabPage1.Controls.Add(this.bookInput);
			this.tabPage1.Controls.Add(this.addBook);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(598, 209);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Search Books";
			// 
			// dataGridViewBooks
			// 
			this.dataGridViewBooks.AllowUserToAddRows = false;
			this.dataGridViewBooks.AllowUserToDeleteRows = false;
			this.dataGridViewBooks.AllowUserToResizeColumns = false;
			this.dataGridViewBooks.AllowUserToResizeRows = false;
			this.dataGridViewBooks.AutoGenerateColumns = false;
			this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.numPagesDataGridViewTextBoxColumn,
            this.Copies,
            this.Take,
            this.New});
			this.dataGridViewBooks.DataSource = this.bookBindingSource;
			this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewBooks.Location = new System.Drawing.Point(3, 52);
			this.dataGridViewBooks.MultiSelect = false;
			this.dataGridViewBooks.Name = "dataGridViewBooks";
			this.dataGridViewBooks.ReadOnly = true;
			this.dataGridViewBooks.RowHeadersVisible = false;
			this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewBooks.Size = new System.Drawing.Size(592, 154);
			this.dataGridViewBooks.TabIndex = 5;
			this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
			// 
			// authorDataGridViewTextBoxColumn
			// 
			this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
			this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
			this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
			this.authorDataGridViewTextBoxColumn.ReadOnly = true;
			this.authorDataGridViewTextBoxColumn.Width = 90;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
			this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			this.titleDataGridViewTextBoxColumn.ReadOnly = true;
			this.titleDataGridViewTextBoxColumn.Width = 120;
			// 
			// iSBNDataGridViewTextBoxColumn
			// 
			this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
			this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
			this.iSBNDataGridViewTextBoxColumn.Width = 78;
			// 
			// yearDataGridViewTextBoxColumn
			// 
			this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
			this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
			this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
			this.yearDataGridViewTextBoxColumn.ReadOnly = true;
			this.yearDataGridViewTextBoxColumn.Width = 40;
			// 
			// numPagesDataGridViewTextBoxColumn
			// 
			this.numPagesDataGridViewTextBoxColumn.DataPropertyName = "NumPages";
			this.numPagesDataGridViewTextBoxColumn.HeaderText = "Pages";
			this.numPagesDataGridViewTextBoxColumn.Name = "numPagesDataGridViewTextBoxColumn";
			this.numPagesDataGridViewTextBoxColumn.ReadOnly = true;
			this.numPagesDataGridViewTextBoxColumn.Width = 45;
			// 
			// Copies
			// 
			this.Copies.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Copies.HeaderText = "View copies";
			this.Copies.Name = "Copies";
			this.Copies.ReadOnly = true;
			this.Copies.Text = "Copies";
			this.Copies.UseColumnTextForButtonValue = true;
			this.Copies.Width = 70;
			// 
			// Take
			// 
			this.Take.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Take.HeaderText = "Take copy";
			this.Take.Name = "Take";
			this.Take.ReadOnly = true;
			this.Take.Text = "Take";
			this.Take.UseColumnTextForButtonValue = true;
			// 
			// New
			// 
			this.New.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.New.HeaderText = "Add new copy";
			this.New.Name = "New";
			this.New.ReadOnly = true;
			this.New.Text = "Add ";
			this.New.UseColumnTextForButtonValue = true;
			this.New.Width = 73;
			// 
			// bookBindingSource
			// 
			this.bookBindingSource.DataSource = typeof(Library.Book);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Enter search criteria";
			// 
			// searchBook
			// 
			this.searchBook.Location = new System.Drawing.Point(187, 24);
			this.searchBook.Name = "searchBook";
			this.searchBook.Size = new System.Drawing.Size(75, 23);
			this.searchBook.TabIndex = 1;
			this.searchBook.Text = "Search";
			this.searchBook.UseVisualStyleBackColor = true;
			this.searchBook.Click += new System.EventHandler(this.searchBook_Click);
			// 
			// bookInput
			// 
			this.bookInput.Location = new System.Drawing.Point(6, 26);
			this.bookInput.Name = "bookInput";
			this.bookInput.Size = new System.Drawing.Size(175, 20);
			this.bookInput.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.dataGridViewReaders);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.readerInput);
			this.tabPage2.Controls.Add(this.addReader);
			this.tabPage2.Controls.Add(this.searchReaders);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(598, 209);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Search readers";
			// 
			// dataGridViewReaders
			// 
			this.dataGridViewReaders.AllowUserToAddRows = false;
			this.dataGridViewReaders.AllowUserToDeleteRows = false;
			this.dataGridViewReaders.AllowUserToResizeColumns = false;
			this.dataGridViewReaders.AllowUserToResizeRows = false;
			this.dataGridViewReaders.AutoGenerateColumns = false;
			this.dataGridViewReaders.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.DateOfBirth,
            this.addressDataGridViewTextBoxColumn,
            this.Taken});
			this.dataGridViewReaders.DataSource = this.readerBindingSource;
			this.dataGridViewReaders.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewReaders.Location = new System.Drawing.Point(3, 52);
			this.dataGridViewReaders.MultiSelect = false;
			this.dataGridViewReaders.Name = "dataGridViewReaders";
			this.dataGridViewReaders.ReadOnly = true;
			this.dataGridViewReaders.RowHeadersVisible = false;
			this.dataGridViewReaders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewReaders.Size = new System.Drawing.Size(592, 154);
			this.dataGridViewReaders.TabIndex = 6;
			this.dataGridViewReaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReaders_CellContentClick);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DateOfBirth.DataPropertyName = "DateOfBirth";
			this.DateOfBirth.HeaderText = "Date Of Birth";
			this.DateOfBirth.Name = "DateOfBirth";
			this.DateOfBirth.ReadOnly = true;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Taken
			// 
			this.Taken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Taken.HeaderText = "Taken Books";
			this.Taken.Name = "Taken";
			this.Taken.ReadOnly = true;
			this.Taken.Text = "View";
			this.Taken.UseColumnTextForButtonValue = true;
			// 
			// readerBindingSource
			// 
			this.readerBindingSource.DataSource = typeof(Library.Reader);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Enter search criteria";
			// 
			// readerInput
			// 
			this.readerInput.Location = new System.Drawing.Point(6, 26);
			this.readerInput.Name = "readerInput";
			this.readerInput.Size = new System.Drawing.Size(175, 20);
			this.readerInput.TabIndex = 4;
			// 
			// addReader
			// 
			this.addReader.Location = new System.Drawing.Point(268, 24);
			this.addReader.Name = "addReader";
			this.addReader.Size = new System.Drawing.Size(98, 23);
			this.addReader.TabIndex = 2;
			this.addReader.Text = "Add new reader";
			this.addReader.UseVisualStyleBackColor = true;
			this.addReader.Click += new System.EventHandler(this.addReader_Click);
			// 
			// searchReaders
			// 
			this.searchReaders.Location = new System.Drawing.Point(187, 24);
			this.searchReaders.Name = "searchReaders";
			this.searchReaders.Size = new System.Drawing.Size(75, 23);
			this.searchReaders.TabIndex = 1;
			this.searchReaders.Text = "Search";
			this.searchReaders.UseVisualStyleBackColor = true;
			this.searchReaders.Click += new System.EventHandler(this.searchReaders_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(606, 232);
			this.Controls.Add(this.tabs);
			this.Name = "Form1";
			this.Text = "Library";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.readerBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addBook;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button searchBook;
		private System.Windows.Forms.TextBox bookInput;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button addReader;
		private System.Windows.Forms.Button searchReaders;
		private System.Windows.Forms.TextBox readerInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewBooks;
		private System.Windows.Forms.BindingSource bookBindingSource;
		private System.Windows.Forms.DataGridView dataGridViewReaders;
		private System.Windows.Forms.BindingSource readerBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn Taken;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numPagesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn Copies;
		private System.Windows.Forms.DataGridViewButtonColumn Take;
		private System.Windows.Forms.DataGridViewButtonColumn New;
	}
}

