using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Accounting.FileSystem
{
    public class SaveData
    {
        private string SaveLoc { get; set; }
        public SaveData(string SaveLoc)
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
            File.Create(SaveLoc);
        }
        public void ClearSave()
        {
            File.Delete(SaveLoc);
        }
    }
}
