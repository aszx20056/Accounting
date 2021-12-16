using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Model
{
    public interface IAccountingDAL<T,T2>where T2:T 
    {
        List<T> GetAll(T2 q);
        int Add(T m);
        int Edit(T m);
        int Delete(T m);
    }
    public interface IAccRecordDAL
    {
        List<AccRecord> GetAll(AccRecordQuery q);
        int Add(AccRecord m);
        int Edit(AccRecord m);
        int Delete(AccRecord m);
    }
}
