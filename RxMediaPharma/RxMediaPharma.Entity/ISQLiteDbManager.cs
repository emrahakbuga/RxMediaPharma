using System.Data.SQLite;

namespace RxMediaPharma.Entity
{
    public interface ISQLiteDbManager
    {
       SQLiteConnection CreateConnection(string DbPath);
    }
}
