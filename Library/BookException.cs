using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	[Serializable]
	public class BookException : Exception
	{
		public Book Book { get; }

		public BookException() : base() { }

		public BookException(string message) : base(message) { }

		public BookException(string message, Exception inner) : base(message, inner) { }

		protected BookException(SerializationInfo info, StreamingContext context) : base(info, context) { }

		public BookException(string message, Book book) : base(message)
		{
			Book = book;
		}

		public override string ToString()
		{
			return base.ToString() + Environment.NewLine + Book.ToString();
		}
	}
}
