using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
	class Program
	{

		static void Main(string[] args)
		{
			Student dan = new Student("dan", "dan@gov.org", "5135135142", false, true, 3.2);
			Instructor greg = new Instructor("greg", "greg@max.com", "5135135134", "dotNet Insturctor", 10000M, "CSharp");
			Sales Lisa = new Sales("Lisa", "liza@max.com", "5135414745", "Sales rep", 9000.21M, "Mason", 10000.50M);
			Operations o1 = new Operations("blah", "blach@blach.com", "5133147854554", "Janitor", 5000M);
			Lisa.TotalSales = 23000;
			List<Person> people = new List<Person>();
			people.Add(dan);
			people.Add(greg);
			people.Add(Lisa);
			people.Add(o1);

			decimal totalsales =0;
			foreach (Person person in people) {
				Sales sales = person as Sales;
				if (sales != null) {
					totalsales += sales.TotalSales;
				}
		
			}
			Console.WriteLine($"Total sales is {totalsales}");
		}
	}
}
