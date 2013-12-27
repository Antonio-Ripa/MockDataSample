using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using MockData;

namespace MockDataSource
{
	public static class DummyData
	{
	

		public static IList<Person> GetDataPerson(int range)
		{
			
			int personIdIncrement = 1;
			return Enumerable.Range(0, range).Select(o => new Person
			{
				ID = personIdIncrement++,
				FirstName = MockData.Person.FirstName(),
				LastName = MockData.Person.Surname(),
				Address = MockData.Address.StreetAddress(),
				City = MockData.Address.City(),
				ZipCode = MockData.Address.ZipCode(),
				Country = MockData.Address.DefaultCountry(),
				Status = new Random().Next(100) % 2 == 0,
				Details = MockData.Lorem.Paragraph(1)
			}).ToList();
		}
	}
}
