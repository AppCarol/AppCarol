﻿using SQLite.Net;

namespace AppCarol
{
	/// <summary>
	/// SQLite.Net-PCL
	/// 
	/// https://github.com/oysteinkrog/SQLite.Net-PCL
	/// http://www.xamarinhelp.com/local-storage-day-10/
	/// </summary>
	public interface ISQLite
	{
		void CloseConnection();
		SQLiteConnection GetConnection();
		void DeleteDatabase();
	}
}
