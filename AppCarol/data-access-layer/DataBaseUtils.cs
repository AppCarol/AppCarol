using SQLite.Net;
using Xamarin.Forms;

namespace AppCarol
{
	public class DataBaseUtils
	{
		public DataBaseUtils()
		{
		}

		public void CreateAllTables()
		{
			var db = getConnection();

			db.CreateTable<User>();
			db.CreateTable<Person>();
		}

		/// <summary>
		/// Dropping tables ONLY works using the synchronous DB connection
		/// For some reason, dropping asynchronously fails miserably
		/// </summary>
		public  void DropAllTables()
		{
			var db = getConnection();

			db.DropTable<Person>();
			db.DropTable<User>();
		}

		public static SQLiteConnection getConnection() 
		{
			return DependencyService.Get<ISQLite>().GetConnection();
		}
	}
}
