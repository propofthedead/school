using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Instructor :Employee
	{
		public string Technology { get; set; }
		public bool TeachBootCamps { get; set; } = false;
		
		List<Student> students = new List<Student>();

		public Instructor(string name,string email,string phone, string jobtitle,decimal salary, string tech) : base(name,email,phone,jobtitle,salary) {
			
			Technology = tech;
		}
		public Instructor()
		{

		}
	}
}
