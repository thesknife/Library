using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class BookDictionary : IEnumerable
	{
		Dictionary<Book, List<BookCopy>> books = new Dictionary<Book, List<BookCopy>>();

		public int Count
		{
			get
			{
				return books.Count;
			}
		}

		public IEnumerable Keys
		{
			get
			{
				return books.Keys;
			}
		}

		public BookDictionary() { }

		public void Add(BookCopy copy)
		{
			if (!books.ContainsKey(copy.Book))
				books.Add(copy.Book, new List<BookCopy>());
			books[copy.Book].Add(copy);
		}

		public void Add(List<BookCopy> copies)
		{
			if (!books.ContainsKey(copies.First().Book))
				books.Add(copies.First().Book, new List<BookCopy>());
			books[copies.First().Book].AddRange(copies);
		}

		public bool ContainsBook(Book book)
		{
			return books.ContainsKey(book);
		}

		public Book FindBook(string title, string author)
		{
			foreach(Book book in books.Keys)
			{
				if ((book.Author.Equals(author)) && (book.Title.Equals(title)))
				{
					return book;
				}
			}
			return null;
		}

		public void RemoveCopy(BookCopy copy)
		{
			books[copy.Book].Remove(copy);
		}

		public List<BookCopy> GetBookCopyList(Book key)
		{
			return books[key];
		}

		public void BookCopyTaken(Book key, Reader reader)
		{
			if (!books.ContainsKey(key))
				throw new Exception("Book not found");
			foreach (BookCopy copy in books[key])
			{
				if (!copy.Taken)
				{
					copy.BookTaken(reader);
					return;
				}
			}
			throw new Exception("All book copies are taken");
		}

		public void BookCopyReturned(Book key, Reader reader)
		{
			if (!books.ContainsKey(key))
				throw new Exception("Book not found");
			foreach (BookCopy copy in books[key])
			{
				if (!copy.Reader.Equals(reader))
				{
					copy.BookReturned();
					return;
				}
			}
			throw new Exception("No book copies are taken");
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return books.GetEnumerator();
		}

		public void Clear()
		{
			books.Clear();
		}
	}
}
