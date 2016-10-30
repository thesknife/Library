using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	class Reader
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int ID { get; set; }
		//change book to issue?
		public List<BookCopy> takenBooks = new List<BookCopy>();
		//context info, not required for fully functioning program
		public int AK { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Adress { get; set; }

		public Reader(string name, string surname)
		{
			this.Name = name;
			this.Surname = surname;
			this.ID = GetHashCode();
		}

	}
}
