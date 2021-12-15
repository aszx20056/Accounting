using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Accounting.Model;

namespace Accounting.FileSystem.DAL
{
    public class AccRecordDAL
    {
        private TxtReader reader { get; set; }
        private static List<AccRecord> Score { get; set; }
        public AccRecordDAL(string SavePath)
        {
            reader = new TxtReader(SavePath);
            reader.InitSave();
            if (Score == null)
            {
                Score = reader.ReadAs<AccRecord>();
            }
        }
        public List<AccRecord> GetAll(AccRecordQuery q)
        {
            return Score;
        }

    }
}
