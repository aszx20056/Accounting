using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Accounting
{
    public  class AppSettIng: IAppSettIng
    {
        public  string DataPath {
            get {
                string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                return Path.Combine(assemblyFolder, "Save.txt");
            }
        }
    }
}
