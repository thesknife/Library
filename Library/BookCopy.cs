using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class BookCopy : IEquatable<BookCopy>
	{
		public Book Book { get; set; }
		public Reader Reader { get; set; }
		public DateTime? DateTaken { get; set; }
		public DateTime? DateReturn { get; set; }
		public int ID { get; set; }
		public bool Taken { get; set; }

		public BookCopy(Book book)
		{
			Book = book;
			ID = 0;//-----------------fix
			Taken = false;
			Reader = null;
			DateTaken = null;
			DateReturn = null;
		}

		public void BookTaken(Reader reader)
		{
			Taken = true;
			Reader = reader;
			Reader.BookTaken(this);
			DateTaken = DateTime.Today;
			DateReturn = DateTime.Today.AddDays(30);
		}

		public void BookReturned()
		{
			Taken = false;
			Reader.BookReturned(this);
			Reader = null;
			DateTaken = null;
			DateReturn = null;
		}

		public bool Equals(BookCopy other)
		{
			return this.Book.Equals(other.Book);
		}
	}
}
