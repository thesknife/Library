namespace Library
{
	partial class NewBookForm
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
			this.author = new System.Windows.Forms.TextBox();
			this.title = new System.Windows.Forms.TextBox();
			this.ISBN = new System.Windows.Forms.TextBox();
			this.pages = new System.Windows.Forms.TextBox();
			this.year = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.addBook = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			this.SuspendLayout();
			// 
			// author
			// 
			this.author.Location = new System.Drawing.Point(117, 12);
			this.author.Name = "author";
			this.author.Size = new System.Drawing.Size(173, 20);
			this.author.TabIndex = 2;
			// 
			// title
			// 
			this.title.Location = new System.Drawing.Point(117, 38);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(173, 20);
			this.title.TabIndex = 3;
			// 
			// ISBN
			// 
			this.ISBN.Location = new System.Drawing.Point(117, 64);
			this.ISBN.Name = "ISBN";
			this.ISBN.Size = new System.Drawing.Size(173, 20);
			this.ISBN.TabIndex = 4;
			// 
			// pages
			// 
			this.pages.Location = new System.Drawing.Point(117, 116);
			this.pages.Name = "pages";
			this.pages.Size = new System.Drawing.Size(173, 20);
			this.pages.TabIndex = 6;
			// 
			// year
			// 
			this.year.Location = new System.Drawing.Point(117, 90);
			this.year.MaxLength = 4;
			this.year.Name = "year";
			this.year.Size = new System.Drawing.Size(173, 20);
			this.year.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Author:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(71, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Title:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(66, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "ISBN:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Year published:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Number of pages:";
			// 
			// addBook
			// 
			this.addBook.Location = new System.Drawing.Point(13, 154);
			this.addBook.Name = "addBook";
			this.addBook.Size = new System.Drawing.Size(277, 23);
			this.addBook.TabIndex = 0;
			this.addBook.Text = "Add new book";
			this.addBook.UseVisualStyleBackColor = true;
			this.addBook.Click += new System.EventHandler(this.addBook_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// NewBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(306, 189);
			this.Controls.Add(this.addBook);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.year);
			this.Controls.Add(this.pages);
			this.Controls.Add(this.ISBN);
			this.Controls.Add(this.title);
			this.Controls.Add(this.author);
			this.Name = "NewBookForm";
			this.Text = "Add new Book";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox author;
		private System.Windows.Forms.TextBox title;
		private System.Windows.Forms.TextBox ISBN;
		private System.Windows.Forms.TextBox pages;
		private System.Windows.Forms.TextBox year;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button addBook;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider2;
	}
}