using SchoolManagementSystem.Models;

namespace SchoolManagementSystem
{
	public class Student : User
	{
		public decimal Fee { get; set; }
		public int? ParentId { get; set; }
		public Parent Parent { get; set; }

		public Student(string name, string userName, string password) : base(name, userName, password)
		{
			Fee = 0;
		}

		public Student(int id, string name, string userName, string password, decimal fee = 0, int? parentId = null) : base(id, name, userName, password)
		{
			Fee = fee;
			ParentId = parentId;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
