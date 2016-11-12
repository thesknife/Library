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
			/*
			Tingus inicializavimas (0,1).
			Generics:
				delegatuose arba įvykiuose (0,05),
				metoduose (0,05).
			Delegatai (0,1).
			Įvykiai ir jų apdorojimas: standartiniai (0,05) ir pačių sukurti (0,15).
			Išimtys ir jų apdorojimas: standartinės (0,1) ir sukurtos išimtys (0,1), jų prasmingas apdorojimas.
			Variacijos (0,05) ir kovariacijos (0,05) panaudojimas.
			Trys anoniminiai metodai sukūrimas (0,15).
			Trys lambda išraiškos (0,15).
			Lygiagretaus programavimo panaudojimas:
				Threading arba async/await(task) (naudojant pačių aprašytoms klasėms) (0,2),
				Bendro resurso gijose/užduotyse naudojimas su reikiamomis apsaugomis (0,1).
			Prasmingas skirtingų (app (0,05) ir user (0,05)) konfigūracinių failų panaudojimas.
			Prasmingai pademonstruoti Dependency Injection (0,3).
			*/

			/*
			 * Metodu ilgiai
			 * ++++++++++++++linq i metodus
			 * Panaikint take/close tabus, inkorporuot i pirmus 2
			 * Knygose:
			 *		prideti knyga
			 *		Paimti knyga
			 *	sarasas paimtu knygu (mygtukas prie reader)
			 *	fix id
			 *	
			 * */
		BookDictionary books = new BookDictionary();
		List<Reader> readers = new List<Reader>();

		public Form1()
		{
			InitializeComponent();
			ReadBooks();
			ReadReaders();
			RefreshSearchBooks();
			RefreshSearchReaders();
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
			newBook.FormClosing += HandleNewBook;
		}

		private void HandleNewBook(object sender, EventArgs e)
		{
			RefreshSearchBooks();
		}

		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabs.SelectedIndex)
			{
				case 0:
					RefreshSearchBooks();
					break;
				case 1:
					RefreshSearchReaders();
					break;
				case 2:
					RefreshTakeBook();
					break;
				case 3:
					RefreshReturnBook();
					break;
			}
		}

		void RefreshTakeBook()
		{
			authorInput.Clear();
			titleInput.Clear();
			ISBNInput.Clear();
			nameInput.Clear();
			IDInput.Clear();
		}

		void RefreshReturnBook()
		{
			authorReturnInput.Clear();
			titleReturnInput.Clear();
			isbnReturnInput.Clear();
			nameReturnInput.Clear();
			idReturnInput.Clear();
		}

		public void RefreshSearchReaders()
		{
			readerBindingSource.ResetBindings(false);
			readerBindingSource.DataSource = readers.Select(reader => new { reader.Name, reader.ID, reader.DateOfBirth, reader.Address }).ToList();
			dataGridViewReaders.DataSource = readerBindingSource;
			readerInput.Clear();
		}

		public void RefreshSearchBooks()
		{
			bookBindingSource.ResetBindings(false);
			bookBindingSource.DataSource = books.Keys.Select(book => new { book.Author, book.Title,
																				book.ISBN, book.Year, book.NumPages }).ToList();
			dataGridViewBooks.DataSource = bookBindingSource;
			bookInput.Clear();
		}

		private void addReader_Click(object sender, EventArgs e)
		{
			NewReaderForm newReader = new NewReaderForm(readers);
			newReader.Show();
			newReader.FormClosing += HandleNewReader;
		}

		private void HandleNewReader(object sender, EventArgs e)
		{
			RefreshSearchReaders();
		}

		private void searchReaders_Click(object sender, EventArgs e)
		{
			readerBindingSource.ResetBindings(false);
			var results = readers.Where(reader => ((reader.Name.Contains(readerInput.Text)) ||
								(readerInput.Text.Equals(reader.DateOfBirth.ToShortDateString())) ||
								(readerInput.Text.Equals(reader.ID.ToString())) ||
								(reader.Address.Contains(readerInput.Text))));
			if (results.Count() != 0)
			{
				readerBindingSource.DataSource = results.Select(reader => new {
					reader.Name,
					reader.ID,
					reader.DateOfBirth,
					reader.Address
				});
				dataGridViewReaders.DataSource = readerBindingSource;
				dataGridViewReaders.AutoResizeColumns();
				dataGridViewReaders.AutoResizeRows();
			}
		}

		private void searchBook_Click(object sender, EventArgs e)
		{
			bookBindingSource.ResetBindings(false);
			var results = books.Keys.Where(book => ((book.Author.Contains(bookInput.Text)) ||
								(book.Title.Contains(bookInput.Text)) ||
								(book.ISBN.Contains(bookInput.Text)) ||
								(bookInput.Text.Equals(book.Year.ToString())) ||
								(bookInput.Text.Equals(book.NumPages.ToString()))));
			if (results.Count() != 0)
			{
				bookBindingSource.DataSource = results.Select(book => new
				{
					book.Author,
					book.Title,
					book.ISBN,
					book.Year,
					book.NumPages,
				});
				dataGridViewBooks.DataSource = bookBindingSource;
			}
		}

		private void takeBook_Click(object sender, EventArgs e)
		{
			Reader read = null;
			if (IDInput.Text.Length != 0)
				read = FindReader(Convert.ToInt32(IDInput.Text));
			if (nameInput.Text.Length != 0)
				read = FindReader(nameInput.Text);
			try
			{
				if (read != null)
				{
					if ((titleInput.Text.Length != 0) && (authorInput.Text.Length != 0) && (nameInput.Text.Length != 0))
					{
						Book book = books.FindBook(titleInput.Text, authorInput.Text);
						if (book != null)
						{
							books.BookCopyTaken(book, read);
							MessageBox.Show("Book taken", "Success", MessageBoxButtons.OK);
						}
						else
						{
							MessageBox.Show("No book found", "Error", MessageBoxButtons.OK);
						}
					}
					else
					{
						Book book = books.FindBook(ISBNInput.Text);
						if (book != null)
						{
							books.BookCopyTaken(book, read);
							MessageBox.Show("Book taken", "Success", MessageBoxButtons.OK);
						}
						else
						{
							MessageBox.Show("No book found", "Error", MessageBoxButtons.OK);
						}
					}
				}
				else
				{
					MessageBox.Show("No reader found", "Error", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
			}
		}

		private void returnBook_Click(object sender, EventArgs e)
		{
			Reader read = null;
			if (idReturnInput.Text.Length != 0)
				 read = FindReader(Convert.ToInt32(idReturnInput.Text));
			if (nameReturnInput.Text.Length != 0)
				read = FindReader(nameReturnInput.Text);
			try
			{
				if (read != null)
				{
					if ((titleReturnInput.Text.Length != 0) && (authorReturnInput.Text.Length != 0))
					{
						Book book = books.FindBook(titleReturnInput.Text, authorReturnInput.Text);
						if (book != null)
						{
							books.BookCopyReturned(book, read);
							MessageBox.Show("Book returned", "Success", MessageBoxButtons.OK);
						}
						else
						{
							MessageBox.Show("No book found", "Error", MessageBoxButtons.OK);
						}
					}
					else
					{
						Book book = books.FindBook(isbnReturnInput.Text);
						if (book != null)
						{
							books.BookCopyReturned(book, read);
							MessageBox.Show("Book returned", "Success", MessageBoxButtons.OK);
						}
						else
						{
							MessageBox.Show("No book found", "Error", MessageBoxButtons.OK);
						}
					}
				}
				else
				{
					MessageBox.Show("No reader found", "Error", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
			}
		}

		private Reader FindReader(string name)
		{
			foreach (Reader reader in readers)
			{
				if ((reader.Name.Equals(name)))
				{
					return reader;
				}
			}
			return null;
		}

		private Reader FindReader(int id)
		{
			foreach (Reader reader in readers)
			{
				if ((reader.ID.Equals(id)))
				{
					return reader;
				}
			}
			return null;
		}

		private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;

			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				if (e.ColumnIndex == 6)
					NewCopy(senderGrid);            //use delegate?
				else
					ShowCopies(senderGrid);
			}
		}

		private void ShowCopies(DataGridView sender)
		{
			Book book = books.FindBook(sender.SelectedRows[0].Cells[1].Value.ToString(), sender.SelectedRows[0].Cells[0].Value.ToString());
			CopiesForm copiesForm = new CopiesForm(books.GetBookCopyList(book));
			copiesForm.Show();
		}

		private void NewCopy(DataGridView sender)
		{
			Book book = books.FindBook(sender.SelectedRows[0].Cells[1].Value.ToString(), sender.SelectedRows[0].Cells[0].Value.ToString());
			if (book != null)
			{
				books.Add(new BookCopy(book));
				MessageBox.Show("New Copy added");
			}
		}
		
	}
}
