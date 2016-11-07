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
		BookDictionary books = new BookDictionary();
		List<Reader> readers = new List<Reader>();

		public Form1()
		{
			InitializeComponent();
			ReadBooks();
			ReadReaders();
		}

		public void ReadBooks()
		{
			if (!File.Exists("dataBooks.xml"))
				return;
			try
			{
				using (StreamReader read = new StreamReader("dataBooks.xml"))
				{
					XmlDictionarySerialization.Deserialize(read, books);
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

		private void WriteReaders()
		{
			try
			{
				using (StreamWriter writeData = new StreamWriter("dataReaders.xml"))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(List<Reader>));
					serializer.Serialize(writeData, readers);
				}
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
			}
		}

		private void WriteBooks()
		{
			try
			{
				using (StreamWriter writeData = new StreamWriter("dataBooks.xml"))
				{
					XmlDictionarySerialization.Serialize(writeData, books);
				}
			}
			catch (IOException ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (books.Count != 0)
				WriteBooks();
			if (readers.Count != 0)
				WriteReaders();
		}

		private void addBook_Click(object sender, EventArgs e)
		{
			NewBookForm newBook = new NewBookForm(books);
			newBook.Show();
		}

		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabs.SelectedIndex)
			{
				case 0:
					SelectedSearchBooks();
					break;
				case 1:
					SelectedSearchReaders();
					break;
			}
		}

		private void SelectedSearchReaders()
		{
			
		}

		private void SelectedSearchBooks()
		{
			bookList.Items.Clear();
			bookInput.Clear();
		}

		private void addReader_Click(object sender, EventArgs e)
		{
			NewReaderFormcs newReader = new NewReaderFormcs();
			newReader.Show();
		}
	}
}
