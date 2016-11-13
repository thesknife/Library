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
	public partial class CopiesForm : Form
	{
		List<BookCopy> _copies;
		public CopiesForm(List<BookCopy> copies)
		{
			InitializeComponent();
			_copies = copies;
			FillData();
			Book book = copies.First<BookCopy>().Book;
			author.Text = book.Author;
			title.Text = book.Title;
			isbn.Text = book.ISBN;
			published.Text = book.Year.ToString();
			pages.Text = book.NumPages.ToString();
			copyCount.Text = copies.Count.ToString();
		}

		public void FillData()
		{
			dataGridView1.DataSource = _copies.Select(copy => new { copy.ID, copy.Taken, copy.ReaderID, copy.DateTaken, copy.DateReturn }).ToList();
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
					BookReturn(this, new BookReturnEventArgs((int)dataGridView1.SelectedRows[0].Cells[2].Value,
																(int)dataGridView1.SelectedRows[0].Cells[0].Value));
					FillData();
				}
			}
		}
	}
}
