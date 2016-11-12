namespace Library
{
	partial class CopiesForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.takenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.readerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookCopyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.author = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.Label();
			this.isbn = new System.Windows.Forms.Label();
			this.published = new System.Windows.Forms.Label();
			this.pages = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.copyCount = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Author:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Title:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(170, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "ISBN:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(170, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Published:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(298, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Pages:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.takenDataGridViewCheckBoxColumn,
            this.readerIDDataGridViewTextBoxColumn,
            this.dateTakenDataGridViewTextBoxColumn,
            this.dateReturnDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bookCopyBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 73);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(428, 150);
			this.dataGridView1.TabIndex = 5;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			this.iDDataGridViewTextBoxColumn.Width = 92;
			// 
			// takenDataGridViewCheckBoxColumn
			// 
			this.takenDataGridViewCheckBoxColumn.DataPropertyName = "Taken";
			this.takenDataGridViewCheckBoxColumn.HeaderText = "Taken";
			this.takenDataGridViewCheckBoxColumn.Name = "takenDataGridViewCheckBoxColumn";
			this.takenDataGridViewCheckBoxColumn.ReadOnly = true;
			this.takenDataGridViewCheckBoxColumn.Width = 41;
			// 
			// readerIDDataGridViewTextBoxColumn
			// 
			this.readerIDDataGridViewTextBoxColumn.DataPropertyName = "ReaderID";
			this.readerIDDataGridViewTextBoxColumn.HeaderText = "ReaderID";
			this.readerIDDataGridViewTextBoxColumn.Name = "readerIDDataGridViewTextBoxColumn";
			this.readerIDDataGridViewTextBoxColumn.ReadOnly = true;
			this.readerIDDataGridViewTextBoxColumn.Width = 92;
			// 
			// dateTakenDataGridViewTextBoxColumn
			// 
			this.dateTakenDataGridViewTextBoxColumn.DataPropertyName = "DateTaken";
			this.dateTakenDataGridViewTextBoxColumn.HeaderText = "DateTaken";
			this.dateTakenDataGridViewTextBoxColumn.Name = "dateTakenDataGridViewTextBoxColumn";
			this.dateTakenDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dateReturnDataGridViewTextBoxColumn
			// 
			this.dateReturnDataGridViewTextBoxColumn.DataPropertyName = "DateReturn";
			this.dateReturnDataGridViewTextBoxColumn.HeaderText = "DateReturn";
			this.dateReturnDataGridViewTextBoxColumn.Name = "dateReturnDataGridViewTextBoxColumn";
			this.dateReturnDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// bookCopyBindingSource
			// 
			this.bookCopyBindingSource.DataSource = typeof(Library.BookCopy);
			// 
			// author
			// 
			this.author.AutoSize = true;
			this.author.Location = new System.Drawing.Point(78, 22);
			this.author.Name = "author";
			this.author.Size = new System.Drawing.Size(35, 13);
			this.author.TabIndex = 6;
			this.author.Text = "label6";
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Location = new System.Drawing.Point(67, 48);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(35, 13);
			this.title.TabIndex = 7;
			this.title.Text = "label7";
			// 
			// isbn
			// 
			this.isbn.AutoSize = true;
			this.isbn.Location = new System.Drawing.Point(211, 22);
			this.isbn.Name = "isbn";
			this.isbn.Size = new System.Drawing.Size(35, 13);
			this.isbn.TabIndex = 8;
			this.isbn.Text = "label8";
			// 
			// published
			// 
			this.published.AutoSize = true;
			this.published.Location = new System.Drawing.Point(232, 48);
			this.published.Name = "published";
			this.published.Size = new System.Drawing.Size(35, 13);
			this.published.TabIndex = 9;
			this.published.Text = "label9";
			// 
			// pages
			// 
			this.pages.AutoSize = true;
			this.pages.Location = new System.Drawing.Point(344, 22);
			this.pages.Name = "pages";
			this.pages.Size = new System.Drawing.Size(41, 13);
			this.pages.TabIndex = 10;
			this.pages.Text = "label10";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(298, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Copies:";
			// 
			// copyCount
			// 
			this.copyCount.AutoSize = true;
			this.copyCount.Location = new System.Drawing.Point(346, 48);
			this.copyCount.Name = "copyCount";
			this.copyCount.Size = new System.Drawing.Size(35, 13);
			this.copyCount.TabIndex = 12;
			this.copyCount.Text = "label7";
			// 
			// CopiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 223);
			this.Controls.Add(this.copyCount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pages);
			this.Controls.Add(this.published);
			this.Controls.Add(this.isbn);
			this.Controls.Add(this.title);
			this.Controls.Add(this.author);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "CopiesForm";
			this.Text = "CopiesForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCopyBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn takenDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn readerIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateTakenDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bookCopyBindingSource;
		private System.Windows.Forms.Label author;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label isbn;
		private System.Windows.Forms.Label published;
		private System.Windows.Forms.Label pages;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label copyCount;
	}
}