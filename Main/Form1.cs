using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EfCore;
using Entity.Dto;

namespace Main
{
	public partial class Form1 : Form,Iform
	{
		readonly IAuthService _authService;
		IAppointmentService _appointmentService;

		public Form1(IAuthService authService, IAppointmentService appointmentService)
		{
			InitializeComponent();
			_authService = authService;
			_appointmentService = appointmentService;
		}

		
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Record record = new Record(_authService);

			Hide();

			record.Show();
		}

		private void log_in(object sender, EventArgs e)
		{
		//	AuthManager authManager = new AuthManager(new UserManager(new EfUserDal()), new PatientManager(new EfPatientDal(), new UserManager(new EfUserDal())));

			LoginUser loginUser = new LoginUser
			{
				Password =password.Text,
				UserName = username.Text
			};

			var rst = _authService.CheckUser(loginUser);

			if (!rst.Success)
			{
				MessageBox.Show("hatalý giriþ");
			}
			else
			{
				Hide();
				var r = new Patient(rst.Data, _authService, _appointmentService);
				r.Show();


			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}