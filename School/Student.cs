using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Student:Person
	{
		private static int nextId = 1;
		public bool IsVet { get; set; } = false;
		public int StudentId { get; set; }
		public double GPA { get; set; }

		public Student(string name, string email, string phone, bool isEmployee,bool isvet, double gpa) 
			: base(name,email,phone,isEmployee)	{
			IsVet = isvet;
			GPA = gpa;
		}
		public Student()
		{ }
	}
}
