using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace AppCarol
{
	[Table("User")]
	public class User
	{

		public User()
		{

		}

		[PrimaryKey, AutoIncrement, ForeignKey(typeof(Person))] 
		public Int32 Id { get; set; }

		[NotNull, Unique]
		public String Email { get; set; }

		[NotNull]
		public String Password { get; set; }

	}
}
