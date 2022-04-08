using System;

namespace SchoolManagementSystem.Models
{
	public class Fee
	{
		public int Id { get; set; }
		public int StudentId { get; set; }
		public double Amount { get; set; }
		public DateTime Year { get; set; }
	}
}
