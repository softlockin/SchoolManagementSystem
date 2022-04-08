using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace SchoolManagementSystem
{
	public class Engine
	{
		public static List<User> Users { get; set; }
		public static List<Teacher> Teachers => Users.OfType<Teacher>().ToList();
		public static List<Student> Students => Users.OfType<Student>().ToList();
		public static List<Class> Classes { get; set; }
		public static List<Attendance> AttendanceRegister { get; set; } = new List<Attendance>();
		public static List<Grade> Grades { get; set; } = new List<Grade>();
		public static User CurrentUser { get; set; }

		#region Constructor

		public static void Setup()
		{
			Engine.Users = GetUsers();
			Engine.Classes = GetClasses();
			//Admin admin = new Admin("Admin", "admin", "123");
			//Engine.Users.Add(admin);

			//Engine.Users.Add(new Student("s1", "s1", "123"));
			//Engine.Users.Add(new Student("s2", "s2", "123"));
			//Engine.Users.Add(new Student("s3", "s3", "123"));
			//Engine.Users.Add(new Student("s4", "s4", "123"));

			//Engine.Users.Add(new Teacher("t1", "t1", "123"));
			//Engine.Users.Add(new Teacher("t2", "t2", "123"));

			//Engine.Classes.Add(new Class("c1"));
			//Engine.Classes.Add(new Class("c2"));
		}

		#endregion

		#region Methods

		public static void AddUser(User user)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				string role;
				if (user is Student) role = "student"; else role = "teacher";

				SqlCommand cmd = new SqlCommand("[dbo].[AddUser]", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@name", user.Name);
				cmd.Parameters.AddWithValue("@username", user.UserName);
				cmd.Parameters.AddWithValue("@password", user.Password);
				cmd.Parameters.AddWithValue("@role", role);

				cmd.ExecuteNonQuery();
			}

			Engine.Setup();
		}

		public static void AddClass(Class @class)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("[dbo].[AddClass]", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@name", @class.Name);

				cmd.ExecuteNonQuery();

			}
			Engine.Setup();
		}

		public static void RemoveClass(Class @class)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand($"DELETE FROM dbo.Classes WHERE [Name] = @name", cnn);
				cmd.Parameters.AddWithValue("@name", @class.Name);
				cmd.ExecuteNonQuery();
			}
			Engine.Setup();
		}

		public static void AssignTeacher(string className, int teacherId)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("[dbo].[AssignTeacher]", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@teacher", teacherId);
				cmd.Parameters.AddWithValue("@class", className);

				cmd.ExecuteNonQuery();
			}
			Engine.Setup();
		}

		public static void AssignStudent(string className, int studentId)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("[dbo].[AssignStudent]", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@student", studentId);
				cmd.Parameters.AddWithValue("@class", className);

				cmd.ExecuteNonQuery();
			}
			Engine.Setup();
		}

		public static void AssignGrade(int studentId, int classId, string grade)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("[dbo].[AddGrade]", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@result", grade);
				cmd.Parameters.AddWithValue("@class", classId);
				cmd.Parameters.AddWithValue("@student", studentId);

				cmd.ExecuteNonQuery();
			}
		}

		public static void AssignFee(int studentId, decimal amount)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("[dbo].[AssignFee]", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@student", studentId);
				cmd.Parameters.AddWithValue("@amount", amount);

				cmd.ExecuteNonQuery();
			}
			Setup();
		}

		public static void MarkAttendance(int studentId, int classId, bool isPresent, DateTime date)
		{
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("[dbo].[AddAttendance]", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@isPresent", isPresent);
				cmd.Parameters.AddWithValue("@class", classId);
				cmd.Parameters.AddWithValue("@student", studentId);
				cmd.Parameters.AddWithValue("@date", date);

				cmd.ExecuteNonQuery();
			}
		}

		public static List<User> GetUsers()
		{
			List<User> users = new List<User>();
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[GetUsers]()", cnn)
				{
					CommandType = System.Data.CommandType.Text
				};

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int Id = (int)reader["Id"];
					string Name = (string)reader["Name"];
					string UserName = (string)reader["UserName"];
					string Password = (string)reader["Password"];
					string role = (string)reader["Role"];
					if (role == "teacher")
					{
						users.Add(new Teacher(Id, Name, UserName, Password));
					}
					else if (role == "student")
					{
						decimal fee = (decimal)reader["Fee"];
						users.Add(new Student(Id, Name, UserName, Password, fee));
					}
					else users.Add(new Admin(Id, Name, UserName, Password));

				}
			}
			return users;
		}

		public static List<Class> GetClasses()
		{
			List<Class> classes = new List<Class>();
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[GetClasses]()", cnn)
				{
					CommandType = System.Data.CommandType.Text
				};

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					Class @class = null;
					string name = (string)reader["Name"];
					int id = (int)reader["Id"];
					Teacher teacher = null;

					if (reader["TeacherId"] != DBNull.Value)
					{
						int teacherId = (int)reader["TeacherId"];
						teacher = Engine.Users.OfType<Teacher>().First(x => x.Id == teacherId);
						@class = new Class(id, name, teacherId, teacher);
					}
					else
					{
						@class = new Class(id, name);
					}

					@class.Students = GetStudentsByClass(id);

					classes.Add(@class);
				}
			}
			return classes;
		}

		public static User GetUser(int id)
		{
			User user = null;
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("SELECT [dbo].[GetUserById](@id)", cnn)
				{
					CommandType = System.Data.CommandType.StoredProcedure
				};
				cmd.Parameters.AddWithValue("@id", id);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int Id = (int)reader["Id"];
					string Name = (string)reader["Name"];
					string UserName = (string)reader["UserName"];
					string Password = (string)reader["Password"];
					string role = (string)reader["Role"];
					if (role == "teacher")
					{
						user = new Teacher(Id, Name, UserName, Password);
					}
					else if (role == "student")
					{
						decimal fee = (decimal)reader["Fee"];
						user = new Student(Id, Name, UserName, Password, fee);
					}
					else user = new Admin(Id, Name, UserName, Password);
				}
			}

			return user;
		}

		public static List<Student> GetStudentsByClass(int id)
		{
			List<Student> users = new List<Student>();
			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[GetStudentsByClassId](@id)", cnn)
				{
					CommandType = System.Data.CommandType.Text
				};
				cmd.Parameters.AddWithValue("@id", id);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int Id = (int)reader["Id"];

					users.Add(Engine.Students.Where(u => u.Id == Id).First());
				}
			}
			return users;
		}

		public static List<Grade> GetGradesByStudent(int id)
		{
			List<Grade> grades = new List<Grade>();

			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[GetGradesByStudent](@student)", cnn)
				{
					CommandType = System.Data.CommandType.Text
				};
				cmd.Parameters.AddWithValue("@student", id);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int Id = (int)reader["Id"];
					int studentId = (int)reader["StudentId"];
					int classId = (int)reader["ClassId"];
					string result = (string)reader["Result"];

					Student s = Engine.Students.First(f => f.Id == studentId);
					Class c = Engine.Classes.First(f => f.Id == classId);

					grades.Add(new Grade(s, c, result));
				}
			}

			return grades;
		}

		public static List<Grade> GetGradesByClass(int id)
		{
			List<Grade> grades = new List<Grade>();

			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[GetGradesByClass](@class)", cnn)
				{
					CommandType = System.Data.CommandType.Text
				};
				cmd.Parameters.AddWithValue("@class", id);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int Id = (int)reader["Id"];
					int studentId = (int)reader["StudentId"];
					int classId = (int)reader["ClassId"];
					string result = (string)reader["Result"];

					Student s = Engine.Students.First(f => f.Id == studentId);
					Class c = Engine.Classes.First(f => f.Id == classId);

					grades.Add(new Grade(s, c, result));
				}
			}

			return grades;
		}

		public static List<Attendance> GetAttendances(int studentId, int classId)
		{
			List<Attendance> grades = new List<Attendance>();

			using (SqlConnection cnn = new SqlConnection(connectionString))
			{
				cnn.Open();

				SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[GetAttendance](@student, @class)", cnn)
				{
					CommandType = System.Data.CommandType.Text
				};
				cmd.Parameters.AddWithValue("@class", classId);
				cmd.Parameters.AddWithValue("@student", studentId);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					bool isPresent = (bool)reader["IsPresent"];
					DateTime date = (DateTime)reader["Date"];

					grades.Add(new Attendance(isPresent, date));
				}
			}

			return grades;
		}

		#endregion

		#region Private Helpers

		private static string connectionString = "Server=.; Database=SchoolDB; Trusted_Connection=True;";

		#endregion
	}
}