using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	public class Reader
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public int ID { get; set; }
		public List<BookCopy> takenBooks = new List<BookCopy>();		// lazy??
		//context info, not required for fully functioning program
		public int AK { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Adress { get; set; }


		public Reader(string name, string surname)
		{
			this.Name = name;
			this.Surname = surname;
			this.ID = 0; //------fix
		}

	}
}
