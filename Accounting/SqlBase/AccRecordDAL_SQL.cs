using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using Accounting.Model;
using Dapper;
namespace Accounting.SqlBase
{
    public class AccRecordDAL_SQL : IAccountingDAL<AccRecord, AccRecordQuery>, IAccRecordDAL
    {
        IDbConnection conn;
        public AccRecordDAL_SQL(IDbConnection conn)
        {
            this.conn = conn;
        }

        public int Add(AccRecord m)
        {
            string sql = "insert xxx";
            return conn.Execute(sql, m);
        }

        public int Delete(AccRecord m)
        {
            string sql = "insert xxx";
            return conn.Execute(sql, m);
        }

        public int Edit(AccRecord m)
        {
            string sql = "insert xxx";
            return conn.Execute(sql, m);
        }

        public List<AccRecord> GetAll(AccRecordQuery q)
        {
            string sql = "select * from AccRecord where 1=1";
            return conn.Query<AccRecord>(sql, q).ToList();
        }
    }
}
