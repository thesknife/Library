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
		}

		private void newCopy_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void newBook_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void addBook_Click(object sender, EventArgs e)
		{
			
			Book book = new Library.Book(ISBN.Text, title.Text, author.Text, year.Text, int.TryParse(pages.Text, ));
		}
	}
}
