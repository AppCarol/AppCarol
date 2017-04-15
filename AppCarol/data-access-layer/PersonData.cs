using System;
using SQLiteNetExtensions.Extensions;
namespace AppCarol
{
	/*
	 *  Class to treat all de data rules for entity <Person>
	*/
	public static class PersonData
	{

		public static void addPerson(Person person) 
		{
			try
			{
				var db = DataBaseUtils.getConnection();

				db.Insert(person.User);
				person.UserId = person.User.Id;

				db.Insert(person);
			}
			catch
			{
				//throw database error
				//treat NotSupportedException
				//treat SQLiteException
				//verify if it possible to treat only Exception to all the exceptions
			}

		}

		public static void updatePerson(Person person)
		{
			try
			{
				var db = DataBaseUtils.getConnection();

				db.Update(person);

			}
			catch 
			{ 
				//throw database error
				//treat NotSupportedException
				//treat SQLiteException
				//verify if it possible to treat only Exception to all the exceptions
			}

		}

		public static void deletePerson(Person person)
		{ 
			var db = DataBaseUtils.getConnection();

			try
			{
				db.Delete<Person>(person);
			}
			catch
			{ 
				//throw database error
				//treat NotSupportedException
				//treat SQLiteException
				//verify if it possible to treat only Exception to all the exceptions
			}
		}

		public static Person getPerson(Person person) 
		{
			var db = DataBaseUtils.getConnection();

			String qry = String.Format("SELECT p.*, u.* FROM Person p INNER JOIN User u on p.UserId = u.Id " +
			                           "WHERE u.Email = '" + person.User.Email +"'");

			var result = db.FindWithQuery<Person>(qry);

			//user to get the children relationchip
			if (null != result)
			{
				db.GetChild<Person>(result, "User");
			}

			return result;

		}
	}
}
