namespace SchoolManagementSystem
{
	public class Grade
	{
		public int Id { get; set; }
		public string Result { get; set; }

		public Student Student { get; set; }
		public Class Class { get; set; }

		public Grade(Student student, Class @class, string result)
		{
			Class = @class;
			Student = student;
			Result = result;
		}

		public Grade(int id, Student student, Class @class, string result)
		{
			Id = id;
			Class = @class;
			Student = student;
			Result = result;
		}
	}
}
