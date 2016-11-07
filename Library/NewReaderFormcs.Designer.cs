namespace Library
{
	partial class NewReaderFormcs
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
			this.label2 = new System.Windows.Forms.Label();
			this.lastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.address = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(15, 119);
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
			this.label1.Location = new System.Drawing.Point(20, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "First name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Last name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lastName
			// 
			this.lastName.Location = new System.Drawing.Point(84, 41);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(100, 20);
			this.lastName.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Date of Birth:";
			// 
			// date
			// 
			this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.date.Location = new System.Drawing.Point(84, 67);
			this.date.MaxDate = System.DateTime.Today;
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(100, 20);
			this.date.TabIndex = 7;
			this.date.Value = System.DateTime.Today;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Address:";
			// 
			// address
			// 
			this.address.Location = new System.Drawing.Point(84, 93);
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(100, 20);
			this.address.TabIndex = 8;
			// 
			// NewReaderFormcs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(198, 150);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.address);
			this.Controls.Add(this.date);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lastName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.firstName);
			this.Controls.Add(this.add);
			this.Name = "NewReaderFormcs";
			this.Text = "NewReaderFormcs";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button add;
		private System.Windows.Forms.TextBox firstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox lastName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox address;
	}
}