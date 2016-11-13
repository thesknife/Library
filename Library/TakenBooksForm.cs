using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
	public partial class TakenBooksForm : Form
	{
		public TakenBooksForm(Reader reader)
		{
			InitializeComponent();
			name.Text = reader.Name;
			id.Text = reader.ID.ToString();
			date.Text = reader.DateOfBirth.ToShortDateString();
			address.Text = reader.Address;
			books.Text = reader.TakenBooks.Count.ToString();
			FillDataGrid(reader.TakenBooks);
		}

		void FillDataGrid(List<BookCopy> takenBooks)
		{
			foreach (BookCopy copy in takenBooks)
			{
				DataGridViewRow row = new DataGridViewRow();
				row.CreateCells(dataGridView1);
				row.Cells[0].Value = copy.Book.Author;
				row.Cells[1].Value = copy.Book.Title;
				row.Cells[2].Value = copy.DateTaken.Value.ToShortDateString();
				row.Cells[3].Value = copy.DateReturn.Value.ToShortDateString();
				row.Cells[4].Value = copy.ID.ToString();
				dataGridView1.Rows.Add(row);
			}
			dataGridView1.AutoResizeColumns();
		}
	}
}
