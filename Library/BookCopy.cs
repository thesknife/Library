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
		public int ReaderID { get; set; }
		public DateTime? DateTaken { get; set; }
		public DateTime? DateReturn { get; set; }
		public int ID { get; set; }
		public bool Taken { get; set; }

		public BookCopy() { }

		public BookCopy(Book book)
		{
			Book = book;
			ID = GetHashCode();
			Taken = false;
			ReaderID = 0;
			DateTaken = null;
			DateReturn = null;
		}

		public BookCopy(Book book, int id, bool status, int reader, DateTime taken, DateTime returned)
		{
			Book = book;
			ID = id;
			Taken = status;
			ReaderID = reader;
			DateTaken = taken;
			DateReturn = returned;
		}

		public void BookTaken(int id)
		{
			Taken = true;
			ReaderID = id;
			DateTaken = DateTime.Today;
			DateReturn = DateTime.Today.AddDays(30);
		}

		public void BookReturned()
		{
			Taken = false;
			ReaderID = 0;
			DateTaken = null;
			DateReturn = null;
		}

		public bool Equals(BookCopy other)
		{
			return this.Book.Equals(other.Book);
		}
	}
}
