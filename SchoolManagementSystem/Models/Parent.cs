using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
	public class Parent : User
	{
		public List<Student> Students { get; set; }

		public Parent(int id, string name, string userName, string password) : base(id, name, userName, password)
		{
			Students = new List<Student>();
		}

		public Parent(string name, string userName, string password) : base(name, userName, password)
		{

		}
	}
}
