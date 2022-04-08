namespace SchoolManagementSystem
{
	public class Student : User
	{
		public decimal Fee { get; set; }

		public Student(string name, string userName, string password) : base(name, userName, password)
		{
			Fee = 0;
		}

		public Student(int id, string name, string userName, string password, decimal fee = 0) : base(id, name, userName, password)
		{
			Fee = fee;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
