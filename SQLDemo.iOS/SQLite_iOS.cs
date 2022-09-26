using System;
using System.IO;
using SQLDemo.iOS;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(SQLite_iOS))]
namespace SQLDemo.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {
        }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "database.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);

            // This is where we copy in the prepopulated database
            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                File.Copy(sqliteFilename, path);
            }
            else
            {
                File.Delete(path);
                File.Copy(sqliteFilename, path);
            }

            var conn = new SQLite.SQLiteConnection(path);

            // Return the database connection
            return conn;
        }
    }
}
