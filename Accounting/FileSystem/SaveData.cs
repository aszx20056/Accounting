using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Accounting.FileSystem
{
    public class SaveData
    {
        AppSettIng AppSettIng = new AppSettIng();
        public bool HasFile {
            get {
                return File.Exists(AppSettIng.DataPath);
            }
        }
        public void CreatSave()
        {
            File.Create(AppSettIng.DataPath);
        }
        public void ClearSave()
        {
            File.Delete(AppSettIng.DataPath);
        }
    }
}
