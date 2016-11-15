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

		public List<Book>  Keys
		{
			get
			{
				List<Book> result = new List<Book>();
				foreach (Book book in books.Keys)
				{
					result.Add(book);
				}
				return result;
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

		public Book FindBook(string isbn)
		{
			foreach (Book book in books.Keys)
			{
				if (book.Author.Equals(isbn))
				{
					return book;
				}
			}
			return null;
		}

		public BookCopy FindCopy(int id)
		{
			foreach (List<BookCopy> list in books.Values)
			{
				foreach (BookCopy copy in list)
				{
					if (copy.ID.Equals(id))
						return copy;
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

		public void BookCopyTaken(string author, string title, Reader reader)
		{
			Book book = FindBook(title, author);
			if (book == null)
				throw new BookException("Book not found");
			foreach (BookCopy copy in books[book])
			{
				if (!copy.Taken)
				{
					reader.BookTaken(copy);
					return;
				}
			}
			throw new BookException("All book copies are taken");
		}

		public void BookCopyReturned(int copyID, Reader reader)
		{
			BookCopy copy = FindCopy(copyID);
			if (copy == null)
				throw new BookException("Copy with this id was not found");
			if (!copy.ReaderID.Equals(reader.ID))
				throw new BookException("Book taken not by this reader");
			else
				reader.BookReturned(copy);

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
