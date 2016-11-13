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
		Reader read;

		public TakenBooksForm(Reader reader)
		{
			InitializeComponent();
			read = reader;
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
				row.Cells[4].Value = copy.ID;
				dataGridView1.Rows.Add(row);
			}
			dataGridView1.AutoResizeColumns();
		}

		public delegate void BookReturnEventHandler(object sender, BookReturnEventArgs e);
		public event BookReturnEventHandler BookReturn;

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;
			if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				if (BookReturn != null)
				{
					BookReturn(this, new BookReturnEventArgs(read.ID, (int)dataGridView1.SelectedRows[0].Cells[4].Value));
					dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
				}
			}
		}
	}
}
