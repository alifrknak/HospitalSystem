namespace Main
{
	partial class Record
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
			this.UserName = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.LastName = new System.Windows.Forms.TextBox();
			this.ValidPassword = new System.Windows.Forms.TextBox();
			this.FirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UserName
			// 
			this.UserName.Location = new System.Drawing.Point(193, 195);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(155, 27);
			this.UserName.TabIndex = 0;
			this.UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(208, 405);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 37);
			this.button1.TabIndex = 1;
			this.button1.Text = "Kayıt ol";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.kayıt_ol);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(193, 36);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Doğum Tarihi";
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(193, 236);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(155, 27);
			this.Password.TabIndex = 4;
			// 
			// LastName
			// 
			this.LastName.Location = new System.Drawing.Point(193, 146);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(155, 27);
			this.LastName.TabIndex = 5;
			// 
			// ValidPassword
			// 
			this.ValidPassword.Location = new System.Drawing.Point(193, 278);
			this.ValidPassword.Name = "ValidPassword";
			this.ValidPassword.Size = new System.Drawing.Size(155, 27);
			this.ValidPassword.TabIndex = 6;
			// 
			// FirstName
			// 
			this.FirstName.Location = new System.Drawing.Point(193, 99);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(155, 27);
			this.FirstName.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(118, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Sifre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(77, 198);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Kullanıcı Adı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(90, 285);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "SifreTekrar";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(118, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "Soyad";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(138, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 20);
			this.label7.TabIndex = 15;
			this.label7.Text = "Ad";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(427, 422);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 37);
			this.button2.TabIndex = 17;
			this.button2.Text = "Ana Menü";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Record
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 509);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FirstName);
			this.Controls.Add(this.ValidPassword);
			this.Controls.Add(this.LastName);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.UserName);
			this.Name = "Record";
			this.Text = "Record";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Record_FormClosing);
			this.Load += new System.EventHandler(this.Record_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox UserName;
		private Button button1;
		private DateTimePicker dateTimePicker1;
		private Label label1;
		private TextBox Password;
		private TextBox LastName;
		private TextBox ValidPassword;
		private TextBox FirstName;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label6;
		private Label label7;
		private Button button2;
	}
}