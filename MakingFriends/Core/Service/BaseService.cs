using System.Data;

namespace Core.Service
{
    public abstract class BaseService
    {
        private readonly string _dbName;

        protected BaseService(string dbName=null)
        {
            _dbName = dbName ?? Const.DbName;
        }

        //protected IDbConnection Conn(string dbName = null)
        //{
        //    dbName = dbName.IsNull() ? _dbName : dbName;
        //    //var path = dbName.pa
        //    //return new SQLiteConnection(builder.ConnectionString);
        //    return Connection();
        //}

       

    }
}
