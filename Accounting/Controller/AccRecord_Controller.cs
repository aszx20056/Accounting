using Accounting.FileSystem.DAL;
using Accounting.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Accounting.SqlBase;

namespace Accounting.Controller
{
    public class AccRecord_Controller
    {
        IAccountingDAL<AccRecord, AccRecordQuery> _AccRecordDAl;
        public AccRecord_Controller(string SavePth)
        {
            _AccRecordDAl = new AccRecordDAL(SavePth);
        }
        public AccRecord_Controller(IDbConnection conn)
        {
            _AccRecordDAl = new AccRecordDAL_SQL(conn);
        }
        public int Add(AccRecord m)
        {
            return _AccRecordDAl.Add(m);
        }

        public int Delete(AccRecord m)
        {
            return _AccRecordDAl.Delete(m);
        }

        public int Edit(AccRecord m)
        {
            return _AccRecordDAl.Edit(m);
        }

        public List<AccRecord> GetAll(AccRecordQuery q)
        {
            return _AccRecordDAl.GetAll(q);
        }
    }
}
