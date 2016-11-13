using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class BookReturnEventArgs : EventArgs
	{
		public int copyID, readerID;

		public BookReturnEventArgs(int reader, int copy)
		{
			copyID = copy;
			readerID = reader;
		}
	}
}
