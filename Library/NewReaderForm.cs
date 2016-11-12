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
	public partial class NewReaderForm : Form
	{
		public List<Reader> readers;
		
		public NewReaderForm(List<Reader> readerList)
		{
			InitializeComponent();
			readers = readerList;
		}

		private void add_Click(object sender, EventArgs e)
		{
			Reader reader = new Reader(firstName.Text, date.Value, address.Text);
			if (readers.Contains(reader))
			{
				MessageBox.Show("This reader already exists", "Error", MessageBoxButtons.OK);
			}
			else
			{
				readers.Add(reader);
			}
			this.Close();
		}
	}
}
