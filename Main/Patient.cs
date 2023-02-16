using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EfCore;
using Entity.Concrete;
using Microsoft.VisualBasic;
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
	public partial class Patient : Form
	{
		User _user;
		IAuthService _authService;
		IAppointmentService _appointmentService;
		public Patient(User user, IAuthService authService, IAppointmentService appointmentService)
		{
			InitializeComponent();
			_user = user;
			_authService = authService;
			_appointmentService = appointmentService;
		}

		//AppointmentManager _appointmentManager = new AppointmentManager(new EfAppointmentDal());

		string dateFormat = "M-d-yyy";


		private void CreateAppointment(object sender, EventArgs e)
		{

			Appointment appointment = new Appointment
			{
				Date = DateTime.Parse("" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "-" + dateTimePicker1.Value.Year),
				Description = richTextBox1.Text,
				PatientId = _user.Id,
				Status = true,
				Time = listBox1.SelectedItem.ToString(),
				DoctorId=5009
			};

			_appointmentService.Add(appointment);
			MessageBox.Show("Randevu oluşturuldu.");
			UpdateAppointment();

		}

		private void Patient_Load(object sender, EventArgs e)
		{
			UpdateAppointment();
		}

		
		private void UpdateAppointment()
		{
			listView1.Items.Clear();

			var appo = _appointmentService.GetAllByPatientId(_user.Id);

			foreach (var a in appo.Data)
			{
				listView1.Items.Add(new ListViewItem(new string[] { a.Date.ToString(dateFormat), a.Time, a.Description.ToString() }));
			}

		}

		private void Delete(object sender, EventArgs e)
		{
			var appo = _appointmentService.GetAllByPatientId(_user.Id);

			var del = listView1.SelectedItems[0].SubItems;

			foreach (var i in appo.Data)
			{
				if (i.Date.ToString(dateFormat) == Convert.ToDateTime(del[0].Text).ToString(dateFormat) && del[1].Text == i.Time.ToString())
				{
					_appointmentService.Delete(_appointmentService.GetById(i.Id).Data);
				}
			}

			UpdateAppointment();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Hide();
			Form1 form1 = new Form1(_authService);
			form1.Show();
		}
	}
}
