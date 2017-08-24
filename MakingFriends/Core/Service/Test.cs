using System.Collections.Generic;
using System.Linq;
using Core.Enums;
using Dapper;
using Kaixin.Data.Dapper;

namespace Core.Service
{
    public class Test : DapperRepository
    {
        public Test() : base(DbName.MakingFriends) {}

        public string Query()
        {
            string sql = @"select name from Test";
            List<string> res = Connection.Query<string>(sql).ToList();
            string s = string.Join(",", res.ToArray());
            return s;
        }
    }
}
