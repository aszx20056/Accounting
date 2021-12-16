using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Accounting.Model;
using System.Linq;
namespace Accounting.FileSystem.DAL
{
    public class AccRecordDAL: IAccountingDAL<AccRecord, AccRecordQuery>, IAccRecordDAL
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
            IEnumerable<AccRecord> res = Score;
            if (q.InAcTp != null)
            {
                res = res.Where(x => q.InAcTp.Contains(x.AcTp));
            }
            return res.ToList();
        }
        public int Add(AccRecord m)
        {
            Score.Add(m);
            reader.SaveAllText(Score);
            return 1;
        }
        public int Edit(AccRecord m)
        {
            int index = Score.FindIndex(x => m.PRCIE == m.PRCIE);
            Score[index] = m;
            for (int i = 0; i < Score.Count; i++)
            {
                var row = Score[i];
                if (row.PRCIE == m.PRCIE)
                {
                    Score[i] = m;
                    break;
                }
            }
            if (index == -1)
            { return 0; }
            reader.SaveAllText(Score);
            return 1;
        }
        public int Delete(AccRecord m)
        {
            int index = -1;
            for (int i = 0; i < Score.Count; i++)
            {
                var row = Score[i];
                if (row.PRCIE == m.PRCIE)
                {
                    Score.Remove(row);
                    break;
                }
            }
            if (index == -1)
            { return 0; }
            reader.SaveAllText(Score);
            return 1;
        }

    }
}
