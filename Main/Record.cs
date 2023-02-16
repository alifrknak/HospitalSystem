using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EfCore;
using Entity.Concrete;
using Entity.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
	public partial class Record : Form
	{
		readonly IAuthService _authService;
		public Record(IAuthService authService)
		{
			InitializeComponent();
			_authService = authService;
		}

		private void Record_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)// main menu
		{
			Hide();
			
			Form1 form1 = new Form1(_authService);

			form1.Show();
		}

		private void kayıt_ol(object sender, EventArgs e)
		{
			UserRecord userRecord = new UserRecord
			{
				BirthDate = dateTimePicker1.Value,
				FirstName = FirstName.Text,
				LastName = LastName.Text,
				Password = Password.Text,
				UserName = UserName.Text
				
			};

			//AuthManager authManager = new AuthManager(new UserManager(new EfUserDal()), new PatientManager(new EfPatientDal(), new UserManager(new EfUserDal())));

			_authService.CreateUser(userRecord);

			MessageBox.Show("bitti.");


		}

		private void Record_Load(object sender, EventArgs e)
		{

		}
	}
}
