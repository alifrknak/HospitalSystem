namespace Main
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(221, 244);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 66);
			this.button1.TabIndex = 0;
			this.button1.Text = "GİRİŞ YAP";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.log_in);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(365, 332);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(114, 37);
			this.button2.TabIndex = 1;
			this.button2.Text = "KAYIT OL";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(221, 107);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(175, 27);
			this.username.TabIndex = 2;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(221, 176);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(175, 27);
			this.password.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(127, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(132, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(708, 544);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private Button button2;
		private TextBox username;
		private TextBox password;
		private Label label1;
		private Label label2;
	}
}