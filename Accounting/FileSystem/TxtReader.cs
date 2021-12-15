using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
namespace Accounting.FileSystem
{
    public class TxtReader
    {
        private string SaveLoc { get; set; }
        public TxtReader(string SaveLoc)
        {
            this.SaveLoc = SaveLoc;
        }
        public bool HasFile {
            get {
                return File.Exists(SaveLoc);
            }
        }
        public void CreatSave()
        {
            using (var writer = File.CreateText(SaveLoc))
            {
                writer.Write("[]");
            }
        }
        public void InitSave()
        {
            if (!HasFile)
            {
                CreatSave();
            }
        }
        public void SaveAllText<T>(List<T> data)
        {
            string dstr = JsonConvert.SerializeObject(data);
            File.WriteAllText(SaveLoc,dstr);
        }
        public void ClearSave()
        {
            File.Delete(SaveLoc);
        }
        public List<T> ReadAs<T>()
        {
            string txt = File.ReadAllText(SaveLoc);
            return JsonConvert.DeserializeObject<List<T>>(txt);
        }
    }
}
