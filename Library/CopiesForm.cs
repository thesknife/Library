using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class CopiesForm : Form
	{
		public CopiesForm(List<BookCopy> copies)
		{
			InitializeComponent();
			dataGridView1.DataSource = copies.Select(copy => new { copy.ID, copy.Taken, copy.ReaderID, copy.DateTaken, copy.DateReturn }).ToList();
			Book book = copies.First<BookCopy>().Book;
			author.Text = book.Author;
			title.Text = book.Title;
			isbn.Text = book.ISBN;
			published.Text = book.Year.ToString();
			pages.Text = book.NumPages.ToString();
			copyCount.Text = copies.Count.ToString();
		}

	}
}
