namespace SchoolManagementSystem
{
	public class Admin : User
	{
		#region Public Properties

		#endregion

		#region Constructor

		public Admin(string name, string username, string password) : base(name, username, password)
		{

		}

		public Admin(int id, string name, string username, string password) : base(id, name, username, password)
		{

		}

		#endregion

		#region Private Properties

		public void AddTeacher(Teacher teacher)
		{
			Engine.Users.Add(teacher);
		}

		public void AddClass(Class @class)
		{
			Engine.Classes.Add(@class);
		}

		public void AddStudent(Student student)
		{
			Engine.Users.Add(student);
		}

		public void AssignTeacherToClass(Teacher teacher, Class @class)
		{
			@class.Teacher = teacher;
			@class.TeacherId = teacher.Id;
		}

		public void AddStudentToClass(Student student, Class @class)
		{
			@class.Students.Add(student);
		}


		#endregion
	}
}
