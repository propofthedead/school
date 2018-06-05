﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	abstract class Person
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool IsEmployee { get; set; }

		public Person(string name, string email, string phone, bool isemployyee) {
			Name = name;
			Email = email;
			Phone = phone;
			IsEmployee = isemployyee;
		}
		public Person() { }
	}
}
