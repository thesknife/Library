namespace Library
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
			this.Copies = new System.Windows.Forms.DataGridViewButtonColumn();
			this.New = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.searchBook = new System.Windows.Forms.Button();
			this.bookInput = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridViewReaders = new System.Windows.Forms.DataGridView();
			this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Taken = new System.Windows.Forms.DataGridViewButtonColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.readerInput = new System.Windows.Forms.TextBox();
			this.addReader = new System.Windows.Forms.Button();
			this.searchReaders = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.IDInput = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.nameInput = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ISBNInput = new System.Windows.Forms.TextBox();
			this.titleInput = new System.Windows.Forms.TextBox();
			this.authorInput = new System.Windows.Forms.TextBox();
			this.takeBook = new System.Windows.Forms.Button();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.idReturnInput = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.nameReturnInput = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.isbnReturnInput = new System.Windows.Forms.TextBox();
			this.titleReturnInput = new System.Windows.Forms.TextBox();
			this.authorReturnInput = new System.Windows.Forms.TextBox();
			this.returnBook = new System.Windows.Forms.Button();
			this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.readerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
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
			this.tabs.Controls.Add(this.tabPage3);
			this.tabs.Controls.Add(this.tabPage4);
			this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabs.Location = new System.Drawing.Point(0, -3);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(541, 235);
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
			this.tabPage1.Size = new System.Drawing.Size(533, 209);
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
            this.New});
			this.dataGridViewBooks.DataSource = this.bookBindingSource;
			this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewBooks.Location = new System.Drawing.Point(3, 52);
			this.dataGridViewBooks.MultiSelect = false;
			this.dataGridViewBooks.Name = "dataGridViewBooks";
			this.dataGridViewBooks.ReadOnly = true;
			this.dataGridViewBooks.RowHeadersVisible = false;
			this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewBooks.Size = new System.Drawing.Size(527, 154);
			this.dataGridViewBooks.TabIndex = 5;
			this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
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
			// New
			// 
			this.New.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.New.HeaderText = "Add new copy";
			this.New.Name = "New";
			this.New.ReadOnly = true;
			this.New.Text = "Add ";
			this.New.UseColumnTextForButtonValue = true;
			this.New.Width = 81;
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
			this.tabPage2.Size = new System.Drawing.Size(533, 209);
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
			this.dataGridViewReaders.Size = new System.Drawing.Size(527, 154);
			this.dataGridViewReaders.TabIndex = 6;
			this.dataGridViewReaders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReaders_CellContentClick);
			// 
			// DateOfBirth
			// 
			this.DateOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DateOfBirth.DataPropertyName = "DateOfBirth";
			this.DateOfBirth.HeaderText = "Date Of Birth";
			this.DateOfBirth.Name = "DateOfBirth";
			this.DateOfBirth.ReadOnly = true;
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
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Transparent;
			this.tabPage3.Controls.Add(this.IDInput);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.nameInput);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.ISBNInput);
			this.tabPage3.Controls.Add(this.titleInput);
			this.tabPage3.Controls.Add(this.authorInput);
			this.tabPage3.Controls.Add(this.takeBook);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(964, 209);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Book taken";
			// 
			// IDInput
			// 
			this.IDInput.Location = new System.Drawing.Point(234, 99);
			this.IDInput.Name = "IDInput";
			this.IDInput.Size = new System.Drawing.Size(145, 20);
			this.IDInput.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(231, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Enter reader ID:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(276, 68);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "OR";
			// 
			// nameInput
			// 
			this.nameInput.Location = new System.Drawing.Point(234, 41);
			this.nameInput.Name = "nameInput";
			this.nameInput.Size = new System.Drawing.Size(145, 20);
			this.nameInput.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(231, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Enter reader:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(85, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "OR";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Enter book ISBN:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Enter book title:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Enter book author:";
			// 
			// ISBNInput
			// 
			this.ISBNInput.Location = new System.Drawing.Point(21, 148);
			this.ISBNInput.Name = "ISBNInput";
			this.ISBNInput.Size = new System.Drawing.Size(145, 20);
			this.ISBNInput.TabIndex = 3;
			// 
			// titleInput
			// 
			this.titleInput.Location = new System.Drawing.Point(21, 87);
			this.titleInput.Name = "titleInput";
			this.titleInput.Size = new System.Drawing.Size(145, 20);
			this.titleInput.TabIndex = 2;
			// 
			// authorInput
			// 
			this.authorInput.Location = new System.Drawing.Point(21, 42);
			this.authorInput.Name = "authorInput";
			this.authorInput.Size = new System.Drawing.Size(145, 20);
			this.authorInput.TabIndex = 1;
			// 
			// takeBook
			// 
			this.takeBook.Cursor = System.Windows.Forms.Cursors.Default;
			this.takeBook.Location = new System.Drawing.Point(234, 145);
			this.takeBook.Name = "takeBook";
			this.takeBook.Size = new System.Drawing.Size(75, 23);
			this.takeBook.TabIndex = 0;
			this.takeBook.Text = "Take Book";
			this.takeBook.UseVisualStyleBackColor = true;
			this.takeBook.Click += new System.EventHandler(this.takeBook_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.Transparent;
			this.tabPage4.Controls.Add(this.idReturnInput);
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Controls.Add(this.label15);
			this.tabPage4.Controls.Add(this.nameReturnInput);
			this.tabPage4.Controls.Add(this.label16);
			this.tabPage4.Controls.Add(this.label10);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Controls.Add(this.isbnReturnInput);
			this.tabPage4.Controls.Add(this.titleReturnInput);
			this.tabPage4.Controls.Add(this.authorReturnInput);
			this.tabPage4.Controls.Add(this.returnBook);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(964, 209);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Book Returned";
			// 
			// idReturnInput
			// 
			this.idReturnInput.Location = new System.Drawing.Point(231, 102);
			this.idReturnInput.Name = "idReturnInput";
			this.idReturnInput.Size = new System.Drawing.Size(145, 20);
			this.idReturnInput.TabIndex = 19;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(228, 87);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(82, 13);
			this.label14.TabIndex = 18;
			this.label14.Text = "Enter reader ID:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(273, 74);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(23, 13);
			this.label15.TabIndex = 17;
			this.label15.Text = "OR";
			// 
			// nameReturnInput
			// 
			this.nameReturnInput.Location = new System.Drawing.Point(231, 44);
			this.nameReturnInput.Name = "nameReturnInput";
			this.nameReturnInput.Size = new System.Drawing.Size(145, 20);
			this.nameReturnInput.TabIndex = 16;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(228, 29);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(68, 13);
			this.label16.TabIndex = 15;
			this.label16.Text = "Enter reader:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(84, 117);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "OR";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(17, 134);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "Enter book ISBN:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(17, 73);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(81, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Enter book title:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(17, 28);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(95, 13);
			this.label13.TabIndex = 11;
			this.label13.Text = "Enter book author:";
			// 
			// isbnReturnInput
			// 
			this.isbnReturnInput.Location = new System.Drawing.Point(20, 150);
			this.isbnReturnInput.Name = "isbnReturnInput";
			this.isbnReturnInput.Size = new System.Drawing.Size(148, 20);
			this.isbnReturnInput.TabIndex = 10;
			// 
			// titleReturnInput
			// 
			this.titleReturnInput.Location = new System.Drawing.Point(20, 89);
			this.titleReturnInput.Name = "titleReturnInput";
			this.titleReturnInput.Size = new System.Drawing.Size(148, 20);
			this.titleReturnInput.TabIndex = 9;
			// 
			// authorReturnInput
			// 
			this.authorReturnInput.Location = new System.Drawing.Point(20, 44);
			this.authorReturnInput.Name = "authorReturnInput";
			this.authorReturnInput.Size = new System.Drawing.Size(148, 20);
			this.authorReturnInput.TabIndex = 8;
			// 
			// returnBook
			// 
			this.returnBook.Location = new System.Drawing.Point(232, 147);
			this.returnBook.Name = "returnBook";
			this.returnBook.Size = new System.Drawing.Size(78, 23);
			this.returnBook.TabIndex = 0;
			this.returnBook.Text = "Return book";
			this.returnBook.UseVisualStyleBackColor = true;
			this.returnBook.Click += new System.EventHandler(this.returnBook_Click);
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
			// bookBindingSource
			// 
			this.bookBindingSource.DataSource = typeof(Library.Book);
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
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// readerBindingSource
			// 
			this.readerBindingSource.DataSource = typeof(Library.Reader);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(541, 232);
			this.Controls.Add(this.tabs);
			this.Name = "Form1";
			this.Text = "Library";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReaders)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
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
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ISBNInput;
		private System.Windows.Forms.TextBox titleInput;
		private System.Windows.Forms.TextBox authorInput;
		private System.Windows.Forms.Button takeBook;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox IDInput;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox nameInput;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox isbnReturnInput;
		private System.Windows.Forms.TextBox titleReturnInput;
		private System.Windows.Forms.TextBox authorReturnInput;
		private System.Windows.Forms.Button returnBook;
		private System.Windows.Forms.TextBox idReturnInput;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox nameReturnInput;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.DataGridView dataGridViewBooks;
		private System.Windows.Forms.BindingSource bookBindingSource;
		private System.Windows.Forms.DataGridView dataGridViewReaders;
		private System.Windows.Forms.BindingSource readerBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numPagesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn Copies;
		private System.Windows.Forms.DataGridViewButtonColumn New;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn Taken;
	}
}

