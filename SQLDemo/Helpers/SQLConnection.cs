using System;
using SQLDemo.Models;
using SQLite;
using Xamarin.Forms;

namespace SQLDemo.Helpers
{
    public class SQLConnection
    {
        static SQLiteConnection _database;
        static bool _databaseInitiated = false;
        public static SQLiteConnection database
        {
            get
            {
                if (!_databaseInitiated)
                {
                    initDatabase();
                }
                return _database;
            }
        }

        static void initDatabase()
        {
            _database = DependencyService.Get<ISQLite>().GetConnection();
            // create the tables
            _database.CreateTable<User>();
        }
    }
}
