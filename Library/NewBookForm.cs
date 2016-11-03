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
	public partial class NewBookForm : Form
	{
		Dictionary<Book, List<BookCopy>> books = new Dictionary<Book, List<BookCopy>>();

		public NewBookForm(Dictionary<Book, List<BookCopy>> books)
		{
			InitializeComponent();
			this.books = books;
			newCopy.Checked = false;
			newBook.Checked = false;
		}

		private void newCopy_CheckedChanged(object sender, EventArgs e)
		{
			author.Enabled = true;
			title.Enabled = true;
			ISBN.Enabled = false;
			year.Enabled = false;
			pages.Enabled = false;
			addBook.Enabled = true;
		}

		private void newBook_CheckedChanged(object sender, EventArgs e)
		{
			author.Enabled = true;
			title.Enabled = true;
			ISBN.Enabled = true;
			year.Enabled = true;
			pages.Enabled = true;
			addBook.Enabled = true;
		}

		private void addBook_Click(object sender, EventArgs e)
		{
			int pg, yr;
			Book book;
			if (newCopy.Checked)
			{
				if ((int.TryParse(pages.Text, out pg)) && (int.TryParse(year.Text, out yr)))
				{

					
					books[book].Add(new BookCopy(book));
					this.Close();
				}
			}
			else if (newBook.Checked)
			{
				book = new Book(ISBN.Text, title.Text, author.Text, (short)yr, pg);
				books.Add(book, new List<BookCopy>());
				books[book].Add(new BookCopy(book));
			}
			else
			{
				MessageBox.Show("New book type not selected", "Error", MessageBoxButtons.OK);
			}
		}
	}
}
