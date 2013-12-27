using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MockDataSource;

namespace MockDataSample
{
	class Program
	{
		static void Main(string[] args)
		{
			

			IList<Person> listPersons = DummyData.GetDataPerson(300);
			foreach (var person in listPersons)
			{
				Console.WriteLine(string.Format("Name : {0} {1}", person.FirstName, person.LastName));
				Console.WriteLine(string.Format("Address : {0}", person.Address));
				Console.WriteLine(string.Format("City : {0}",person.City));
			}
			Console.ReadKey();

		}
	}
}
