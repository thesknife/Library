namespace Library
{
	partial class NewReaderForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.add = new System.Windows.Forms.Button();
			this.firstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.address = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(17, 93);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(169, 23);
			this.add.TabIndex = 0;
			this.add.Text = "Add new reader";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// firstName
			// 
			this.firstName.Location = new System.Drawing.Point(84, 15);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(100, 20);
			this.firstName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Date of birth:";
			// 
			// date
			// 
			this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date.Location = new System.Drawing.Point(84, 41);
			this.date.MaxDate = new System.DateTime(2016, 11, 7, 0, 0, 0, 0);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(100, 20);
			this.date.TabIndex = 7;
			this.date.Value = new System.DateTime(2016, 11, 7, 0, 0, 0, 0);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Address:";
			// 
			// address
			// 
			this.address.Location = new System.Drawing.Point(84, 67);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(100, 20);
			this.address.TabIndex = 8;
			// 
			// NewReaderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(198, 126);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.address);
			this.Controls.Add(this.date);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.firstName);
			this.Controls.Add(this.add);
			this.Name = "NewReaderForm";
			this.Text = "NewReaderFormcs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button add;
		private System.Windows.Forms.TextBox firstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox address;
	}
}