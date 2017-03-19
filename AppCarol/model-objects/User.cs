using System;
using SQLite.Net.Attributes;

namespace AppCarol
{
	[Table("User")]
	public class User
	{

		public User()
		{

		}

		[PrimaryKey, AutoIncrement] 
		public long id { get; set; }

		[NotNull]
		public String Email { get; set; }

		[NotNull]
		public String Password { get; set; }

	}
}
