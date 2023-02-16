namespace Main
{
	partial class Patient
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
		private void Patient_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();

		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(18, 74);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Location = new System.Drawing.Point(82, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Randevu oluştur";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new System.Drawing.Point(18, 162);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(250, 98);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(105, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "açıklama";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.FlatAppearance.BorderSize = 22;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(94, 287);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 29);
			this.button1.TabIndex = 4;
			this.button1.TabStop = false;
			this.button1.Text = "Oluştur";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.CreateAppointment);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(461, 378);
			this.panel1.TabIndex = 5;
			this.panel1.Tag = "Randevu al";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(328, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Saatler";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Items.AddRange(new object[] {
            "09:00-10:00",
            "10:00-11:00",
            "11:00-12:00",
            "13:00-14:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00"});
			this.listBox1.Location = new System.Drawing.Point(286, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(150, 264);
			this.listBox1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(700, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Randevular";
			// 
			// listView1
			// 
			this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(499, 58);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(506, 310);
			this.listView1.TabIndex = 7;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tarih";
			this.columnHeader3.Width = 150;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Saat";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Açıklama";
			this.columnHeader2.Width = 210;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(700, 405);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(154, 36);
			this.button2.TabIndex = 8;
			this.button2.Text = "Randevu\'yu iptal et ";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Delete);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(943, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(94, 29);
			this.button3.TabIndex = 9;
			this.button3.Text = "ana menü";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Patient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1049, 588);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Patient";
			this.Text = "HOSPITAL";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Patient_FormClosing);
			this.Load += new System.EventHandler(this.Patient_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DateTimePicker dateTimePicker1;
		private Label label1;
		private RichTextBox richTextBox1;
		private Label label2;
		private Button button1;
		private Panel panel1;
		private Label label3;
		private ListView listView1;
		private ColumnHeader columnHeader3;
		private Button button2;
		private ListBox listBox1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private Label label4;
		private Button button3;
	}
}