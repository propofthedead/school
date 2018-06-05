using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	abstract class Employee : Person
	{
		public int EmployeeId { get; set; }
		public decimal Salary { get; set; }
		public string JobTitle { get; set; }

		public void setSalary(decimal newsalary) {
			if (newsalary <= 0) {
				throw new ApplicationException("Salary Must be positive");
			}
			Salary = newsalary;
		}

		public Employee(string name,string email,string phone, string jobtitle,decimal salaray) : base(name,email,phone,true) {


		}
		public Employee() {

		}
	}
}
