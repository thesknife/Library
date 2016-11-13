namespace Library
{
	partial class TakenBooksForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.address = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.books = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookCopyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CopyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// name
			// 
			this.name.AutoSize = true;
			this.name.Location = new System.Drawing.Point(54, 13);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(35, 13);
			this.name.TabIndex = 1;
			this.name.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "ID:";
			// 
			// id
			// 
			this.id.AutoSize = true;
			this.id.Location = new System.Drawing.Point(54, 26);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(35, 13);
			this.id.TabIndex = 3;
			this.id.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(147, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Date of birth:";
			// 
			// date
			// 
			this.date.AutoSize = true;
			this.date.Location = new System.Drawing.Point(221, 13);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(35, 13);
			this.date.TabIndex = 5;
			this.date.Text = "label6";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(167, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Address:";
			// 
			// address
			// 
			this.address.AutoSize = true;
			this.address.Location = new System.Drawing.Point(221, 26);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(35, 13);
			this.address.TabIndex = 7;
			this.address.Text = "label8";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(303, 13);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Books taken:";
			// 
			// books
			// 
			this.books.AutoSize = true;
			this.books.Location = new System.Drawing.Point(379, 13);
			this.books.Name = "books";
			this.books.Size = new System.Drawing.Size(41, 13);
			this.books.TabIndex = 9;
			this.books.Text = "label10";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Author,
            this.Title,
            this.DateReturn,
            this.DateTaken,
            this.CopyID});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 46);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(456, 132);
			this.dataGridView1.TabIndex = 10;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Book";
			this.dataGridViewTextBoxColumn1.HeaderText = "Book";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// bookCopyBindingSource
			// 
			this.bookCopyBindingSource.DataSource = typeof(Library.BookCopy);
			// 
			// Author
			// 
			this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Author.HeaderText = "Author";
			this.Author.Name = "Author";
			this.Author.ReadOnly = true;
			// 
			// Title
			// 
			this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Title.HeaderText = "Title";
			this.Title.Name = "Title";
			this.Title.ReadOnly = true;
			// 
			// DateReturn
			// 
			this.DateReturn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DateReturn.HeaderText = "Date Return";
			this.DateReturn.Name = "DateReturn";
			this.DateReturn.ReadOnly = true;
			// 
			// DateTaken
			// 
			this.DateTaken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DateTaken.HeaderText = "Date Taken";
			this.DateTaken.Name = "DateTaken";
			this.DateTaken.ReadOnly = true;
			// 
			// CopyID
			// 
			this.CopyID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.CopyID.HeaderText = "Copy ID";
			this.CopyID.Name = "CopyID";
			this.CopyID.ReadOnly = true;
			// 
			// TakenBooksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 178);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.books);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.address);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.date);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.id);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label1);
			this.Name = "TakenBooksForm";
			this.Text = "TakenBooksForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label id;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label date;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label address;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label books;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource bookCopyBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Author;
		private System.Windows.Forms.DataGridViewTextBoxColumn Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateReturn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateTaken;
		private System.Windows.Forms.DataGridViewTextBoxColumn CopyID;
	}
}