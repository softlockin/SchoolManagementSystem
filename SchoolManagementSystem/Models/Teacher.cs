using System;
using System.Linq;

namespace SchoolManagementSystem
{
	public class Teacher : User
	{


		#region Constructor

		public Teacher(string name, string username, string password) : base(name, username, password)
		{

		}

		public Teacher(int id, string name, string username, string password) : base(id, name, username, password)
		{

		}

		#endregion

		#region Functions

		public override string ToString()
		{
			return base.ToString();
		}

		public void MarkAttendance(Student student, Class @class, bool present, DateTime date)
		{
			Engine.AttendanceRegister.Add(new Attendance
			{
				Id = Engine.AttendanceRegister.Count + 1,
				Student = student,
				Class = @class,
				Date = date,
				IsPresent = present
			});
		}

		public Attendance[] GetAttendances(Class @class, DateTime date)
		{
			return Engine.AttendanceRegister.Where(att => att.Class == @class && att.Date.Date == date.Date && att.Teacher == this).ToArray();
		}

		#endregion
	}
}
