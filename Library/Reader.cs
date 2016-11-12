using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class Reader : IEquatable<Reader>
	{
		public string Name { get; set; }
		public int ID { get; set; }
		public List<BookCopy> TakenBooks { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Address { get; set; }

		public Reader() {  }

		public Reader(string name, DateTime date, string address)
		{
			Name = name;
			ID = GetHashCode();
			DateOfBirth = date;
			Address = address;
			TakenBooks = new List<BookCopy>();
		}
		
		public void BookTaken(BookCopy copy)
		{
			copy.BookTaken(this.ID);
			TakenBooks.Add(copy);
		}

		public void BookReturned(BookCopy copy)
		{
			TakenBooks.Remove(copy);
			copy.BookReturned();
		}

		public bool Equals(Reader other)
		{
			return this.Name.Equals(other.Name) || (this.ID.Equals(other.ID));
		}
	}
}
