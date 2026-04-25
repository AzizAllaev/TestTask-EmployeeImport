namespace TestTask_EmployeeImport.Models
{
	public class Employee
	{
		public Employee(
			string payrollNumber, 
			string forenames, 
			string surname, 
			DateTime date_of_Birth, 
			string telephone,
			string mobile,
			string address,
			string adress2,
			string postcode,
			string eMail_Home,
			string start_Date
			)
		{
			Payroll_Number = payrollNumber;
			Forenames = forenames;
			Surname = surname;
			Date_of_Birth = date_of_Birth;
			Telephone = telephone;
			Mobile = mobile;
			Address = address;
			Adress2 = adress2;
			Postcode = postcode;
			EMail_Home = eMail_Home;
			Start_Date = start_Date;
		}

		public int Id { get; set; }
		public string Payroll_Number { get; set; }
		public string Forenames { get; set; }
		public string Surname { get; set; }
		public DateTime Date_of_Birth { get; set; }
		public string Telephone { get; set; }
		public string Mobile { get; set; }
		public string Address { get; set; }
		public string Adress2 { get; set; }
		public string Postcode { get; set; }
		public string EMail_Home { get; set; }
		public string Start_Date { get; set; }


		#region Empty constructor for EF Core
		private Employee() { }
		#endregion
	}
}
