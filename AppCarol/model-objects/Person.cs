using System;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace AppCarol
{
	[Table("Person")]
	public class Person
	{
		public Person()
		{
		}

		public Person(String email, String password, String completeName, DateTime birthDate, String phone)
		{
			var user = new User()
			{
				Password = password,
				Email = email
			};

			CompleteName = completeName;
			BirthDate = birthDate;
			User = user;
			Phone = phone;

		}

		[PrimaryKey, AutoIncrement]
		public Int32 Id { get; set; }

		[NotNull]
		public String CompleteName { get; set; }
		 
		[NotNull]
		public DateTime BirthDate { get; set; }

		[OneToOne("UserId")]
		public User User { get; set; }

		[ForeignKey(typeof(User))]
		public Int32 UserId { get; set; }

		[NotNull]
		public String Phone { get; set; }
	}
}
