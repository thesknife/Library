using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	class Book
	{
		public string ISBN { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public short Year { get; set; }
		public int NumPages { get; set; }

		public Book(string ISBN, string title, string author, short year, int numPages)
		{
			this.ISBN = ISBN;
			this.Title = title;
			this.Author = author;
			this.Year = year;
			this.NumPages = numPages;
		}
	}
}
