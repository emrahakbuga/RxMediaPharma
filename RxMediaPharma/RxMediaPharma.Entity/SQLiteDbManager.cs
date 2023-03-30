using log4net;
using System;
using System.Data;
using System.Data.SQLite;

namespace RxMediaPharma.Entity
{
    public class SQLiteDbManager : BaseDbManager, ISQLiteDbManager
    {
        public static SQLiteConnection sqliteConn;
        public override void DbConnect(string DbPath)
        {
            sqliteConn = new SQLiteConnection("Data Source=" + DbPath);
            try
            {
                sqliteConn.Open();
            }
            catch (Exception ex)
            {
                LogManager.GetLogger(typeof(SQLiteDbManager)).Error(ex.Message, ex);
            }
        }

        public SQLiteConnection CreateConnection(string DbPath)
        {
            SQLiteDbManager manager = new SQLiteDbManager();
            manager.DbConnect(DbPath);
            return sqliteConn;
        }

        public static DataTable ReadDataTableWithSqlStrings(SQLiteConnection conn, string sqlString)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = sqlString;

            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlite_datareader);

            conn.Close();
            return dt;
        }
    }
}
