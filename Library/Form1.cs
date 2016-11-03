using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Collections;

namespace Library
{
	public partial class Form1 : Form
	{
		Dictionary<Book, List<BookCopy>> books = new Dictionary<Book, List<BookCopy>>();		//List<BookCopy>> -- lazy???
		List<Reader> readers = new List<Reader>();

		public Form1()
		{
			InitializeComponent();
			//ReadBooks();
			//ReadReaders();
		}

		public void ReadBooks()
		{
			if (!File.Exists("dataBooks.xml"))
				return;
			try
			{
				using (StreamReader read = new StreamReader("dataBooks.xml"))
				{
					XmlSerializer ser = new XmlSerializer(typeof(Dictionary<Book, List<BookCopy>>));
					books = ser.Deserialize(read) as Dictionary<Book, List<BookCopy>>;
				}
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.ToString(), "Reading error", MessageBoxButtons.OK);
			}
		}

		public void ReadReaders()
		{
			if (!File.Exists("dataReaders.xml"))
				return;
			try
			{
				using (StreamReader read = new StreamReader("dataReaders.xml"))
				{
					XmlSerializer ser = new XmlSerializer(typeof(List<Reader>));
					readers = ser.Deserialize(read) as List<Reader>;
				}
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.ToString(), "Reading error", MessageBoxButtons.OK);
			}
		}

		private void WriteData(string fileName, Type type, IEnumerable collection)
		{
			try
			{
				using (StreamWriter writeData = new StreamWriter(fileName))
				{
					XmlSerializer serializer = new XmlSerializer(type);
					serializer.Serialize(writeData, collection);
				}
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			//if (books.Count != 0)
			//	WriteData("dataBooks.xml", typeof(Dictionary<Book, List<Book>>), books);
			//if (readers.Count != 0)
			//	WriteData("dataReaders.xml", typeof(List<Reader>), readers);
		}

		private void addBook_Click(object sender, EventArgs e)
		{
			NewBookForm newBook = new NewBookForm(books);
			newBook.Show();
		}
	}
}
