using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class BookTakeEventArgs : EventArgs
	{
		public int readerID;
		public string author, title;

		public BookTakeEventArgs(int id, string author, string title)
		{
			readerID = id;
			this.author = author;
			this.title = title;
		}
	}
}
