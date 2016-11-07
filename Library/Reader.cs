using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class Reader
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int ID { get; set; }
		private Lazy<List<BookCopy>> takenBooks = new Lazy<List<BookCopy>>();		// lazy??
		public List<BookCopy> TakenBooks
		{
			get
			{
				return takenBooks.Value;
			}
		}
		//context info, not required for fully functioning program
		public DateTime DateOfBirth { get; set; }
		public string Address { get; set; }


		public Reader(string firstName, string lastName, DateTime date, string address)
		{
			FirstName = firstName;
			LastName = lastName;
			ID = 0; //------fix
			DateOfBirth = date;
			Address = address;
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
	}
}
