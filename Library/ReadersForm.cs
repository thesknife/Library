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
	public partial class ReadersForm : Form
	{
		List<Reader> readers;
		string author, title;

		public delegate void BookTakeEventHandler(object sender, BookTakeEventArgs e);
		public event BookTakeEventHandler BookTake;

		public ReadersForm(List<Reader> readers, string author, string title)
		{
			InitializeComponent();
			dataGridView1.DataSource = readers.Select(reader => new { reader.Name, reader.ID }).ToList();
			this.readers = readers;
			this.author = author;
			this.title = title;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			readerBindingSource.ResetBindings(false);
			var results = readers.Where(reader => (reader.Name.Contains(textBox1.Text) ||
								textBox1.Text.Equals(reader.ID.ToString())));
			if (results.Count() != 0)
			{
				readerBindingSource.DataSource = results.Select(reader => new { reader.Name, reader.ID }).ToList();
				dataGridView1.DataSource = readerBindingSource;
				dataGridView1.AutoResizeColumns();
				dataGridView1.AutoResizeRows();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (BookTake != null)
			{
				BookTake(this, new BookTakeEventArgs((int)dataGridView1.SelectedRows[0].Cells[1].Value, author, title));
				this.Close();
			}
		}
	}
}
