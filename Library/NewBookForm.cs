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
		BookDictionary books = new BookDictionary();

		public NewBookForm(BookDictionary books)
		{
			InitializeComponent();
			this.books = books;
		}

		private void addBook_Click(object sender, EventArgs e)
		{
			Book book = new Book(ISBN.Text, title.Text, author.Text, Convert.ToInt16(year.Text), Convert.ToInt16(pages.Text));
			books.Add(new BookCopy(book));	
			this.Close();
		}
	}
}
