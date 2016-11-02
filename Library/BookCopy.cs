using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class BookCopy
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
			ID = GetHashCode();
			Taken = false;
		}

		public void BookTaken(Reader reader)
		{
			Taken = true;
			Reader = reader;
			DateTaken = DateTime.Today;
			DateReturn = DateTime.Today.AddDays(30);
		}

		public void BookReturned()
		{
			Taken = false;
			Reader = null;
			DateTaken = null;
			DateReturn = null;
		}
	}
}
