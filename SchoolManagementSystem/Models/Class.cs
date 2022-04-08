using System.Collections.Generic;

namespace SchoolManagementSystem
{
	public class Class
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int TeacherId { get; set; }

		public Teacher Teacher { get; set; }
		public List<Student> Students { get; set; }

		#region Constructor

		public Class(string name, int teacherId, Teacher teacher = null)
		{
			Name = name;
			TeacherId = teacherId;
			Teacher = teacher;
			Students = new List<Student>();
		}

		public Class(int id, string name, int teacherId, Teacher teacher = null)
		{
			Id = id;
			Name = name;
			TeacherId = teacherId;
			Teacher = teacher;
			Students = new List<Student>();
		}

		public Class(string name)
		{
			Name = name;
			Students = new List<Student>();
		}

		public Class(int id, string name)
		{
			Id = id;
			Name = name;
			Students = new List<Student>();
		}

		public override string ToString()
		{
			return Name;
		}

		#endregion
	}
}
