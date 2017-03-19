using System;
using SQLite.Net.Attributes;

namespace AppCarol
{
	[Table("Person")]
	public class Person
	{
		public Person()
		{
		}

		[PrimaryKey, AutoIncrement]
		public long Id { get; set; }

		[NotNull]
		public String CompleteName { get; set; }
		 
		[NotNull]
		public DateTime BirthDate { get; set; }

		[NotNull]
		public User User { get; set; }

		[NotNull]
		public String Phone { get; set; }
	}
}
