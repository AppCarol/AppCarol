using System;
using SQLite.Net.Attributes;

namespace AppCarol
{
	[Table("Items")]
	public class Person
	{
		public Person()
		{
		}

		[PrimaryKey, AutoIncrement]
		public long id { get; set; }

		[NotNull]
		public String CompleteName { get; set; }

		[NotNull]
		public DateTime BirthDate { get; set; }

		[NotNull]
		public User user { get; set; }

		[NotNull]
		public String phone { get; set; }
	}
}
