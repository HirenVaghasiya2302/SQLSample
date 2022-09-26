using System;
using SQLite;

namespace SQLDemo
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
