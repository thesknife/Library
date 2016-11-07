using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Library
{
	public static class XmlDictionarySerialization
	{
		public class Pair
		{
			public Book Key;
			public List<BookCopy> Value;

			public Pair() { }
			public Pair(Book key, List<BookCopy> value)
			{
				Key = key;
				Value = value;
			}
		}

		public static void Serialize(StreamWriter writer, BookDictionary dictionary)
		{
			List<Pair> entries = new List<Pair>();
			foreach (Book key in dictionary.Keys)
			{
				entries.Add(new Pair(key, dictionary.GetBookCopyList(key)));
			}
			XmlSerializer serializer = new XmlSerializer(typeof(List<Pair>));
			serializer.Serialize(writer, entries);
		}
		public static void Deserialize(StreamReader reader, BookDictionary dictionary)
		{
			dictionary.Clear();
			XmlSerializer serializer = new XmlSerializer(typeof(List<Pair>));
			List<Pair> list = (List<Pair>)serializer.Deserialize(reader);
			foreach (Pair entry in list)
			{
				dictionary.Add(entry.Value);
			}
		}
	}
}
