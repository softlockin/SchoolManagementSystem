using System;

namespace SchoolManagementSystem
{
	public class Attendance
	{
		public int Id { get; set; }
		public bool IsPresent { get; set; }
		public DateTime Date { get; set; }
		public Student Student { get; set; }
		public Class Class { get; set; }
		public Teacher Teacher { get; set; }

		public Attendance()
		{
		}

		public Attendance(bool isPresent, DateTime date)
		{
			IsPresent = isPresent;
			Date = date;
		}
	}
}
