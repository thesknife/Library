using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class Book : IEquatable<Book>
	{
		public string ISBN { get; set; }
		public string Title { get; set; }
		public string[] Author { get; set; }
		public short Year { get; set; }
		public int NumPages { get; set; }

		public Book(string ISBN, string title, string[] author, short year, int numPages)
		{
			this.ISBN = ISBN;
			this.Title = title;
			this.Author = author;
			this.Year = year;
			this.NumPages = numPages;
		}

		public Book(string ISBN, string title, string author, short year, int numPages)
		{
			this.ISBN = ISBN;
			this.Title = title;
			this.Author[0] = author;
			this.Year = year;
			this.NumPages = numPages;
		}

		public bool Equals(Book other)
		{
			return this.Author.Equals(other.Author) && this.Title.Equals(other.Title);
		}
	}
}
